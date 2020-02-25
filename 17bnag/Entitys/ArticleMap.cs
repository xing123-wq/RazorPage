using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _17bnag.Entitys
{
    public class ArticleMap
    {
        [Key]
        public int PublishId { get; set; }
        public PublishArticle  PublishArticle { get; set; }
        public int ArticleKeywordId { get; set; }
        public ArticleKeyword Keyword { get; set; }
    }
}
