using System;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //观察“一起帮”的：
            //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、
            //Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
            //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、
            //悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
            //帮帮币版块，定义一个类HelpMoney，包含你认为应该包含的字段和方法
            //调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
            User newbie = new User("");
            User not = new User();
            Program a = new Program();
            HelpMoney b = new HelpMoney();
            //为这些类的字段和方法设置合适的访问修饰符。
        }

        //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、
        //Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        private class User
        {
            public string Name;
            internal string Password;
            public User Invitedby;
            static void Register()
            {

            }
            static void Login()
            {

            }
            internal User(string inviter)
            {

            }
            public User()
            {

            }
        }
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、
        //悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        class Problem
        {
            internal string Title;
            public string Body;
            internal int Reward;
            public DateTime PublishDateTime;
            internal string Author;
            static void Publish()
            {

            }
            internal Problem()
            {

            }

        }
        //帮帮币版块，定义一个类HelpMoney，包含你认为应该包含的字段和方法
        class HelpMoney
        {
            private DateTime Time;
            private int usable;
            private int frost;
            private string kind;
            private int change;
            private string remark;
            static void GainTime()
            {

            } //获取帮帮币的时间
            static void AcquireMony()
            {

            }//所得到的帮帮币
            static void BuyHelpMony()
            {

            }//所购买的帮帮币
            static void SellHelpMoney()
            {

            }//所出售的帮帮币
            static void SillHelpMoney()
            {

            }//获得帮帮币的门槛
            internal HelpMoney()
            {

            }

        }
    }
}
