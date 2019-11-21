using System;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            User newbie = new User("");
            User not = new User();
            Program a = new Program();
            HelpMoney b = new HelpMoney();
            new User().Reward = -1;
            //作者积分
            Problem Release = new Problem();
            Release.Author = new User("阿泰");
            Release.Publish();
        }

        //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、
        //Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //将之前User / Problem / HelpMoney类的字段封装成属性，其中：
        //user.Password在类的外部只能读不能改，且为User类添加ChangePasword()方法，以修改其密码
        //如果user.Name为“admin”，输入时修改为“系统管理员”
        //problem.Reward不能为负数
        internal class User
        {
            internal User(string inviter)
            {

            }
            public User()
            {

            }
            internal int HelpMony { get; set; }
            internal int credit { get; set; }
            private int _reward;
            public int Reward
            {
                get
                {
                    return _reward;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("奖赏不能为负数!");
                    }
                    else
                    {
                        _reward = value;
                    }



                }
            }
            public string Name { get; set; }
            private string Password { get; set; }
            public User Invitedby { get; set; }
            internal string elevaterank(string label)
            {
                return label;
            }
            //提升等级的方法
            static void Register()
            {

            }
            static void Login()
            {

            }
            internal void ChangePasword(string data)
            {



            }

        }
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、
        //悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        internal class Problem
        {
            internal string Title { get; set; }
            public string Body { get; set; }
            internal int Reward { get; set; }
            public DateTime PublishDateTime { get; set; }
            internal User Author { get; set; }
            internal void Publish()
            {
                Author.credit++;
            }
            internal Problem()
            {

            }

        }
        //帮帮币版块，定义一个类HelpMoney，包含你认为应该包含的字段和方法
        internal class HelpMoney
        {
            internal HelpMoney()
            {

            }
            public DateTime Time { get; set; }
            public int usable { get; set; }
            public int frost { get; set; }
            public string kind { get; set; }
            public int change { get; set; }
            public string remark { get; set; }

            static void Gainkind()
            {

            } //获取帮帮币的种类
            static void Acquirecount()
            {

            }//获得到的帮帮币的数量
            static void Buy()
            {

            }//所购买的帮帮币
            static void Sell()
            {

            }//所出售的帮帮币
            static void SillHelpMoney()
            {

            }//获得帮帮币的门槛


        }
        //定义一个仓库（Repoistory）类，其中包含：
        //一个int类型的常量version
        //一个静态只读的字符串connection，以后可用于连接数据库
        //思考Respoitory应该是static类还是实例类更好
        internal class Repoistory
        {
            internal const int VERSION = 1;
            static readonly string Connection;
        }
        //考虑求助的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
        //Publish()：发布一篇求助，并将其保存到数据库
        //Load(int Id)：根据Id从数据库获取一条求助
        //Delete()：删除某个求助
        //repoistory：可用于在底层实现上述方法和数据库的连接操作等
        //设计一个类FactoryContext，保证整个程序运行过程中，
        //无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）

    }
}
