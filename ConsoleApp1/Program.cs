using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("\n交换" + i + "," + k);
            //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
            var student = SelfIntroduction();
            Console.WriteLine(student.height);
            Console.WriteLine(student.name);
            Console.WriteLine(student.gender);
            //生成随机数组
            GetArray();
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
        static int[] GetArray(int min = 1, int step = 5, int length = 10)
        {
            Console.WriteLine("\n随机数组:");
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = new Random().Next(min, min + step);
                min = result[i] + 1;
                Console.WriteLine(result[i]);
            }
            return result;
        }


        //重载GetArray()，使其返回一个string[]

        //实现二分查找，方法名BinarySeek()
        //引用传递：传递的是变量本身



        //使用tuple作为参数，重构SelfIntroduction()方法，输出自我介绍
        static (string name, int height, bool gender) SelfIntroduction()
        {
            Console.WriteLine("\ntuple:");
            return ("幸龙泰", 176, true);
        }

        //重载GetArray()，使其返回一个string[]
        //实现方法：
        //IndexOf()，通过遍历在无序数组中
        //BinarySearch()，通过二分查找法在一个有序数组中
        //找到某个值的下标，找不到返回-1


    }
}


