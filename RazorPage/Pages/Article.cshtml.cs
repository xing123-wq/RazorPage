using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Entitys;
using RazorPage.Pages.Repositorys;

namespace RazorPage
{
    public class TaskModel : _LayoutModel
    {
        public IList<Articles> Articles;

        public void OnGet()
        {
            int pagesize = 2;
            int pageindex = Convert.ToInt32(Request.Query["Page"]);
            Articles = new ArticleRepoistory().Get(pageindex,pagesize);
            base.SetLogOnStatus();
            ViewData["title"] = "精品文章--一起帮";
        }
    }
}