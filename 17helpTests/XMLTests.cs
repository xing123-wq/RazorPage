using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;
using System.Xml.Linq;
using System.Linq;

namespace ConsoleApp3.Tests
{
    [TestClass()]
    public class XMLTests
    {
        [TestMethod()]
        public static XElement UsersOperation()
        {
            //参照上述articles，代码生成一个XML的users对象，
            //能够存放用户的id、name和password，然后并存放到磁盘
            //扩展user和articles的内容，使其能够完成以下操作：
            XElement Users = new XElement(
                "Users",
                new XElement("User",
                new XElement("Article",
                new XElement("name", "大飞哥",
                new XAttribute("id", "2"),
                new XAttribute("password", "12356fnfiiv"),
                new XAttribute("Age", "39")),
                new XElement("Title", "XML"),
                new XElement("Content", "什么是XML（EXtensible Markup Language"),
                new XElement("Comment", "写的真好!"),
                new XElement("PublishTime", "2019/10/2  12:16"))),
                new XElement("User",
                new XElement("Article",
                new XElement("name", "于维谦",
                new XAttribute("id", "5"),
                new XAttribute("password", "2efer42tyf79"),
                new XAttribute("Age", "21")),
                new XElement("Title", "C#"),
                new XElement("Content", "什么是C#?"),
                new XElement("Comment", "写的不好!"),
                new XElement("PublishTime", "2020/1/1  00:00"))),
                new XElement("User",
                new XElement("Arcticle",
                new XElement("name", "曾俊清",
                new XAttribute("id", "3"),
                new XAttribute("Age", "23"),
                new XAttribute("password", "1grf32fg2rg")),
                new XElement("Title", "JavaScript"),
                new XElement("Content", "什么是JavaScript?"),
                new XElement("Comment", "很赞!"),
                new XElement("Comment", "极好!"),
                new XElement("PublishTime", "2019/12/24  16:21"))),
                new XElement("User",
                new XElement("Article",
                new XElement("name", "大飞哥",
                new XAttribute("id", "4"),
                new XAttribute("password", "ribfweiqoq21"),
                new XAttribute("Age", "39")),
                new XElement("Title", ".NET"),
                new XElement("Content", "什么是.NET?"),
                new XElement("Comment", "写的很Very Good! "),
                new XElement("PublishTime", "2019/12/31  18:22")
                )), new XElement("User",
                new XElement("name", "侯涛",
                new XAttribute("id", "8"),
                new XAttribute("Age", "56"),
                new XAttribute("password", "78gtr0qfroh")
                )));
            return Users;
        }

        [TestMethod()]
        public void LatelyPublishTest()
        {
            //Assert.Fail();
            var article = UsersOperation().Descendants("Article")
                    .GroupBy(u => u.Element("name").Value)
                    .Select(u => u.OrderByDescending(p => p.Element("PublishTime").Value).First());
            foreach (var item in article)
            {
                Console.WriteLine(item.Element("Title"));
            }
        }

        [TestMethod()]
        public void PunlshArticleTest()
        {
            //Assert.Fail();
            //统计出每个用户各发表了多少篇文章
            var users = UsersOperation().Descendants("Article")
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

        [TestMethod()]
        public void SeekArticleTest()
        {
            //根据用户名查找他发布的全部文章
            var Author = from u in UsersOperation().Descendants("Article")
                         where u.Element("name").Value == "大飞哥"
                         select u;
            foreach (var item in Author)
            {
                Console.WriteLine(item.Element("Title"));
            }
        }
    }
}