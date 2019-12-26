using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class XML
    {
        public static void Do()
        {
            //operation();
            //UsersOperation();
            //Save();
            //SeekArticle();
            //PunlshArticle();
        }
        private static XElement operation()
        {
            ////按以下格式生成一个XML对象：
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
            return articles;



            //在根节点下添加一个新的article元素，内容至少包含id、title和authorId
            //articles.Add(new XElement("article",
            //         new XElement("id", 1),
            //         new XElement("title", "net"),
            //         new XElement("authorId", "2")));
            //articles.Save(@"F:\article.xml");
            //Console.WriteLine(articles);

            //删除id = 12的评论
            //var teachers = (from x in articles.Descendants("comment")
            //               where x.Element("id").Value == "12"
            //               select x).Single();
            //teachers.Remove();
            //articles.Save(@"F:\17bang\articles.xml");
            //Console.WriteLine(articles);

            //然后，将其以文件形式存放到磁盘中；
            //Console.WriteLine(articles);
            //XDocument document = new XDocument(
            //   new XDeclaration("1.0", "utf-8", "yes"),   //添加一个XML声明
            //   articles);
            //document.Save("F:\\17bang\\articles.xml");

            //改变id = 2的article：isDraft = false，title = 源栈培训：C#进阶-8：异步和并行
            //var alter = (from a in articles.Descendants("article")
            //            where a.Element("id").Value == "2"
            //            select a).Single();
            //alter.SetAttributeValue("isDraft",false);
            //alter.SetAttributeValue("title", "源栈培训：C#进阶-8：异步和并行");
            //articles.Save(@"F:\17bang\articles.xml");
            //Console.WriteLine(articles);
        }
        private static XElement UsersOperation()
        {
            //参照上述articles，代码生成一个XML的users对象，
            //能够存放用户的id、name和password，然后并存放到磁盘
            //扩展user和articles的内容，使其能够完成以下操作：
            //查出每个用户最近发布的一篇文章
            //每个用户评论最多的一篇文章
            //删除没有发表文章的用户
            XElement Users = new XElement(
                "Users",
                new XElement("User",
                new XElement("name", "大飞哥",
                new XAttribute("id", "2"),
                new XAttribute("password", "12356fnfiiv"),
                new XAttribute("Age", "39")),
                new XElement("ArticleTitle", "XML"),
                new XElement("Content", "什么是XML（EXtensible Markup Language"),
                new XElement("Comment", "写的真好!"),
                new XElement("PublishTime", "2019年10月2日")),
                new XElement("User",
                new XElement("name", "于维谦",
                new XAttribute("id", "5"),
                new XAttribute("password", "2efer42tyf79"),
                new XAttribute("Age", "21")),
                new XElement("ArticleTitle", "C#"),
                new XElement("Content", "什么是C#?"),
                new XElement("Comment", "写的不好!"),
                new XElement("PublishTime", "2020年1月1日"),
                new XElement("User",
                new XElement("name", "曾俊清"),
                new XElement("id", "3"),
                new XElement("Age", "23"),
                new XElement("password", "1grf32fg2rg"),
                new XElement("ArcticleTitle", "JavaScript"),
                new XElement("Content", "什么是JavaScript?"),
                new XElement("Comment", "很赞!"),
                new XElement("PublishTime", "2019年12月24日")
                )));
            return Users;

        }
        private static void Save()
        {
            //再从磁盘中读取到内存中。  
            XElement element = XElement.Load(@"F:\17bang\articles.xml");
            Console.WriteLine(element.Element("article").FirstNode);

            Console.WriteLine(UsersOperation());
            XDocument document = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),   //添加一个XML声明
              UsersOperation());
            document.Save("F:\\17bang\\Users.xml");
        }
        private static void SeekArticle()
        {
            //根据用户名查找他发布的全部文章
            var Author = from u in UsersOperation().Descendants("User")
                         where u.Element("name").Value == "大飞哥"
                         select u;
            foreach (var item in Author)
            {
                Console.WriteLine(item.Element("ArticleTitle"));
            }
        }
        private static void PunlshArticle()
        {
            //统计出每个用户各发表了多少篇文章
            var users = UsersOperation().Descendants("User")
                      .GroupBy(u => u.Element("name").Value)
                      .Select(us => new
                      {
                          Author = us.Key,
                          count = us.Count()
                      });
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Author}:{item.count}");
            }
        }
    }
}
