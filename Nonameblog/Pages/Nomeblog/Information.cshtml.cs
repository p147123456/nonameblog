using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nonameblog.Models;
namespace Nonameblog.Pages.Nomeblog
{
    public class InformationModel : PageModel
    {
        private readonly Nonameblog.Data.ApplicationDbContext _context;
        public InformationModel(Nonameblog.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public ApplicationUser currentUser { get; set; }
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            currentUser = _context.Users.FirstOrDefault(x => x.Id == id);
            if (currentUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}