using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nonameblog.Models;

namespace Nonameblog.Pages.Nomeblog
{
    public class EditModel : PageModel
    {
        private readonly Nonameblog.Models.NonameblogContext _context;

        public EditModel(Nonameblog.Models.NonameblogContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Artcile).State = EntityState.Modified;

            try
            {
                Artcile.ReleaseDate = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtcileExists(Artcile.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Index");
        }

        private bool ArtcileExists(int id)
        {
            return _context.Artcile.Any(e => e.ID == id);
        }
    }
}
