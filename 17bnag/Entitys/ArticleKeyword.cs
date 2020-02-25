using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17bnag.Entitys
{
    public class ArticleKeyword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<PublishArticle> PublishArticles { get; set; }
    }
}
