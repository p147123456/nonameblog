using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Nonameblog.Areas.Identity.Services
{
    public class SendMailByGmail
    {
        private IConfiguration _configuration { get; }
        public SendMailByGmail(IConfiguration config)
        {
            _configuration = config;
        }
        #region 寄信相關
        /// <summary>
        /// 寄信smtp server
        /// </summary>
        public string SmtpServer { get { return _configuration.GetValue<string>("Smtp:Server"); } }

        //必填sender
        /// <summary>
        /// 寄信帳號
        /// </summary>
        public string MailFrom { get {return _configuration.GetValue<string>("Smtp:Account"); } }
        /// <summary>
        /// 寄信帳號
        /// </summary>
        /// Encoding.UTF8.GetString(Convert.FromBase64String(_configuration.GetValue<string>("Smtp:Password")));
        public string pass { get { return Encoding.UTF8.GetString(Convert.FromBase64String(_configuration.GetValue<string>("Smtp:Password"))); } }
        /// <summary>
        /// Port
        /// </summary>
        public  int port { get { return _configuration.GetValue<int>("Smtp:Port"); } }
        /// 寄信函數
        /// </summary>
        /// <param name="MailTos">收信人Email Address</param>
        public void Mail_SendAsync(string[] MailTos, string MailSub, string MailBody)
        {
            //先行轉成Base 64
            string subject = Convert.ToBase64String(Encoding.UTF8.GetBytes(MailSub));
            Task.Run(async () =>
            {
                //建立MailMessage物件
                MailMessage mms = new MailMessage()
                {
                    BodyEncoding = Encoding.GetEncoding("UTF-8"),
                    SubjectEncoding = System.Text.Encoding.UTF8,
                    //指定一位寄信人MailAddress
                    From = new MailAddress(MailFrom),
                    //信件主旨
                    Subject = string.Format("=?utf-8?B?{0}?=", subject),
                    //信件內容
                    Body = MailBody,
                    //信件內容 是否採用Html格式
                    IsBodyHtml = true
                };
                if (MailTos != null)
                {
                    foreach (string mailAddress in MailTos)
                    {
                        //信件的收信人(們)address
                        mms.To.Add(new MailAddress(mailAddress));
                    }
                }

                try
                {
                    using (SmtpClient client = new SmtpClient(SmtpServer,port))//或公司、客戶的smtp_server
                    {
                        client.UseDefaultCredentials = false;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential(MailFrom, pass);
                        //.net 4.5才有的 SendMailAsync 方法
                        await client.SendMailAsync(mms);//寄出一封信
                        //避免附件被Lock無法異動
                        if (mms.Attachments != null && mms.Attachments.Count > 0)
                        {
                            mms.Attachments.Dispose();
                        }
                        mms.Dispose();
                    }//end using  
                }
                catch (Exception ex)
                {
                    //寄信失敗，寫Log文字檔 
                    ex.ToString();
                }
            });

        }//End 寄信
        #endregion
    }
}
