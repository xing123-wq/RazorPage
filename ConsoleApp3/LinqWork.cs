using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3
{
    public static class LinqWork
    {
        //在之前“文章/评价/评论/用户/关键字”对象模型的基础上，
        //添加相应的数据，然后完成以下操作：
        //找出“飞哥”发布的文章
        //找出2019年1月1日以后“小鱼”发布的文章
        //按发布时间升序/降序排列显示文章
        //统计每个用户各发布了多少篇文章
        //找出包含关键字“C#”或“.NET”的文章
        //找出评论数量最多的文章
        static readonly User fg, xy;
        static keyword sql, csharp, net, java, js, html;
        static readonly Article SQL, JAVA, UI, CSharp;
        static readonly Comment wx, atai, pzq, cbw, ljp;
        static LinqWork()
        {
            fg = new User() { Name = "飞哥" };
            xy = new User() { Name = "小余" };

            sql = new keyword() { Content = "SQL" };
            csharp = new keyword() { Content = "C#" };
            net = new keyword() { Content = ".NET" };
            java = new keyword() { Content = "JAVA" };
            js = new keyword() { Content = "JavaScript" };
            html = new keyword() { Content = "HTML" };

            SQL = new Article("文章")
            {
                Author = fg,
                Title = "SQL",
                keywords = new List<keyword> { sql }
            };
            JAVA = new Article("文章")
            {
                Author = fg,
                Title = "JAVA",
                keywords = new List<keyword> { java, html }
            };
            UI = new Article("文章")
            {
                Author = xy,
                Title = "UI",
                keywords = new List<keyword> { js, html, net }
            };
            CSharp = new Article("文章")
            {
                Author = xy,
                Title = "CSharp",
                keywords = new List<keyword> { csharp }
            };

            wx = new Comment(JAVA)
            {
                Body = "写的不行",
                Author = new User { Name = "王欣" }
            };
            atai = new Comment(SQL)
            {
                Body = "写的很好",
                Author = new User { Name = "阿泰" }
            };
            pzq = new Comment(UI)
            {
                Body = "还可以",
                Author = new User { Name = "彭志强" }
            };
            cbw = new Comment(CSharp)
            {
                Body = "一般般",
                Author = new User { Name = "陈百万" }
            };
            ljp = new Comment(CSharp)
            {
                Body = "看得下去",
                Author = new User { Name = "刘江平" }
            };
            SQL.Comments = new List<Comment> { atai };
            JAVA.Comments = new List<Comment> { wx };
            UI.Comments = new List<Comment> { pzq };
            CSharp.Comments = new List<Comment> { cbw, ljp };
            sql.Articles = new List<Article> { SQL };
            csharp.Articles = new List<Article> { CSharp };
            net.Articles = new List<Article> { UI };
            java.Articles = new List<Article> { JAVA };
            js.Articles = new List<Article> { UI };
            html.Articles = new List<Article> { JAVA, UI };
            articles = new List<Article> { SQL, JAVA, UI, CSharp };
            //ContentService.Publish(UI);
            //ContentService.Publish(CSharp);
            //ContentService.Publish(SQL);
            //ContentService.Publish(JAVA);
        }
        private static IEnumerable<Article> articles;
        public static void PublishArticleFg()
        {
            Console.WriteLine("找出飞哥发布的文章:");
            var fgArticle = from a in articles
                            where a.Author.Name == "飞哥"
                            select a;
            foreach (var item in fgArticle)
            {
                Console.WriteLine(item.Title);
            }
        }
        public static void PublishArticleXy()
        {
            Console.WriteLine("找出小余发布的文章:");
            var xyArtricle = from a in articles
                             where/* a.PublishTime > Convert.ToDateTime("2019年1月1日") &&*/ a.Author.Name == "小余"
                             select a;
            foreach (var item in xyArtricle)
            {
                Console.WriteLine(item.Title);
            }
        }

        public static void ArticleTime()
        {
            Console.WriteLine("按照时间升序降序显示文章:");
            var deta = from a in articles
                       orderby a.PublishTime ascending
                       select a;
            var Time = from a in articles
                       orderby a.PublishTime descending
                       select a;
            foreach (var item in deta)
            {
                Console.WriteLine(item.Title);
            }
            foreach (var item in Time)
            {
                Console.WriteLine(item.Title);
            }
        }
        public static void UserArticle()
        {
            Console.WriteLine("");
            var authorArticle = from a in articles
                                group a by a.Author into gm
                                select new
                                {
                                    Author = gm.Key,
                                    count = gm.Count()
                                };
            foreach (var item in authorArticle)
            {
                Console.WriteLine(item.Author + ":" + item.count);
            }
        }
    }
}
