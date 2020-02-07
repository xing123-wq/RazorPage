using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage;

namespace RazorPage
{
    public class ForGetModel : PageModel
    {
        public ContactEdit ForGetOne { get; set; }
        public void OnGet()
        {
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
