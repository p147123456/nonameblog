using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Nonameblog.Models;

namespace Nonameblog.Pages.Nomeblog.API
{
    public class DataModel : PageModel
    {
        private readonly Nonameblog.Models.NonameblogContext _context;
        private readonly Nonameblog.Data.ApplicationDbContext _User;
        public Nonameblog.Models.Artcile Artcile { get; set; }
        public IList<Nonameblog.Models.Comment> _Comment { get; set; }
        public ApplicationUser currentUser { get; set; }
        public DataModel(Nonameblog.Models.NonameblogContext context, Nonameblog.Data.ApplicationDbContext context2)
        {
            _context = context;
            _User = context2;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                IList<Nonameblog.Models.Artcile> _temp;
                _temp = await _context.Artcile.ToListAsync();
                List<Send_data> _mdata = new List<Send_data>();
                foreach (var Artcile in _temp)
                {
                    if (Artcile == null)
                    {
                        return NotFound();
                    }
                    Send_data tempdata = new Send_data();
                    _Comment = await _context.Comment.ToListAsync();
                    var _Author = await _User.Users.FirstOrDefaultAsync(m => m.Id == Artcile.AuthorID);
                    tempdata.ID = Artcile.ID;
                    tempdata.Tittle = Artcile.Tittle;
                    tempdata.Type = Artcile.Type;
                    tempdata.ReleaseDate = Artcile.ReleaseDate.ToString();
                    tempdata.Content = Artcile.Content;
                    //文章作者
                    tempdata.AuthorID.userID = _Author.Id;
                    tempdata.AuthorID.username = _Author.Name;
                    tempdata.AuthorID.Email = _Author.Email;
                    //文章下留言者
                    foreach (var commenter in _Comment)
                    {
                        if (commenter.PKID == Artcile.ID)
                        {
                            var commentuser = await _User.Users.FirstOrDefaultAsync(m => m.Id == commenter.Name);
                            if (commentuser != null)
                            {
                                Nonameblog.Pages.Nomeblog.API.Comment comment = new Comment();
                                comment.Message = commenter.Message;
                                comment.CommentTime = commenter.CommentTime.ToString();
                                comment.User.userID = commentuser.Id;
                                comment.User.username = commentuser.Name;
                                comment.User.Email = commentuser.Email;
                                tempdata.Comments.Add(comment);
                            }
                        }
                    }
                    _mdata.Add(tempdata);
                }
                return new JsonResult(_mdata);
            }
            else
            {
                Artcile = await _context.Artcile.FirstOrDefaultAsync(m => m.ID == id);
                if (Artcile == null)
                {
                    return NotFound();
                }
                _Comment = await _context.Comment.ToListAsync();
                var Author = await _User.Users.FirstOrDefaultAsync(m => m.Id == Artcile.AuthorID);
                Send_data mdata = new Send_data();
                mdata.ID = Artcile.ID;
                mdata.Tittle = Artcile.Tittle;
                mdata.Type = Artcile.Type;
                mdata.ReleaseDate = Artcile.ReleaseDate.ToString();
                mdata.Content = Artcile.Content;
                //文章作者
                mdata.AuthorID.userID = Author.Id;
                mdata.AuthorID.username = Author.Name;
                mdata.AuthorID.Email = Author.Email;
                //文章下留言者
                foreach (var commenter in _Comment)
                {
                    if (commenter.PKID == Artcile.ID)
                    {
                        var commentuser = await _User.Users.FirstOrDefaultAsync(m => m.Id == commenter.Name);
                        if (commentuser != null)
                        {
                            Nonameblog.Pages.Nomeblog.API.Comment comment = new Comment();
                            comment.Message = commenter.Message;
                            comment.CommentTime = commenter.CommentTime.ToString();
                            comment.User.userID = commentuser.Id;
                            comment.User.username = commentuser.Name;
                            comment.User.Email = commentuser.Email;
                            mdata.Comments.Add(comment);
                        }
                    }
                }

                return new JsonResult(mdata);
            }
        }
    }
    public class Send_data
    {
        public Send_data()
        {
            AuthorID = new User();
            Comments = new List<Comment>();
        }
        public int ID { get; set; }
        public User AuthorID { get; set; }
        public string Tittle { get; set; }
        public string ReleaseDate { get; set; }
        public string Content { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Artcile_type Type { get; set; }
        public List<Comment> Comments { get; set; }
    }
    public class Comment
    {
        public Comment()
        {
            User = new User();
        }
        public string Message { get; set; }
        public User User { get; set; }
        public string CommentTime { get; set; }
    }
    public class User
    {
        public string userID { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
    }
}
