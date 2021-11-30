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
    public class IndexModel : PageModel
    {
        private readonly Nonameblog.Models.NonameblogContext _context;

        public IndexModel(Nonameblog.Models.NonameblogContext context)
        {
            _context = context;
        }

        public IList<Artcile> Artcile { get;set; }

        public async Task OnGetAsync()
        {
            Artcile = await _context.Artcile.ToListAsync();
        }

    }
}
