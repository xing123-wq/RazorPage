using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;

namespace RazorPage
{
    public class ProblemModel : PageModel
    {
        public IList<Problem> Problems { get; set; }
        public void OnGet()
        {
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