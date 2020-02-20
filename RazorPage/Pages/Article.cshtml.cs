using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _17bnag.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Repositorys;

namespace RazorPage
{
    public class TaskModel : _LayoutModel
    {
        public IList<Articles> Articles;
        public int Pageindex { get; set; }
        public int pagesize { get; set; }
        public void OnGet()
        {
            pagesize = 2;
            Pageindex = Convert.ToInt32(Request.Query["Page"]);
            Articles = new ArticleRepoistory().Get(Pageindex, pagesize);
            base.SetLogOnStatus();
            ViewData["title"] = "精品文章--一起帮";
        }
    }
}