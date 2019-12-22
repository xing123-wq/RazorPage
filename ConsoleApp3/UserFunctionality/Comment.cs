using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Comment : IAppraise
    {
        public string Body { get; internal set; }
        public Article Article { get; }
        public User Author { get; internal set; }

        public Comment(Article article)//记录文章
        {
            this.Article = article;
        }
        public void Agree(User voter)
        {
            voter.HelpMony += 1;
        }

        public void Disagree(User voter)
        {
            voter.HelpMony -= 1;
        }
    }
}
