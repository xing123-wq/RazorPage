using System;

namespace ConsoleApp1
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            //    string input = Console.ReadLine();
            //    Console.WriteLine("源栈欢迎您，" + input);
            //double a = 2.7;
            //double b = 0.3;
            //string k = "小数：";
            //Console.WriteLine(k);
            //Console.WriteLine("和：" + (a + b));
            //Console.WriteLine("差：" + (a - b));
            //Console.WriteLine("积：" + (a * b));
            //Console.WriteLine("商：" + (a / b));

            ////输入一个字符，显示这个字符的unicode值
            //char unicode = '牛';
            //Console.WriteLine((int)unicode);
            ////测试用例
            ////test1:
            ////1>="六六顺"
            ////test3:
            ////21>="大吉大利"
            ////test2:
            ////24>="六六顺"
            //////输入一个整数，如果这个整数：
            ////能被6整除，显示：六六顺
            ////能被8整除，显示：发发发
            ////否则，显示：大吉大利
            //int integer = 21;
            //if (integer % 6 == 0)
            //{
            //    Console.WriteLine("六六顺");
            //}
            //else if (integer % 8 == 0)
            //{
            //    Console.WriteLine("发发发");
            //}
            //else
            //{
            //    Console.WriteLine("大吉大利");
            //}
            ///*/
            //将源栈同学姓名 / 昵称分别：
            //按进栈时间装入一维数组，
            //按座位装入二维数组，
            //并输出共有多少名同学。/*/
            //string[] names = new string[] { "阿泰", "与围墙", "清哥", "王总", "彭总", "陈百万" };
            //Console.WriteLine(names.Length);
            //string[,] array = new string[2, 3] { { "幸龙泰", "于维谦", "曾俊清" }, { "王新", "彭志强", "陈百万" } };
            //Console.WriteLine(array.Length);

            //// 电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（精确到小数点以后x位）
            //Console.WriteLine((Math.Round(((23 + 7) * 12 - 8) / (float)6, 2)));


            ////分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            ////int i;
            //Console.WriteLine("for循环：");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("while循环：");
            //int q = 0;
            //while (q < 5)
            //{
            //    q++;
            //    Console.WriteLine(q);
            //}
            //Console.WriteLine("for循环:");
            //int t;
            //for (t = 1; t < 10; t++)
            //{
            //    if (t % 2 != 0)
            //    {
            //        Console.WriteLine(t);
            //    }
            //}
            //Console.WriteLine("while循环:");
            //int w = 0;
            //while (w < 10)
            //{
            //    if (w % 2 != 0)
            //    {
            //        Console.WriteLine(w);
            //    }
            //    w++;
            //}
            ////用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //Console.WriteLine("一维数组：");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.WriteLine("二维数组：");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(array[i, j]);

            //    }
            //}
            ////让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 1; i < 100; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            ////将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] aj = { 10, 9, 0.6, 42.34, 312 };
            //double max = aj[0], min = aj[0];
            //Console.WriteLine("最大值：");
            //for (int i = 0; i < aj.Length; i++)
            //{
            //    if (max < aj[i])
            //    {
            //        max = aj[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine("最小值：");
            //for (int i = 0; i < aj.Length; i++)
            //{
            //    if (min > aj[i])
            //    {
            //        min = aj[i];
            //    }
            //}
            //Console.WriteLine(min);
            ////找到100以内的所有质数（只能被1和它自己整除的数）
            //Console.WriteLine("找质数：");
            //for (int i = 1; i <= 100; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            break;
            //        }
            //        if (j == i - 1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //自我介绍：SelfIntroduce()
            SelfIntroduce(16, false, 175, "重庆");
            Console.ReadLine();
            //加减乘除：Add() / Minus() / Mutiply() / Divide()
            Arithmetic(43, 22);
            //取字符值：GetUnicode()
            GetUnicode('你');
            //取最高分：GetMax()
            GetMax(new double[] { 12.2, 33, 55, 323, 77, 21, 0.2 });
            //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            GetAverage(new double[] { 12, 43, 56, 78, 99, 0.4 });
            //完成“猜数字”游戏，方法名GuessMe()
            //GuessMe();
            //利用ref调用Swap()方法交换两个同学的床位号 
            int i = 2;
            int k = 1;
            Swap(ref i, ref k);
            Console.WriteLine("交换" + i + "," + k);
            //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
            var student = SelfIntroduction();
            Console.WriteLine(student.height);
            Console.WriteLine(student.name);
            Console.WriteLine(student.gender);
        }
        static void SelfIntroduce(int Age, bool IsFemale, int Height, string FromCity)
        {
            Console.WriteLine("Self-Introduction ：");
            string name;
            name = Console.ReadLine();
            Console.WriteLine(name + "源栈欢迎您！");
            Console.WriteLine("年龄：" + Age);
            Console.WriteLine("是不是女的：" + IsFemale);
            Console.WriteLine("身高：" + Height + "m");
            Console.WriteLine("来自:" + FromCity);
        }
        //将之前以下作业封装成方法（自行思考参数和返回值），并调用执行
        static int Arithmetic(int score, int ser)
        {
            //输出两个整数/小数的和/差/积/商
            Console.WriteLine("Arithmetic：");
            Console.WriteLine("和：" + (score + ser));
            Console.WriteLine("差：" + (score - ser));
            Console.WriteLine("积：" + (score * ser));
            Console.WriteLine("商：" + Math.Round((score / (float)ser), 2));  //保留小数点
            return (ser + score);
        }

        static char GetUnicode(char price)
        {
            Console.WriteLine("\nGet Unicode：");
            Console.WriteLine((int)price);
            return price;
        }
        static double[] GetMax(double[] score)
        {
            Console.WriteLine("\nSeek Max：");
            double max = score[0];
            for (int i = 0; i < score.Length; i++)
            {
                if (max < score[i])
                {
                    max = score[i];
                }
            }
            Console.WriteLine(max);
            return score;
        }
        //且以后作业，如无特别声明，皆需使用方法封装
        static double[] GetAverage(double[] mean)
        {
            Console.WriteLine("\nGetAverage：");
            double sum = 0;
            for (int i = 0; i < mean.Length; i++)
            {
                sum = sum + mean[i];
            }
            double scores = Math.Round((sum / mean.Length), 2);
            Console.WriteLine(scores);
            return mean;
        }
        //完成“猜数字”游戏，方法名GuessMe()
        static void GuessMe()
        {
            Random num = new Random();
            int randomNum = num.Next(1000);  /*666*/
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("第" + (i + 1) + "次," + "请输入一个整数：");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out int a);
                if (result == true)
                {
                    int inputNum = int.Parse(input);
                    if (inputNum > randomNum)
                    {
                        Console.WriteLine("大了！");
                        if (i >= 9)
                        {
                            Console.WriteLine("^(*￣(oo)￣)^ ！");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (inputNum < randomNum)
                    {
                        Console.WriteLine("小了！");
                        if (i >= 9)
                        {
                            Console.WriteLine("^(*￣(oo)￣)^ ！");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (inputNum == randomNum)
                    {
                        if (i < 5)
                        {
                            Console.WriteLine("碉堡了！");
                        }
                        else if (i < 7)
                        {
                            Console.WriteLine("666！");
                        }
                        else if (i <= 9)
                        {
                            Console.WriteLine("猜到了！");
                        }
                        else
                        {
                            // nothing to do
                        }
                        break;
                    }
                    else
                    {
                        // nothing to do
                    }
                }
                else if (i < 9)
                {
                    Console.WriteLine("请输入一个数字！");
                }
                else
                {
                    if (i >= 9)
                    {
                        Console.WriteLine("^(*￣(oo)￣)^ ！");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        //利用ref调用Swap()方法交换两个同学的床位号 
        static void Swap(ref int BedID, ref int bed2)
        {
            int k;
            k = BedID;
            BedID = bed2;
            bed2 = k;

        }
        //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
        //最小值（默认为1）
        //相邻两个元素之间的最大差值（默认为5）
        //元素个数（默认为10个）
        

        //重载GetArray()，使其返回一个string[]
        //实现二分查找，方法名BinarySeek()
        //引用传递：传递的是变量本身



        //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
        static (string name, int height, bool gender) SelfIntroduction()
        {
            Console.WriteLine("\ntuple:");
            return ("幸龙泰", 176, true);
        }


        //实现方法：
        //IndexOf()，通过遍历在无序数组中
        //BinarySearch()，通过二分查找法在一个有序数组中
        //找到某个值的下标，找不到返回-
        
    }
}

