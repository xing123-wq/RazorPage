using System;

namespace ConsoleApp3
{
    public class Article : Content
    {
        //public Article(string kind) : base(kind) { }
        public void MoneyAeount(int reward)
        {
            Console.WriteLine("覆盖" + reward + "了");
        }
        public void Publish()
        {
            Author.HelpMony -= 1;
        }
    }

}
