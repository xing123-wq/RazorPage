using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class ProblemRepoistory
    {
        public IList<Problem> Get()
        {
            User pk = new User { Id = 1, Name = "彭昆" };
            User at = new User { Id = 2, Name = "阿泰" };
            User cy = new User { Id = 3, Name = "陈元" };
            Keyword sql = new Keyword { Id = 1, Name = "SQL" };
            Keyword java = new Keyword { Id = 2, Name = "JAVA" };
            Keyword CSharp = new Keyword { Id = 3, Name = "C#" };
            Keyword javascript = new Keyword { Id = 4, Name = "JavaScript" };
            Keyword html5 = new Keyword { Id = 5, Name = "HTML5" };
            Keyword css = new Keyword { Id = 6, Name = "CSS" };
            Keyword linq = new Keyword { Id = 7, Name = "Linq" };
            Keyword ajax = new Keyword { Id = 8, Name = "AJAX" };
            //模拟从数据库取数据
            return new List<Problem>
            {
              new Problem
             {
                PublishDateTime = new DateTime(2020, 2, 1),
                Author = pk,
                Body = "",
                Title = "",
                Keywords = new List<Keyword>
                {
                   sql,java,CSharp
                },

             },
              new Problem
             {
                PublishDateTime = new DateTime(2019, 10, 7),
                Author = at,
                Body = "",
                Title = "",
                Keywords = new List<Keyword>
                {
                   linq,css,ajax
                },

             },
              new Problem
             {
                PublishDateTime = new DateTime(2020, 1, 21),
                Author = cy,
                Body = "",
                Title = "",
                Keywords = new List<Keyword>
                {
                    html5,javascript,sql
                },

             }
            };
        }
    }
}
