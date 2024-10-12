using Microsoft.EntityFrameworkCore;
using DiaryProject.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace DiaryProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntries> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntries>().HasData(
                new DiaryEntries
                {
                    Id = 1,
                    Title = "Went snowboarding", Date = DateTime.Now,
                    Entry = "I went snowboarding today and it was awesome!"
                },
                new DiaryEntries
                {
                    Id = 2,
                    Title = "Went to the beach",
                    Date = DateTime.Now,
                    Entry = "I went to the beach today and it was awesome!"
                },
                new DiaryEntries
                {
                    Id = 3,
                    Title = "Went to the movies",
                    Date = DateTime.Now,
                    Entry = "I went to the movies today and it was awesome!"
                }
                );
        }
    }
}
