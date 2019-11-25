using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Article : Content
    {
        public Article(string kind) : base(kind) { }

        public void MoneyAeount(int reward)
        {
            Console.WriteLine("覆盖" + reward + "了");
        }
    }

}
