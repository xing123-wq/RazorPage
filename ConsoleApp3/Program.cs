using System;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //User newbie = new User("");
            //User not = new User();
            //Program a = new Program();
            //HelpMoney b = new HelpMoney();
            //new User().Reward = -1;
            ////作者积分
            //Problem Release = new Problem("1");
            //Release.Author = new User("阿泰");
            //Release.Publish();
            //Content ad = new Problem("1");
            //Problem p = new Problem();
            //new ContentService().Publish(p);
            //new DBMessage().send();
            //new EmailMessage().send();

            //StudentInformation atai = new StudentInformation();
            //atai.score = 98;
            //StudentInformation wx = atai;
            //Console.WriteLine(wx.score);
            //atai.score = 100;
            //Console.WriteLine(wx.score);

            //GetWeeks(2019/1/1);
            Student s = new Student();
            s.Information();
        }
        //源栈的学费是按周计费的，所以请实现这两个功能：
        //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
        //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
        static void GetWeeks(int year)
        {
            DateTime date = GetFirstModay(year);
            DateTime LastMonday = GetFirstModay(year + 1).AddDays(-7);
            while (date < LastMonday)
            {
                Console.WriteLine(date.ToString("yyyy年MM月dd日"));
                date = date.AddDays(6);
                Console.WriteLine("-");
                Console.WriteLine(date.ToString("yyyy年MM月dd日"));
                date = date.AddDays(1);
                Console.WriteLine();
            }
        }
        private static DateTime GetFirstModay(int year)
        {
            DateTime date = new DateTime(year, 1, 1);
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(1);
            }
            return date;
        }
        //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
        enum Token
        {
            SuperAdmin,
            Admin,
            Blogger,
            Newbie,
            Registered
        }
        //1:声明一个令牌管理（TokenManager）类：
        //使用私有的Token枚举_tokens存储所具有的权限
        //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和查看其权限
        //2:将TokenManager作为User类的属性
    }
}
