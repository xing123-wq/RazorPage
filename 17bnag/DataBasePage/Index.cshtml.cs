using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _17bnag.Data;
using _17bnag.Entitys;

namespace _17bnag
{
    public class IndexModel : PageModel
    {
        private readonly _17bnag.Data._17bnagContext _context;

        public IndexModel(_17bnag.Data._17bnagContext context)
        {
            _context = context;
        }

        public IList<HelpRelease> HelpRelease { get;set; }

        public async Task OnGetAsync()
        {
            HelpRelease = await _context.HelpRelease.ToListAsync();
        }
    }
}
