using Microsoft.AspNetCore.Mvc;
using RazorPage.Pages.Helper;
using System.Collections.Generic;
using System.Linq;

namespace RazorPage.Pages.Class
{
    [BindProperties]
    public class UserLogOnRepository
    {
        private static IList<LogOnUser> _users;
        static UserLogOnRepository()
        {

            _users = new List<LogOnUser>
            {
                new LogOnUser { Id = 2, LogOnUserName = "阿泰真帅", LogOnUserPassword = "1234".GetMd5Hash() },
                new LogOnUser { Id = 1, LogOnUserName = "飞哥真帅", LogOnUserPassword = "qwer".GetMd5Hash() }
            };
        }
        public void Sava(LogOnUser user)
        {

        }
        public LogOnUser GetLog(string name)
        {
            return _users.Where(u => u.LogOnUserName == name).SingleOrDefault();
        }
        internal LogOnUser Load(int id)
        {
            //模拟的方法
            return _users.Where(u => u.Id == id).SingleOrDefault();
        }
    }
}

