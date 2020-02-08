using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class OnModel : _LayoutModel
    {
        public LogOnUser LogOnOne { get; set; }
        public bool RememberMe { get; set; }
        public override void OnGet()
        {
            base.OnGet();
            ViewData["title"] = "登录-一起帮";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            new UserLogOnRepository().Sava(LogOnOne);
            LogOnUser user = _userLogOnRepository.GetLog(LogOnOne.LogOnUserName);
            if (user == null)
            {
                ModelState.AddModelError("LogOnOne.LogOnUserName", "* 用户名不存在");
                return;
            }
            if (user.LogOnUserPassword != LogOnOne.LogOnUserPassword.GetMd5Hash())
            {
                ModelState.AddModelError("LogOnOne.LogOnUserPassword", "* 用户名或者密码不正确");
            }
            CookieOptions options = new CookieOptions
            {
                //显示Cookie过期时间
                Expires = DateTime.Now.AddDays(10)
            };
            //生成Cookie,保护用户信息
            Response.Cookies.Append("UserId", user.Id.ToString(), options);
            Response.Cookies.Append("Password", user.Id.ToString(), options);
            ViewData["UserName"] = user.LogOnUserName;
        }
        private bool correct(string name, string password)
        {
            return true;
        }
    }
}