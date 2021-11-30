using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nonameblog.Models
{
    public enum Artcile_type
    {
        廢文,
        恐怖,
        美食
    }
    public class Artcile
    {
        [Key]
        public int ID { get; set; }
        public string AuthorID { get; set; }
        [Required(ErrorMessage = "請輸入標題")]
        public string Tittle { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "請輸入內容")]
        [MaxLength(30000, ErrorMessage = "請勿超過30000個字")]
        [MinLength(30, ErrorMessage = "至少輸入30字內容")]
        public string Content { get; set; }
        [Required]
        public Artcile_type Type { get; set; }
        [NotMappedAttribute]
        [FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg",ErrorMessage ="請選擇圖片")]
        public IFormFile Upload { get; set; }

        public Artcile()
        {
            
        }
        //public Artcile(string _id, string _name, string _score)
        //{
        //}
    }

    public class Comment 
    {
        [Key]
        public int ID { get; set; }
        public int PKID { get; set; }
        [Required(ErrorMessage = "留言不得空白")]
        [MaxLength(300, ErrorMessage = "請勿超過300個字")]
        [MinLength(10, ErrorMessage = "至少輸入10字內容")]
        public string Message { get; set; }
        [Required(ErrorMessage = "暱稱不得空白")]
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CommentTime { get; set; } 
    }
}
