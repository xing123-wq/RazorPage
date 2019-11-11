using System;

namespace ConsoleApp1
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("源栈欢迎您，" + input);
            string name = "幸龙泰";
            Console.WriteLine(name + "源栈欢迎您！");
            int Age = 16;
            Console.WriteLine("年龄：" + Age);
            bool IsFemale = false;
            Console.WriteLine("是不是女的：" + IsFemale);
            int Height = 175;
            Console.WriteLine("身高：" + Height + "m");
            string FromCity = "重庆";
            Console.WriteLine("来自:" + FromCity);
            int i = 43;
            int j = 33;
            string l = "整数：";
            Console.WriteLine(l);
            Console.WriteLine("和：" + (i + j));
            Console.WriteLine("差：" + (i - j));
            Console.WriteLine("积：" + (i * j));
            Console.WriteLine("商：" + (i / (float)j));
            double a = 2.7;
            double b = 0.3;
            string k = "小数：";
            Console.WriteLine(k);
            Console.WriteLine("和：" + (a + b));
            Console.WriteLine("差：" + (a - b));
            Console.WriteLine("积：" + (a * b));
            Console.WriteLine("商：" + (a / b));

            char unicode = '牛';
            Console.WriteLine(unicode);

            int integer = 64;
            if (integer % 6 == 0)
            {
                Console.WriteLine("六六顺");
            }
            else
            {

            }

            if (integer % 8 == 0)
            {
                Console.WriteLine("发发发");
            }
            else
            {
                Console.WriteLine("大吉大利");
            }

            string[] names = new string[] { "阿泰", "与围墙", "清哥", "王总" };
            Console.WriteLine(names.Length);
            int[,] array = new int[ 2, 4];
            Console.WriteLine(array);
            Console.ReadLine();

        }
    }
}
