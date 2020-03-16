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

        public void OnGet()
        {
            Response.Cookies.Delete(Const.USER_ID);
            Response.Cookies.Delete(Const.USER_PASSWORD);
            base.SetLogOnStatus();
            GetUrl();

        }
        public void GetUrl()
        {
            string pagepth = Request.Query["pagepth"];
            if (pagepth == "/Log/On")
            {
                Response.Redirect("/Index");
            }
            else
            {
                Response.Redirect(pagepth);
            }
            if (pagepth == "/Register")
            {
                Response.Redirect("/Index");
            }
        }
    }
}