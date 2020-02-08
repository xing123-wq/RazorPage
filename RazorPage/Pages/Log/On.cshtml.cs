using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;

namespace RazorPage
{
    [BindProperties]
    public class OnModel : PageModel
    {
        public LogOnUser LogOnOne { get; set; }
        public bool RememberMe { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "登录-一起帮";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            if (correct(LogOnOne.LogOnUserName, LogOnOne.LogOnUserPassword))
            {
                Response.Cookies.Append("UserId", "986", new CookieOptions { Expires = DateTime.Now.AddDays(15) });
                Response.Cookies.Append("Password", "1234");
            }
            new UserLogOnRepository().Sava(LogOnOne);
        }
        private bool correct(string name, string password)
        {
            return true;
        }
    }
}