using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _17bnag.Entitys;
using System.Diagnostics.CodeAnalysis;

namespace _17bnag.Data
{
    public class _17bnagContext : DbContext
    {
        public _17bnagContext(DbContextOptions<_17bnagContext> options)
            : base(options)
        {
           
        }
        public DbSet<_17bnag.Entitys.HelpRelease> HelpRelease { get; set; }

        public DbSet<_17bnag.Entitys.PublishArticle> PublishArticles { get; set; }
        public DbSet<_17bnag.Entitys.Keyword> Keywords { get; set; }
        public DbSet<_17bnag.Entitys.User> Users { get; set; }

    }
}
