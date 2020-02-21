using System;
using System.Collections.Generic;
using _17bnag.Entitys;
using _17bnag.Layout;
using _17bnag.Repositorys;
namespace _17bnag.Pages
{
    public class ArticleModel : _LayoutModel
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