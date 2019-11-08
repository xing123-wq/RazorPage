using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("源栈欢迎您，" + input);
            Console.ReadLine();
            string name = "幸龙泰";
            Console.WriteLine(name + "源栈欢迎您！");
            Console.ReadLine();
            int Age = 16;
            Console.WriteLine("年龄：" + Age);
            Console.ReadLine();
            bool IsFemale = false;
            Console.WriteLine("是不是女的：" + IsFemale);
            Console.ReadLine();
            int Height = 175;
            Console.WriteLine("身高：" + Height + "m");
            Console.ReadLine();
            string FromCity = "重庆";
            Console.WriteLine("来自:" + FromCity);
            Console.ReadLine();
            int i = 43;
            int j = 33;
            string l = "整数：";
            Console.WriteLine(l);
            Console.WriteLine("和：" + (i + j));
            Console.WriteLine("差：" + (i - j));
            Console.WriteLine("积：" + (i * j));
            Console.WriteLine("商：" + (i / j));
            double a = 2.7;
            double b = 0.3;
            string k = "小数：";
            Console.WriteLine(k);
            Console.WriteLine("和：" + (a + b));
            Console.WriteLine("差：" + (a - b));
            Console.WriteLine("积：" + (a * b));
            Console.WriteLine("商：" + (a / b));


        }
    }
}
