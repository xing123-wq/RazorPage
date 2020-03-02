using _17bangMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMvc.Controllers
{
    public class LogOnController : Controller
    {
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
        public void Cookie(OnModel model)
        {
            HttpCookie cookie = new HttpCookie("UserName");
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