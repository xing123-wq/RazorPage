using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _17bnag.Data;
using _17bnag.Entitys;

namespace _17bnag
{
    public class CreateModel : PageModel
    {
        private readonly _17bnag.Data._17bnagContext _context;

        public CreateModel(_17bnag.Data._17bnagContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HelpRelease HelpRelease { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HelpRelease.Add(HelpRelease);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
