using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Helper;

namespace RazorPage
{
    public class OffModel : _LayoutModel
    {
        public ActionResult OnGet()
        {
            Response.Cookies.Delete(Const.USER_ID);
            Response.Cookies.Delete(Const.USER_PASSWORD);
            base.SetLogOnStatus();
            return RedirectToPage("/Log/On");
        }
    }
}