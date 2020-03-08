using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //找到100以内的所有质数（只能被1和它自己整除的数）
            //在一个整数数组中找到最大值
            double[] score = { 10, 9, 0.6, 42.34, 312 };
            double max = score[0], min = score[0];
            Console.WriteLine("最大值：");
            for (int i = 0; i < score.Length; i++)
            {
                if (max < score[i])
                {
                    max = score[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine("最小值：");
            for (int i = 0; i < score.Length; i++)
            {
                if (min > score[i])
                {
                    min = score[i];
                }
            }
            Console.WriteLine(min);
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

    }
}

