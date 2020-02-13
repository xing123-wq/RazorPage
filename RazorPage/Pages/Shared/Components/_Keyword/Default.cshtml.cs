using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using RazorPage.Pages.Shared;
using RazorPage.Pages.View_Component;

namespace RazorPage
{
    public class DefaultModel : _LayoutModel
    {
        public List<string> naems { get; set; }
        public DefaultModel Keywords { get; private set; }

        public void OnGet()
        {

        }
        public DefaultModel Default()
        {
            return Keywords = new DefaultModel
            {
                naems = new List<string>
                {
                    "编程开发语言","C#","JAVA","工具软件","Javascript","顾问咨询","html","VisualStudio","操作系统","SQL","职场","法律",".net","Python","CSS","Linux"
                }
            };
        }
    }
}