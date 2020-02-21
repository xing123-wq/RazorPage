using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _17bnag.Entitys;
using _17bnag.Layout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bnag.Problems
{
    [BindProperties]
    public class NewsModel : _LayoutModel
    {
        public HelpRelease ReleaseOn { get; set; }
        public void OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "(新消息)我要求助--一起帮";
        }
    }
}
