using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
{
    [BindProperties]
    public class ProfielModel : PageModel
    {
        public bool? IsFemale { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "个人资料--一起帮";
        }
        public void OnPost()
        {

        }
    }
}