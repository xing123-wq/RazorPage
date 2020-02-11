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
        public _KeywordModel Keywords { get; }
        public ProblemModel()
        {
            Keywords = new _KeywordModel
            {
                naems = new List<string>
                {
                    "编程开发语言","C#","JAVA","工具软件","Javascript","顾问咨询","html","VisualStudio","操作系统","SQL","职场","法律",".net","Python","CSS","Linux"
                }
            };
        }
        public void OnGet()
        {
            base.SetLogOnStatus();
            int pagesize = 2;
            int pageindex = Convert.ToInt32(Request.Query["Page"]);
            //int pageindex = 0;
            Problems = new ProblemRepoistory().Get(pageindex, pagesize);
            ViewData["title"] = "首页-一起帮";
        }
        public void Post()
        {

        }
    }
}