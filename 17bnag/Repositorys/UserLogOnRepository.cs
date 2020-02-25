using _17bnag.Entitys;
using _17bnag.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _17bnag.Repositorys
{
    public class UserLogOnRepository
    {
        private static IList<User> _users;
        static UserLogOnRepository()
        {
            _users = new List<User>
            {
                new User { Id = 2, Name = "阿泰真帅", Password = "1234".GetMd5Hash() },
                new User { Id = 1, Name = "飞哥真帅", Password = "qwer".GetMd5Hash() }
            };

        }
        public void Sava(User user)
        {

        }
        public User GetLog(string name)
        {
            return _users.Where(u => u.Name == name).SingleOrDefault();
        }
        internal User Load(int id)
        {
            //模拟的方法
            return _users.Where(u => u.Id == id).SingleOrDefault();
        }
    }
}

