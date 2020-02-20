using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _17bnag.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage;

namespace RazorPage
{
    public class ForGetModel : _LayoutModel
    {
        public ContactEdit ForGetOne { get; set; }
        public void OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "忘了-一起帮";
        }
        public void OnPost()
        {
            new UserEdit().Sava(ForGetOne);
        }
    }
}
public class UserForGet
{
    public void Sava(RegisterUser user)
    {

    }
}
