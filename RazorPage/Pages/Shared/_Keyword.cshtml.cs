using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage
{
    public class _KeywordModel : PageModel
    {
        public IList<string> naems { get; set; }
        public void OnGet()
        {

        }
    }
}