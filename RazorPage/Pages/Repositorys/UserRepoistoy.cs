using _17bnag.Entitys;
using Microsoft.Win32;
using RazorPage.Pages.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Pages.Class
{
    public class UserRepoistoy
    {
        private static IList<RegisterUser> Registers;
        static UserRepoistoy()
        {
            Registers = new List<RegisterUser>
            {
                new RegisterUser
                {
                    Id=2,Name="彭昆真帅",Password="1234".GetMd5Hash()
                },
                new RegisterUser
                {
                    Id=1,Name="陈元真帅",Password="qwer".GetMd5Hash()
                }
            };
        }
        public void Sava(RegisterUser user)
        {

        }
        public RegisterUser GetLog(string name)
        {
            return Registers.Where(u => u.Name == name).SingleOrDefault();
        }
        internal RegisterUser Load(int id)
        {
            //模拟的方法
            return Registers.Where(u => u.Id == id).SingleOrDefault();
        }
    }
}
