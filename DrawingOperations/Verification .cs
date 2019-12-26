using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingOperations
{
    class Verification
    {
        //作业：
        //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
        //随机字符串
        //混淆用的各色像素点
        //混淆用的直线（或曲线）
        public static void Code()
        {
            Bitmap image = new Bitmap(200, 100);  //生成一个像素图“画板”

            Graphics g = Graphics.FromImage(image);    //在画板的基础上生成一个绘图对象
            g.Clear(Color.AliceBlue);           //添加底色

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);
                image.SetPixel(x, y, Color.FromArgb(random.Next()));
            }

            // Create pens.
            Pen redPen = new Pen(Color.Red, 4);
            Pen greenPen = new Pen(Color.Green, 3);
            // Create points that define curve.
            Point point1 = new Point(40, 100);
            Point point2 = new Point(50, 25);
            Point point3 = new Point(10, 55);
            Point point4 = new Point(200, 30);
            Point point5 = new Point(300, 120);
            Point point6 = new Point(350, 300);
            Point point7 = new Point(250, 2900);
            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7 };

            // Draw lines between original points to screen.
            g.DrawLines(redPen, curvePoints);
            // Draw curve to screen.
            g.DrawCurve(greenPen, curvePoints);

            g.DrawString(GenerateRandomNumber(8),       //绘制字符串
                new Font("宋体", 14),                //指定字体
                new SolidBrush(Color.DarkRed),      //绘制时使用的刷子
                new PointF(6, 6)                    //左上角定位
            );

            image.SetPixel(195, 95, Color.BlueViolet);  //绘制一个像素的点

            image.Save(@"F:\17bang\hello.jpg", ImageFormat.Jpeg);   //保存到文件

        }
        private static char[] constant =
     {
           '0','1','2','3','4','5','6','7','8','9',
           'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
           'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        public static string GenerateRandomNumber(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }
    }
}
