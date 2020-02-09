using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Pages.Class;
using RazorPage.Pages.Helper;

namespace RazorPage
{
    public class _LayoutModel : PageModel
    {
        public UserLogOnRepository _userLogOnRepository { get; set; }
        public _LayoutModel()
        {
            _userLogOnRepository = new UserLogOnRepository();
        }
        public virtual void OnGet()
        {
            bool hasUserId = Request.Cookies.TryGetValue(Const.USER_ID, out string userId);
            bool hasPassword = Request.Cookies.TryGetValue(Const.USER_PASSWORD, out string password);
            if (hasUserId)
            {
                LogOnUser user = _userLogOnRepository.Load(Convert.ToInt32(userId));
                if (user.LogOnUserPassword == password)
                {
                    ViewData[Const.USER_NAME] = user.LogOnUserName;
                }
            }
        }
    }
}
