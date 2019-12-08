using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    enum Token
    {
        SuperAdmin,
        Admin,
        Blogger,
        Newbie,
        Registered
    }
    class TokenManager
    {
        //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
        //1:声明一个令牌管理（TokenManager）类：
        //使用私有的Token枚举_tokens存储所具有的权限
        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和查看其权限
        //2:将TokenManager作为User类的属性
        private Token _token;
        public void Add(Token Permissions)
        {
            _token = Permissions | _token;
        }
        public void Remove(Token Permissions)
        {
            _token = Permissions ^ _token;
        }
        public bool Has(Token Permissions)
        {
            return false;
        }
    }

}
