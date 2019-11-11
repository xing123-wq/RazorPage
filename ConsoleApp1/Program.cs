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
            string[] names = new string[] { "阿泰", "与围墙", "清哥", "王总" };
            Console.WriteLine(names.Length);
            string[,] array = new string[2, 3] { { "阿泰", "与围墙", "清哥" }, { "王总", "", "" } };
            Console.WriteLine(array.Length);

            // 电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（精确到小数点以后x位）
            Console.WriteLine((Math.Round(((23 + 7) * 12 - 8) / (float)6, 2)));


            Console.ReadLine();

        }
    }
}
