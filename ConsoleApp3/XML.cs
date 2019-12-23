using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class XML
    {
        public  void operation()
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

            //再从磁盘中读取到内存中。  
            //XElement element = XElement.Load(@"F:\17bang\articles.xml");
            //Console.WriteLine(element.Element("article").FirstNode);

            //在根节点下添加一个新的article元素，内容至少包含id、title和authorId
            //articles.Add(new XElement("article",
            //         new XElement("id", 1),
            //         new XElement("title", "net"),
            //         new XElement("authorId", "2")));
            //articles.Save(@"F:\article.xml");
            //Console.WriteLine(articles);
            //删除id = 12的评论
            //改变id = 2的article：isDraft = false，title = 源栈培训：C#进阶-8：异步和并行

            var teachers = (from x in articles.Descendants("comment")
                           where x.Element("id").Value == "12"
                           select x).Single();
            teachers.Remove();
            articles.Save(@"F:\17bang\articles.xml");
            Console.WriteLine(articles);

            //然后，将其以文件形式存放到磁盘中；
            //Console.WriteLine(articles);
            //XDocument document = new XDocument(
            //   new XDeclaration("1.0", "utf-8", "yes"),   //添加一个XML声明
            //   articles);
            //document.Save("F:\\17bang\\articles.xml");
        }
    }
}
