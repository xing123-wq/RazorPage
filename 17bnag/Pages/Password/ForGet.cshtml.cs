using _17bnag.Contact;
using _17bnag.Data;
using _17bnag.Entitys;
using _17bnag.Layout;

namespace _17bnag.Password
{
    public class ForGetModel : _LayoutModel
    {
        public ForGetModel(_17bnagContext context) : base(context)
        {
        }

        public ContactEdit ForGetOne { get; set; }
        public void OnGet()
        {
            base.SetLogOnStatus();
            ViewData["title"] = "忘了-一起帮";
        }
        public void OnPost()
        {

        }
    }
}
