using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nonameblog.Models;

namespace Nonameblog.Pages.Nomeblog
{
    public class DeleteModel : PageModel
    {
        private readonly Nonameblog.Models.NonameblogContext _context;

        public DeleteModel(Nonameblog.Models.NonameblogContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Artcile Artcile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artcile = await _context.Artcile.FirstOrDefaultAsync(m => m.ID == id);

            if (Artcile == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artcile = await _context.Artcile.FindAsync(id);

            if (Artcile != null)
            {
                _context.Artcile.Remove(Artcile);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
