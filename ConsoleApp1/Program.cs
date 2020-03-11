using System;

namespace ConsoleApp1
{
    class Program
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Site { get; set; }
        public int Height { get; set; }
        public DateTime Time { get; set; }
        static void Main(string[] args)
        {
            //int[][] text = new int[7][];
            //text[0] = new int[] { 1, 2, 3, 4 };
            //text[1] = new int[] { 1, 2 };
            //text[2] = new int[5];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int j = 0; j < text[i].Length; j++)
            //    {
            //        Console.WriteLine(text[i][j]);
            //    }
            //}
            //int[] a = { 12, 56, 9, 32, 66, 77, 84, 2, 1 };
            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = 0; j < a.Length - i - 1; j++)
            //    {
            //        if (a[j] > a[j + 1])
            //        {
            //            int temp = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("升序排序后的结果为：");
            //foreach (int b in a)
            //{
            //    Console.Write(b + " ");
            //}
            //Program program = new Program();
            //program.AllMethod();
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
        }
        //将之前以下作业封装成方法（自行思考参数和返回值），并调用执行

        // 自我介绍：SelfIntroduce()
        //加减乘除：Add() / Minus() / Mutiply() / Divide()
        //取字符值：GetUnicode()
        //取最高分：GetMax()
        //且以后作业，如无特别声明，皆需使用方法封装
        //计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        //完成“猜数字”游戏，方法名GuessMe()：
        //随机生成一个大于0小于1000的整数
        //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        //没猜中可以继续猜，但最多不能超过10次
        //如果5次之内猜中，输出：你真牛逼！
        //如果8次之内猜中，输出：不错嘛！
        //10次还没猜中，输出：(～￣(OO)￣)ブ
        public void AllMethod()
        {
            SelfIntroduce();
            Arithmetic(12, 34);
            GetUnicode('了');
            GetMax(new int[] { 12, 45, 5, 4, 2, 1, 556 });
            GetAverage(new double[] { 2, 34, 12.4, 56, 112, 55 });
            //GuessMe();
            int bed = 2;
            int beds = 1;
            Console.WriteLine($"初始值：{ bed},{ beds}");
            Swap(ref bed, ref beds);
            Console.WriteLine($"交换 {bed},{beds}");
        }
        public void SelfIntroduce()
        {
            Name = "阿泰";
            Age = 16;
            Site = "重庆";
            Height = 176;
            Time = DateTime.Now;
            Console.WriteLine($"我叫{Name}\n今年{Age}岁\n来自{Site}\n身高{Height}cm\n{Time}来到这里");
        }
        static int Arithmetic(int score, int sores)
        {
            //输出两个整数/小数的和/差/积/商
            Console.WriteLine("Arithmetic：");
            Console.WriteLine("和：" + (score + sores));
            Console.WriteLine("差：" + (score - sores));
            Console.WriteLine("积：" + (score * sores));
            Console.WriteLine("商：" + Math.Round((score / (float)sores), 2));  //保留小数点
            return (sores + score);
        }
        static char GetUnicode(char price)
        {
            Console.WriteLine("\nGet Unicode：");
            Console.WriteLine((int)price);
            return price;
        }
        static int[] GetMax(int[] score)
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
                int a;
                bool result = int.TryParse(input, out a);
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
        static void Swap(ref int BedID, ref int bed2)
        {
            int k = 0;
            k = BedID;
            BedID = bed2;
            bed2 = k;

        }
    }
}


