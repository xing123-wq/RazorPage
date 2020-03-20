using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _17bnag.Entitys
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<HelpRelease> HelpReleases { get; set; }
        public ICollection<PublishArticle> PublishArticles { get; set; }
    }
}