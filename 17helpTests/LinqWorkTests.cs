using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3.Tests
{
    [TestClass()]
    public class LinqWorkTests
    {
        static readonly User fg, xy;
        static Keyword sql, csharp, net, java, js, html;
        static readonly Article SQL, JAVA, UI, CSharp;
        static readonly Comment wx, atai, pzq, cbw, ljp;
        static LinqWorkTests()
        {
            fg = new User { Name = "飞哥" };
            xy = new User { Name = "小余" };
            sql = new Keyword { Content = "SQL" };
            csharp = new Keyword { Content = "C#" };
            net = new Keyword { Content = ".NET" };
            java = new Keyword { Content = "JAVA" };
            js = new Keyword { Content = "JAVASCRIPT" };
            html = new Keyword { Content = "HTML" };
            SQL = new Article("文章")
            {
                Author = fg,
                Title = "SQL",
                keywords = new List<Keyword> { sql }
            };
            JAVA = new Article("文章")
            {
                Author = fg,
                Title = "JAVA",
                keywords = new List<Keyword> { java, html }
            };
            UI = new Article("文章")
            {
                Author = xy,
                Title = "UI",
                keywords = new List<Keyword> { js, html, net }
            };
            CSharp = new Article("文章")
            {
                Author = xy,
                Title = "CSharp",
                keywords = new List<Keyword> { csharp }
            };
            wx = new Comment(JAVA)
            {
                Body = "写的不行",
                Author = new User
                {
                    Name = "王欣"
                }
            };
            atai = new Comment(SQL)
            {
                Body = "写的很好",
                Author = new User
                {
                    Name = "阿泰"
                }
            };
            pzq = new Comment(UI)
            {
                Body = "还可以",
                Author = new User
                {
                    Name = "彭志强"
                }
            };
            cbw = new Comment(CSharp)
            {
                Body = "一般般",
                Author = new User
                {
                    Name = "陈百万"
                }
            };
            ljp = new Comment(CSharp)
            {
                Body = "看得下去",
                Author = new User
                {
                    Name = "刘江平"
                }
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
        public static IEnumerable<Article> articles;
        [TestMethod()]
        public void PublishArticleFgTest()
        {
            var fgArticle = articles.Where(a => a.Author.Name == "飞哥");
            foreach (var item in fgArticle)
            {
                Console.WriteLine(item.Title);
            }
        }
        [TestMethod()]
        public void PublishArticleXyTest()
        {
            var xyArtricle = articles.Where(a => a.Author == xy && a.PublishTime > new DateTime(2019, 1, 1));

            foreach (var item in xyArtricle)
            {
                Console.WriteLine(item.Title);
            }
        }
        [TestMethod()]
        public void ArticleTimeTest()
        {
            var deta = articles.OrderByDescending(a => a.PublishTime);
            var Time = articles.OrderBy(a => a.PublishTime);
            foreach (var item in deta)
            {
                Console.WriteLine(item.Title);
            }
            foreach (var item in Time)
            {
                Console.WriteLine(item.Title);
            }
        }

    }
}