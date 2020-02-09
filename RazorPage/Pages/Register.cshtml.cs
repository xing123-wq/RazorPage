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
    public class RegisterModel : _LayoutModel
    {
        public RegisterUser RegisteerOne { get; set; }
        public  void OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "注册-一起帮";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            new UserRepoistoy().Sava(RegisteerOne);
        }

    }
}