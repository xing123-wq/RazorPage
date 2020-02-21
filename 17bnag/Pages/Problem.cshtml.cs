using System;
using System.Collections.Generic;
using _17bnag.Entitys;
using _17bnag.Layout;
using _17bnag.Repositorys;

namespace _17bnag.Pages
{
    public class ProblemModel : _LayoutModel
    {
        public IList<Problem> Problems { get; set; }
        public int pagesize { get; set; }
        public int pageindex { get; set; }
        public ProblemModel()
        {
        }
        public void OnGet()
        {
            pagesize = 2;
            pageindex = Convert.ToInt32(Request.Query["Page"]);
            Problems = new ProblemRepoistory().Get(pageindex, pagesize);
            ViewData["title"] = "首页-一起帮";
            base.SetLogOnStatus();
        }
        public void Post()
        {

        }
    }
}