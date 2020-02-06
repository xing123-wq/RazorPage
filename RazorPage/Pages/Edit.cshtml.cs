using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
{
    [BindProperties]
    public class EditModel : PageModel
    {
        public User EditOne { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "修改联系方式-一起帮";
        }
        public void OnPost()
        {
            new UserEdit().Sava(EditOne);
        }
    }
    public class UserEdit
    {
        public void Sava(User user)
        {

        }
    }
}