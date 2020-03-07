using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///个人资料的变量存储信息
            string HeadPortrait;
            ///头像获取的是本地图片的路径，然后进行上传
            ///我觉得可以用bytep[]字节流来保存
            bool IsFemale;
            ///选择男true,选择女fales。
            ///这样容易if,eles判断
            int BirthYear;
            ///因为年龄是整数
            string Constellation;
            string keyword;
            ///这个该用keyword类型
            ///因为可以在keyword类中通过id得到
            string SelfDescription;
        }
    }
}
