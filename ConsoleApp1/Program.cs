using System;

namespace ConsoleApp1
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            //用变量name存储你的姓名，然后输出带有你姓名的入栈口号
            string input = Console.ReadLine();
            Console.WriteLine("源栈欢迎您，" + input);
            string name = "幸龙泰";
            Console.WriteLine(name + "源栈欢迎您！");
            //在“入栈口号”的基础上，使用变量Age（年龄）、IsFemale（是否男生）、Height（身高，单位米）、FromCity（来自哪里）存储你的个人信息，并在控制台逐行输出
            int Age = 16;
            Console.WriteLine("年龄：" + Age);
            bool IsFemale = false;
            Console.WriteLine("是不是女的：" + IsFemale);
            int Height = 175;
            Console.WriteLine("身高：" + Height + "m");
            string FromCity = "重庆";
            Console.WriteLine("来自:" + FromCity);
            //输出两个整数/小数的和/差/积/商
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
            for (i = 1; i <= 5; i++)
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
            for (i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("二维数组：");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine(array[i, j]);

                }
            }
            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            int sum = 0;
            for (i = 1; i < 100; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            double[] aj = { 10, 9, 0.6, 42.34, 312 };
            double max = aj[0], min = aj[0];
            Console.WriteLine("最大值：");
            for (i = 0; i < aj.Length; i++)
            {
                if (max < aj[i])
                {
                    max = aj[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("最小值：");
            for (i = 0; i < aj.Length; i++)
            {
                if (min > aj[i])
                {
                    min = aj[i];
                }
            }
            Console.WriteLine(min);
            //找到100以内的所有质数（只能被1和它自己整除的数）
            //test1:
            Console.ReadLine();

        }
    }
}
