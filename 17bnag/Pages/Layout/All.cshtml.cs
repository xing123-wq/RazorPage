using System;
using _17bnag.Entitys;
using _17bnag.Helper;
using _17bnag.Repositorys;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _17bnag.Layout
{
    public class _LayoutModel : PageModel
    {
        public UserLogOnRepository _userLogOnRepository { get; set; }
        public UserRepoistoy _userRepoistoy { get; set; }
        public _LayoutModel()
        {
            _userLogOnRepository = new UserLogOnRepository();
            _userRepoistoy = new UserRepoistoy();
        }
        public virtual void SetLogOnStatus()
        {
            bool hasUserId = Request.Cookies.TryGetValue(Const.USER_ID, out string userId);
            bool hasPassword = Request.Cookies.TryGetValue(Const.USER_PASSWORD, out string password);
            bool hasRegisterId = Request.Cookies.TryGetValue(Const.REGISTER_ID, out string registerId);
            bool hasRegisterpassword = Request.Cookies.TryGetValue(Const.REGISTER_PASSWORD, out string registerPassword);
            if (hasUserId)
            {
                LogOnUser user = _userLogOnRepository.Load(Convert.ToInt32(userId));
                if (user.LogOnUserPassword == password)
                {
                    ViewData[Const.USER_NAME] = user.LogOnUserName;
                }
            }
            if (hasRegisterId)
            {
                RegisterUser registerUser = _userRepoistoy.Load(Convert.ToInt32(registerId));
                if (registerUser.Password == registerPassword)
                {
                    ViewData[Const.REGISTER_NAME] = registerUser.Name;
                }
            }
        }
    }
}
