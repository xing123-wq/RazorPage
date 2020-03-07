using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /////个人资料的变量存储信息
            //string HeadPortrait;
            /////头像获取的是本地图片的路径，然后进行上传
            /////我觉得可以用bytep[]字节流来保存
            //bool IsFemale;
            /////选择男true,选择女fales。
            /////这样容易if,eles判断
            //int BirthYear;
            /////因为年龄是整数
            //string Constellation;
            //string keyword;
            /////这个该用keyword类型
            /////因为可以在keyword类中通过id得到
            //string SelfDescription;

            //输出两个整数 / 小数的和 / 差 / 积 / 商
            //int i = 23;
            //int j = 33;
            //Console.WriteLine(i + j);
            //Console.WriteLine(i - j);
            //Console.WriteLine(i * j);
            //Console.WriteLine(i / j);
            //double a = 2.7;
            //double b = 0.3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);

            //电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
            //Console.WriteLine((Math.Round(((23 + 7) * 12 - 8) / (float)6, 2)));

            ////当a为何值时，结果为true？
            //int a = 10;
            //bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
            //Console.WriteLine(result);

            //用户依次由控制台输入：验证码、用户名和密码：
            //如果验证码输入错误，直接输出：“*验证码错误”；
            //如果用户名不存在，直接输出：“*用户名不存在”；
            //如果用户名或密码错误，输出：“*用户名或密码错误”
            //以上全部正确无误，输出：“恭喜！登录成功！”
            //string input = Console.ReadLine();
            //if ("qwe1" == input)
            //{
            //    Console.WriteLine("请输入用户名");
            //    string inputs = Console.ReadLine();
            //    if ("wf23" == inputs)
            //    {
            //        Console.WriteLine("请输入密码");
            //        string inputPassword = Console.ReadLine();
            //        if ("1234" == inputPassword)
            //        {
            //            Console.WriteLine("恭喜！登录成功！");
            //        }
            //        else
            //        {
            //            Console.WriteLine("*用户名或密码错误");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("*用户名不存在");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("*验证码错误");
            //}
            //将源栈同学姓名 / 昵称分别：
            //按进栈时间装入一维数组，
            //按座位装入二维数组，
            //并输出共有多少名同学。
            string[] names = new string[] { "阿泰", "与围墙", "清哥", "王总", "彭总", "陈百万" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine(names.Length);
            string[,] array = new string[2, 3] { { "幸龙泰", "于维谦", "曾俊清" }, { "王新", "彭志强", "陈百万" } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            Console.WriteLine(array.Length);
        }

    }
}

