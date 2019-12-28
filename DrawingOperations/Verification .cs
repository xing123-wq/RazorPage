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
            Color[] myColor = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Brown, Color.Brown, Color.DarkBlue };
            Color tempColor = myColor[random.Next(myColor.Length)];
            string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "仿宋" };
            string typeface = fonts[random.Next(fonts.Length)];
            //画噪音点
            for (int j = 0; j < 100; j++)
            {
                int x = random.Next(image.Width);
                int y = random.Next(image.Height);
                Color Color = myColor[random.Next(myColor.Length)];
                image.SetPixel(x, y,Color);
            }

            //画噪音线
            for (int i = 0; i < 25; i++)
            {
                int x1 = random.Next(image.Width);
                int x2 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int y2 = random.Next(image.Height);
                Color Color = myColor[random.Next(myColor.Length)];
                g.DrawLine(new Pen(Color ), new Point(x1, y1), new Point(x2, y2));

            }
            
            g.DrawString(GenerateRandomNumber(4),       //绘制字符串
                new Font(typeface, 20),                //指定字体
                new SolidBrush(tempColor),      //绘制时使用的刷子
                new PointF(90, 50)                    //左上角定位
            );

            image.SetPixel(195, 95, Color.BlueViolet);  //绘制一个像素的点
            image.Save(@"F:\17bang\hello.jpg", ImageFormat.Jpeg);   //保存到文件

        }
        private static char[] constant =
        {
           '0','1','2','3','4','5','6','7','8','9',
           'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
           'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
           '王','老','飞','哥','可'
        };
        public static string GenerateRandomNumber(int Length)   
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62);
            Random rd = new Random();
            Color[] myColor = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Brown, Color.Brown, Color.DarkBlue };

            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }
    }
}
