using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _17bnag.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
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
