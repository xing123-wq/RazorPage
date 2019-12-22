using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ContentService
    {
        //添加一个新类ContentService，其中有一个发布（Publish()）方法：
        //如果发布Article，需要消耗一个帮帮币
        //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
        //如果发布Suggest，不需要消耗帮帮币
        //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine() 代替。根据我们学习的继承和多态知识，实现上述功能。
        public static void Publish(Content content)
        {
            try
            {
                content.Publish();
            }
            catch (ArgumentNullException e1)
            {
                Console.WriteLine("内容的作者不能为空" + e1.InnerException);

            }
            catch (ArgumentException e2)
            {
                //Console.WriteLine();
                //e2.InnerException = e2;

                throw (new Exception("求助的Reward为负数（-XX）", e2));

            }
            finally
            {
                Console.WriteLine($"{DateTime.Now}请求发布内容（Id=XXX)");


            }
        }
    }
}