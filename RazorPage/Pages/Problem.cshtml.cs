using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;

namespace RazorPage
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