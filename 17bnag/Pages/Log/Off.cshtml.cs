using _17bnag.Data;
using _17bnag.Helper;
using _17bnag.Layout;
using Microsoft.AspNetCore.Mvc;

namespace _17bnag.Log
{
    public class OffModel : _LayoutModel
    {
        public OffModel(_17bnagContext context) : base(context)
        {
        }

        public ActionResult OnGet()
        {
            Response.Cookies.Delete(Const.USER_ID);
            Response.Cookies.Delete(Const.USER_PASSWORD);
            base.SetLogOnStatus();
            return RedirectToPage("/Log/On");
        }
    }
}