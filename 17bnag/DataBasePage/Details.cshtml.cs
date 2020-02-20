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
    public class DetailsModel : PageModel
    {
        private readonly _17bnag.Data._17bnagContext _context;

        public DetailsModel(_17bnag.Data._17bnagContext context)
        {
            _context = context;
        }

        public HelpRelease HelpRelease { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HelpRelease = await _context.HelpRelease.FirstOrDefaultAsync(m => m.Id == id);

            if (HelpRelease == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
