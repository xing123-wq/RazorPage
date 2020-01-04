using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Repoistory
    {
        //改写之前的对象模型中的Repoistory，使其能够：
        //以XML文件格式存储各种文章、求助和建议
        //并以此为基础，实现他们的增删改查
        //文件存放建议：
        //文件User.xml存放所有用户信息
        //文件夹\Article、\Problem和\Suggest下分文件存放文章及评论信息，文件名可使用不重复的Id，如：540.xml
        //还可以考虑使用索引表（注意要用代码生成）以方便快速查询，如AuthorArticle.xml表存放作者Id和文章Id之间的对应关系……
        internal const int VERSION = 1;
        static readonly string Connection;
        public static void Do()
        {
            Save();
        }
        private static XElement GetRepoistory()
        {
            XElement Article = new XElement(
             "articles",
             new XComment("以下存放所有“源栈”所有文章"),
             new XElement("article",
                 new XAttribute("isDraft", false),
                 new XElement("authorName", "飞哥"),
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
                         new XElement("authorName", "陈百万"),
                         new XAttribute("recommend", true)),
                     new XElement("comment",
                         new XElement("id", "14"),
                         new XElement("body", "作业太难了"),
                         new XElement("authorId", "3"),
                         new XElement("authorName", "阿泰")))),
             new XElement("article",
                 new XElement("id", "2"),
                 new XElement("authorName", "飞哥"),
                 new XElement("title", "源栈培训：C#进阶-6：异步和并行"),
                 new XElement("authorId", 1),
                 new XElement("publishDate", "2019/6/15 18:15"),
                 new XElement("comments",
                     new XElement("comment",
                         new XElement("id", "12"),
                         new XElement("body", "不错，赞！"),
                         new XElement("authorId", "2"),
                         new XElement("authorName", "陈百万"),
                         new XAttribute("recommend", true))),
                 new XAttribute("isDraft", true)),
             new XElement("article",
                 new XElement("id", "2"),
                 new XElement("authorName", "陈百万"),
                 new XElement("title", "源栈培训：C#"),
                 new XElement("authorId", 2),
                 new XElement("publishDate", "2019/5/18 18:15"),
                 new XElement("comments",
                     new XElement("comment",
                         new XElement("id", "12"),
                         new XElement("body", "不错，赞！"),
                         new XElement("authorId", "2"),
                         new XElement("authorName", "阿泰"),
                         new XAttribute("recommend", true))),
                 new XAttribute("isDraft", true)),
             new XElement("article",
                 new XElement("id", "2"),
                 new XElement("authorName", "陈百万"),
                 new XElement("title", "源栈培训：sql"),
                 new XElement("authorId", 2),
                 new XElement("publishDate", "2019/5/18 18:15"),
                 new XAttribute("isDraft", true))
             );
            return Article;
        }
        private static void Save()
        {
            Console.WriteLine(GetRepoistory());
            XDocument document = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),   //添加一个XML声明
              GetRepoistory());
            document.Save(@"F:\\17bang\\RepoistoryArticle.xml");
        }

    }

}
