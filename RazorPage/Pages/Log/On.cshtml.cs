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
        public PageResult OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "登录-一起帮";
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            new UserLogOnRepository().Sava(LogOnOne);
            LogOnUser user = _userLogOnRepository.GetLog(LogOnOne.LogOnUserName);
            if (user == null)
            {
                ModelState.AddModelError(Const.LOGON_LOGONUSERNAME, "* 用户名不存在");
                return Page();
            }
            if (user.LogOnUserPassword != LogOnOne.LogOnUserPassword.GetMd5Hash())
            {
                ModelState.AddModelError(Const.LOGON_LOGONPASSWORD, "* 用户名或者密码不正确");
            }
            if (LogOnOne.RememberMe == true)
            {
                CookieOptions options = new CookieOptions
                {
                    //显示Cookie过期时间
                    Expires = DateTime.Now.AddDays(14)
                };
                //生成Cookie,保护用户信息
                Response.Cookies.Append(Const.USER_ID, user.Id.ToString(), options);
                Response.Cookies.Append(Const.USER_PASSWORD, user.LogOnUserPassword.ToString(), options);
                Response.Cookies.Append(Const.LOGON_REMEMBERME, user.RememberMe.ToString(), options);
                ViewData[Const.USER_NAME] = user.LogOnUserName;
            }
            else
            {
                CookieOptions options = new CookieOptions
                {
                    //显示Cookie过期时间
                    Expires = DateTime.Now.AddDays(1)
                };
                //生成Cookie,保护用户信息
                Response.Cookies.Append(Const.USER_ID, user.Id.ToString(), options);
                Response.Cookies.Append(Const.USER_PASSWORD, user.LogOnUserPassword.ToString(), options);
                Response.Cookies.Append(Const.LOGON_REMEMBERME, user.RememberMe.ToString(), options);
                ViewData[Const.USER_NAME] = user.LogOnUserName;
            }
            if (user != null)
            {
                if (user.LogOnUserPassword == LogOnOne.LogOnUserPassword.GetMd5Hash())
                {
                    Response.Redirect("/Profiel/Write");
                }
            }
            return Page();
        }
        private bool Correct(string name, string password)
        {
            return true;
        }
    }
}