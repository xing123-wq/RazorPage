using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;
using RazorPage.Pages.Helper;

namespace RazorPage
{
    [BindProperties]
    public class RegisterModel : _LayoutModel
    {
        public RegisterUser RegisteerOne { get; set; }
        public PageResult OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "注册-一起帮";
            return Page();
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            new UserRepoistoy().Sava(RegisteerOne);
            RegisterUser user = _userRepoistoy.GetLog(RegisteerOne.Name);
            if (user != null)
            {
                if (user.Name == RegisteerOne.Name)
                {
                    ModelState.AddModelError(Const.REGISTER_NAME, "* 用户名已存在");
                    return;
                }
                if (user.Password != RegisteerOne.Password.GetMd5Hash())
                {
                    ModelState.AddModelError(Const.REGISTER_PASSWORD, "* 用户名或者密码不正确");
                }
            }
            if (user!=null)
            {
                CookieOptions options = new CookieOptions
                {
                    //显示Cookie过期时间
                    Expires = DateTime.Now.AddDays(14)
                };
                //生成Cookie,保护用户信息
                Response.Cookies.Append(Const.REGISTER_ID, user.Id.ToString(), options);
                Response.Cookies.Append(Const.REGISTER_PASSWORD, user.Password.ToString(), options);
                ViewData[Const.REGISTER_NAME] = user.Name;
            }
        }
        private bool Correct(string name, string password)
        {
            return true;
        }
    }
}