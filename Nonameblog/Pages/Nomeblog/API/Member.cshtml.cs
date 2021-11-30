using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nonameblog.Pages.Nomeblog.API
{
    public class MemberModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            
        }
    }
    public class Person
    {
        public string firstname { get; set; }
        public string name { get; set; }
        public string message { get; set; }
    }
}