using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;
using RazorPage.Pages.Filters;
using RazorPage.Pages.Helper;

namespace RazorPage
{
    [BindProperties]
    [AddHeader]
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
            CookieOptions options = new CookieOptions();
            LogOnUser user = _userLogOnRepository.GetLog(LogOnOne.LogOnUserName);
            new UserLogOnRepository().Sava(LogOnOne);
            if (!ModelState.IsValid)
            {
                ViewData["title"] = "登录-一起帮";
                return Page();
            }
            if (user == null)
            {
                ModelState.AddModelError(Const.LOGON_LOGONUSERNAME, "* 用户名不存在");
                return Page();
            }
            if (user.LogOnUserPassword != LogOnOne.LogOnUserPassword.GetMd5Hash())
            {
                ModelState.AddModelError(Const.LOGON_LOGONPASSWORD, "* 用户名或者密码不正确");
                return Page();
            }
            LogOnCookies();
            Response.Redirect("/Profiel/Write");
            return Page();
        }
        public void LogOnCookies()
        {
            CookieOptions options = new CookieOptions();
            if (LogOnOne.RememberMe)
            {
                options.Expires = DateTime.Now.AddDays(14);
            }
            else
            {
                options.Expires = DateTime.Now.AddDays(1);
            }
            LogOnUser user = _userLogOnRepository.GetLog(LogOnOne.LogOnUserName);
            Response.Cookies.Append(Const.USER_ID, user.Id.ToString(), options);
            Response.Cookies.Append(Const.USER_PASSWORD, user.LogOnUserPassword.ToString(), options);
            Response.Cookies.Append(Const.LOGON_REMEMBERME, user.RememberMe.ToString(), options);
            ViewData[Const.USER_NAME] = user.LogOnUserName;
        }
    }
}