using System;
using System.Linq;
using _17bnag.Entitys;
using _17bnag.Helper;
using _17bnag.Layout;
using _17bnag.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bnag.Log
{
    [BindProperties]
    //[AddHeader]
    public class OnModel : _LayoutModel
    {
        public User LogOnOne { get; set; }
        public PageResult OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "登录-一起帮";
            return Page();
        }
        public IActionResult OnPost()
        {
            CookieOptions options = new CookieOptions();
            User user = _userLogOnRepository.GetLog(LogOnOne.Name);
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
            if (user.Password != LogOnOne.Password.GetMd5Hash())
            {
                ModelState.AddModelError(Const.LOGON_LOGONPASSWORD, "* 用户名或者密码不正确");
                return Page();
            }
            LogOnCookies();
            GetUrl();
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
            User user = _userLogOnRepository.GetLog(LogOnOne.Name);
            Response.Cookies.Append(Const.USER_ID, user.Id.ToString(), options);
            Response.Cookies.Append(Const.USER_PASSWORD, user.Password.ToString(), options);
            Response.Cookies.Append(Const.LOGON_REMEMBERME, user.RememberMe.ToString(), options);
            ViewData[Const.USER_NAME] = user.Name;
        }
        public void GetUrl()
        {
            string pagepth = Request.Query["pagepth"];
            if (pagepth == "/Log/On")
            {
                Response.Redirect("/Index");
            }
            else
            {
                Response.Redirect(pagepth);
            }
            if (pagepth == "/Register")
            {
                Response.Redirect("/Index");
            }
        }
    }
}