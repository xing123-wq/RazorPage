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
    public class RegisterModel : PageModel
    {
        public User RegisteerOne { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "注册-一起帮";
        }
        public void OnPost()
        {
            new UserRepoistoy().Sava(RegisteerOne);
        }
    }
}