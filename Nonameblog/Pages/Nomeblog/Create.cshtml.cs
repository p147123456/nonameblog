using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Nonameblog.Areas.Identity.Services;
using Nonameblog.Models;

namespace Nonameblog.Pages.Nomeblog
{
    //需要登入才允許
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly Nonameblog.Models.NonameblogContext _context;

        public CreateModel(Nonameblog.Models.NonameblogContext context, IHostingEnvironment appEnvironment, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _appEnvironment = appEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            if (!IsEmailConfirmed)
            {
                return RedirectToPage("../Message", new { message = "請先至帳戶管理完成信箱驗證" });
            }
            return Page();
        }

        [BindProperty]
        public Artcile Artcile { get; set; }

        public async Task<IActionResult> OnPostAsync(string Authorid)
        {
            Artcile.AuthorID = Authorid;
            Artcile.ReleaseDate = DateTime.Now;
            if(Artcile.Upload!=null )
            {

                var file = Path.Combine(_appEnvironment.WebRootPath, "uploads");
                if (!Directory.Exists(file))
                {
                    Directory.CreateDirectory(file);
                }
                using (var fileStream = new FileStream(Path.Combine(file, Artcile.Upload.FileName), FileMode.Create))
                {
                    await Artcile.Upload.CopyToAsync(fileStream);
                }
            }


            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Artcile.Add(Artcile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception ex) {
                TempData["msg"] = "<script>alert('格式錯誤，請重新輸入！');</script>";
                return Page();
            }
            return RedirectToPage("Index");
        }
    }
}