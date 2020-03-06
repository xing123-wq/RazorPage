using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models;

namespace _17bangMvc.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        [Route("Article")]
        public ActionResult index()
        {
            ViewData["title"] = "精品文章-一起帮";
            return View();
        }
        [HttpPost]
        public ActionResult index(ArticleModel model)
        {
            return View();
        }
    }
}