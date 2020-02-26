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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Map>()
               .HasKey(bk => new { bk.helperId, bk.KeywordId });  //唯一可以（推荐）使用联合主键的情景

            modelBuilder.Entity<Map>()
                .HasOne(bk => bk.Help)
                .WithMany(b => b.KeyWord)
                .HasForeignKey(b => b.helperId)
                ;

            modelBuilder.Entity<Map>()
                .HasOne(bk => bk.Keyword)
                .WithMany(b => b.helps)
                .HasForeignKey(b => b.KeywordId)
                ;
        }
        public DbSet<_17bnag.Entitys.HelpRelease> HelpRelease { get; set; }
        public DbSet<_17bnag.Entitys.PublishArticle> PublishArticles { get; set; }
        public DbSet<_17bnag.Entitys.Keyword> Keywords { get; set; }
        public DbSet<_17bnag.Entitys.User> Users { get; set; }
    }
}
