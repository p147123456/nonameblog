using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nonameblog.Models;

namespace Nonameblog.Pages.Nomeblog.API
{
    public class ArtcileModel : PageModel
    {
        private readonly Nonameblog.Models.NonameblogContext _context;
        private Artcile artcile { get; set; }
        public ArtcileModel(Nonameblog.Models.NonameblogContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
               artcile = _context.Artcile.First(m => m.ID == id);
            }
            catch
            {
                return NotFound();
            }

            return new JsonResult(artcile);
        }
    }
}