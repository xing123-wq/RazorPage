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
            Problem Release = new Problem("1");
            Release.Author = new User("阿泰");
            Release.Publish();
            Content ad = new Problem("1");

        }
    }
}
