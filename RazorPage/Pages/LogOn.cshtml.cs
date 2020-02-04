using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;

namespace RazorPage
{
    [BindProperties]
    public class LogOnModel : PageModel
    {
        public User LogOnOne { get; set; }
        public bool RememberMe { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "登录-一起帮";
        }
        public void OnPost()
        {
            new UserLogOn().Sava(LogOnOne);
        }
    }
}