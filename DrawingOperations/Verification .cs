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

            g.DrawLine(new Pen(Color.Black), new Point(0, 0), new Point(100, 50)); //画直线
            g.DrawString("hello, luckystack",       //绘制字符串
                new Font("宋体", 14),                //指定字体
                new SolidBrush(Color.DarkRed),      //绘制时使用的刷子
                new PointF(5, 6)                    //左上角定位
            );

            image.SetPixel(195, 95, Color.BlueViolet);  //绘制一个像素的点

            image.Save(@"F:\17bang\hello.jpg", ImageFormat.Jpeg);   //保存到文件

        }
    }
}
