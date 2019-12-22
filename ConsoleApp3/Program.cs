using System;
using System.Xml.Linq;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //User newbie = new User("");
            //User not = new User();
            //Program a = new Program();
            //HelpMoney b = new HelpMoney();
            //new User().Reward = -1;
            ////作者积分
            //Problem Release = new Problem("1");
            //Release.Author = new User("阿泰");
            //Release.Publish();
            //Content ad = new Problem("1");
            //Problem p = new Problem();
            //new ContentService().Publish(p);
            //new DBMessage().send();
            //new EmailMessage().send();

            //StudentInformation atai = new StudentInformation();
            //atai.score = 98;
            //StudentInformation wx = atai;
            //Console.WriteLine(wx.score);
            //atai.score = 100;
            //Console.WriteLine(wx.score);

            //GetWeeks(2019/1/1);
            //Student s = new Student();
            //s.Information();

            //Problem keyword = new Problem();
            //Console.WriteLine(keyword[1]);

            LinqWork.Do();
            //按以下格式生成一个XML对象：
            XElement articles = new XElement(
               "articles",
               new XComment("以下存放所有“源栈”所有文章"),
               new XElement("article",
                   new XAttribute("isDraft", false),
                   new XElement("id", "1"),
                   new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                   new XElement("body", "什么是XML（EXtensible Markup Language）" +
                   "是一种文本文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他："),
                   new XElement("authorId", "1"),
                   new XElement("publishDate", "2019/6/18 18:15"),
                   new XElement("comments",
                   new XElement("comment",
                   new XElement("id", "12"),
                   new XElement("body", "不错，赞！"),
                   new XElement("authorId", "2"),
                   new XAttribute("recommend", true)),
                   new XElement("comment",
                   new XElement("id", "14"),
                   new XElement("body", "作业太难了"),
                   new XElement("authorId", "3")))),
               new XElement("article",
                   new XElement("id", "2"),
                   new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                   new XElement("authorId", 1),
                   new XAttribute("isDraft", true))
               );
            Console.WriteLine(articles);
            XDocument document = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),   //添加一个XML声明
               articles);
            document.Save("F:\\17bang\\articles.xml");
        }
        //源栈的学费是按周计费的，所以请实现这两个功能：
        //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
        //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        static void GetWeeks(int year)
        {
            DateTime date = GetFirstModay(year);
            DateTime LastMonday = GetFirstModay(year + 1).AddDays(-7);
            while (date < LastMonday)
            {
                Console.WriteLine(date.ToString("yyyy年MM月dd日"));
                date = date.AddDays(6);
                Console.WriteLine("-");
                Console.WriteLine(date.ToString("yyyy年MM月dd日"));
                date = date.AddDays(1);
                Console.WriteLine();
            }
        }
        private static DateTime GetFirstModay(int year)
        {
            DateTime date = new DateTime(year, 1, 1);
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(1);
            }
            return date;
        }

    }
}
