using _17bangMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17bangMvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            string name;
            ViewData["title"] = "一起帮-首页";
            //Session里面有值，就表示已经登录
            if (Session["User"] != null)
            {
                name = Session["User"].ToString();
            }
            //Session=null就跳转到登录页面
            else
            {
                return RedirectToAction("Login", "Login");
            }
            return Content("欢迎【" + name + "】登录");

        }
        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            return View();
        }
        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}