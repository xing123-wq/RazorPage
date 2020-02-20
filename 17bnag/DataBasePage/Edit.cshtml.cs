using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _17bnag.Data;
using _17bnag.Entitys;

namespace _17bnag
{
    public class EditModel : PageModel
    {
        private readonly _17bnag.Data._17bnagContext _context;

        public EditModel(_17bnag.Data._17bnagContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HelpRelease).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HelpReleaseExists(HelpRelease.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HelpReleaseExists(int id)
        {
            return _context.HelpRelease.Any(e => e.Id == id);
        }
    }
}
