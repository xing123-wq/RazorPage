using System;
using System.Collections.Generic;
using System.Linq;
using _17bnag.Data;
using _17bnag.Entitys;
using _17bnag.Layout;
using _17bnag.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace _17bnag.Pages
{
    public class ProblemModel : _LayoutModel
    {
        public IList<HelpRelease> Problems { get; set; }
        public _17bnagContext _context { get; set; }
        public int pagesize { get; set; }
        public int pageindex { get; set; }
        public ProblemModel(_17bnagContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            pagesize = 5;
            pageindex = Convert.ToInt32(Request.Query["Page"]);
            Problems = _context.HelpRelease.Include(h => h.Author).ToList();
            Problems = Get(pageindex, pagesize);
            ViewData["title"] = "首页-一起帮";
            base.SetLogOnStatus();
        }
        public void Post()
        {
        }
        public IList<HelpRelease> Get(int pageindex, int pagesize)
        {
            return Problems.OrderByDescending(p => p.PublishDateTime)
                .Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
        }
    }
}