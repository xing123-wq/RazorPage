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
        [HttpPost]
        public ActionResult index(OnModel model)
        {
            return View();
        }
    }
}