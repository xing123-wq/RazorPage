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
            //输出两个整数/小数的和/差/积/商
            int fromint = 43;
            int forint = 33;
            Console.WriteLine("\n整数");
            Console.WriteLine("和：" + (fromint + forint));
            Console.WriteLine("差：" + (fromint - forint));
            Console.WriteLine("积：" + (fromint * forint));
            Console.WriteLine("商：" + (fromint / (float)forint));
            double a = 2.7;
            double b = 0.3;
            string k = "小数：";
            Console.WriteLine(k);
            Console.WriteLine("和：" + (a + b));
            Console.WriteLine("差：" + (a - b));
            Console.WriteLine("积：" + (a * b));
            Console.WriteLine("商：" + (a / b));

            //输入一个字符，显示这个字符的unicode值
            char unicode = '牛';
            Console.WriteLine((int)unicode);
            //测试用例
            //test1:
            //1>="六六顺"
            //test3:
            //21>="大吉大利"
            //test2:
            //24>="六六顺"
            ////输入一个整数，如果这个整数：
            //能被6整除，显示：六六顺
            //能被8整除，显示：发发发
            //否则，显示：大吉大利
            int integer = 21;
            if (integer % 6 == 0)
            {
                Console.WriteLine("六六顺");
            }
            else if (integer % 8 == 0)
            {
                Console.WriteLine("发发发");
            }
            else
            {
                Console.WriteLine("大吉大利");
            }
            /*/
            将源栈同学姓名 / 昵称分别：
            按进栈时间装入一维数组，
            按座位装入二维数组，
            并输出共有多少名同学。/*/
            string[] names = new string[] { "阿泰", "与围墙", "清哥", "王总", "彭总", "陈百万" };
            Console.WriteLine(names.Length);
            string[,] array = new string[2, 3] { { "幸龙泰", "于维谦", "曾俊清" }, { "王新", "彭志强", "陈百万" } };
            Console.WriteLine(array.Length);

            // 电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（精确到小数点以后x位）
            Console.WriteLine((Math.Round(((23 + 7) * 12 - 8) / (float)6, 2)));


            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //int i;
            Console.WriteLine("for循环：");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("while循环：");
            int q = 0;
            while (q < 5)
            {
                q++;
                Console.WriteLine(q);
            }
            Console.WriteLine("for循环:");
            int t;
            for (t = 1; t < 10; t++)
            {
                if (t % 2 != 0)
                {
                    Console.WriteLine(t);
                }
            }
            Console.WriteLine("while循环:");
            int w = 0;
            while (w < 10)
            {
                if (w % 2 != 0)
                {
                    Console.WriteLine(w);
                }
                w++;
            }
            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            Console.WriteLine("一维数组：");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("二维数组：");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array[i, j]);

                }
            }
            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            int sum = 0;
            for (int i = 1; i < 100; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            double[] aj = { 10, 9, 0.6, 42.34, 312 };
            double max = aj[0], min = aj[0];
            Console.WriteLine("最大值：");
            for (int i = 0; i < aj.Length; i++)
            {
                if (max < aj[i])
                {
                    max = aj[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("最小值：");
            for (int i = 0; i < aj.Length; i++)
            {
                if (min > aj[i])
                {
                    min = aj[i];
                }
            }
            Console.WriteLine(min);
            //找到100以内的所有质数（只能被1和它自己整除的数）
            Console.WriteLine("找质数：");
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (j == i - 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            //自我介绍：SelfIntroduce()
            SelfIntroduce( "幸龙泰" ,  16 ,false,  175 , "重庆");

            Console.ReadLine();

        }

        static void SelfIntroduce(string name, int Age, bool IsFemale, int Height, string FromCity)
        {
            Console.WriteLine(name + "源栈欢迎您！");
            Console.WriteLine("年龄：" + Age);
            IsFemale = false;
            Console.WriteLine("是不是女的：" + IsFemale);
            Console.WriteLine("身高：" + Height + "m");
            Console.WriteLine("来自:" + FromCity);
        }
        //将之前以下作业封装成方法（自行思考参数和返回值），并调用执行

        //加减乘除：Add() / Minus() / Mutiply() / Divide()
        //取字符值：GetUnicode()
        //取最高分：GetMax()
        //且以后作业，如无特别声明，皆需使用方法封装
        //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        //完成“猜数字”游戏，方法名GuessMe()
    }
}
