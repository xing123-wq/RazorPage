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
            ViewData["title"] = "首页-一起帮";
            Problems = new ProblemRepoistory().Get();
        }
        public void Post()
        {

        }
    }
}