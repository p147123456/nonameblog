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
    public class SearchModel : PageModel
    {
        private readonly Nonameblog.Models.NonameblogContext _context;
        public SearchModel(Nonameblog.Models.NonameblogContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public IList<Artcile> Artcile { get; set; }
        public async Task OnGetAsync()
        {
            var artcile = from m in _context.Artcile
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                artcile = artcile.Where(s => s.Tittle.Contains(SearchString));
            }

            Artcile = await artcile.ToListAsync();
        }
    }
}