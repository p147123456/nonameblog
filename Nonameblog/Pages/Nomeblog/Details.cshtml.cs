using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nonameblog.Models;

namespace Nonameblog.Pages.Nomeblog
{
    public class DetailsModel : PageModel
    {
        private readonly Nonameblog.Models.NonameblogContext _context;

        public DetailsModel(Nonameblog.Models.NonameblogContext context)
        {
            _context = context;
        }

        public Artcile Artcile { get; set; }
        [BindProperty]
        public Comment Comment { get; set; }
        public IList<Comment> _Comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artcile = await _context.Artcile.FirstOrDefaultAsync(m => m.ID == id);
            _Comment = await _context.Comment.ToListAsync();
            if (Artcile == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id,string Name,string Message)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                TempData["msg"] = "<script>alert('名稱或內容過短，請重新輸入！');</script>";
                return RedirectToPage(new { id });
            }
            Artcile = await _context.Artcile.FindAsync(id);
            if (Name == null) { Name = "匿名"; }
            this.Comment = new Comment();
            this.Comment.PKID = (int)id;
            this.Comment.Name = Name;
            this.Comment.Message = Message;
            this.Comment.CommentTime = DateTime.Now;
            if (Artcile != null)
            {
                _context.Comment.Add(this.Comment);
                await _context.SaveChangesAsync();
            }           
            return RedirectToPage(new { id });
        }
    }
}
