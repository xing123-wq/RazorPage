using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _17bangMvc.Filters;
using SRV.ViewModel.Models;
using ViewModel.Models;

namespace _17bangMvc.Controllers
{
    [MVCFilter]
    public class LogOnController : Controller
    {
        HttpCookie cookie = new HttpCookie("UserName");
        [HttpGet]
        [Route("Log/On")]
        public ActionResult index()
        {
            ViewData["title"] = "用户登录:一起帮";
            return View();
        }
        [Route("Log/On")]
        [HttpPost]
        public ActionResult index(OnModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["title"] = "用户登录:一起帮";
            }
            Cookie(model);
            return View(model);
        }
        [HttpGet]
        [Route("Log/Off")]
        public ActionResult Off()
        {
            Response.AppendCookie(cookie);
            Request.Cookies.Remove("UserName");
            return RedirectToAction("index");
        }
        public void Cookie(OnModel model)
        {
            if (model.RememberMe)
            {
                cookie.Expires = DateTime.Now.AddDays(14);
            }
            else
            {
                cookie.Expires = DateTime.Now.AddDays(1);
            }
            Response.Cookies.Add(cookie);
        }
    }
}