﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
{
    public class NewsModel : _LayoutModel
    {
        public  void OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "(新消息)我要求助--一起帮";
        }
    }
}