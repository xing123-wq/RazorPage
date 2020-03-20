using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _17bnag.Entitys;

namespace _17bnag.Data
{
    public class _17bnagContext : DbContext
    {
        public _17bnagContext(DbContextOptions<_17bnagContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<HelpRelease> HelpRelease { get; set; }
        public DbSet<PublishArticle> PublishArticles { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HelpRelease>().ToTable("HelpRelease");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Keyword>().ToTable("Keywords");

            modelBuilder.Entity<PublishArticle>().ToTable("PublishArticles");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Keyword>().ToTable("Keywords");
        }

    }
}
