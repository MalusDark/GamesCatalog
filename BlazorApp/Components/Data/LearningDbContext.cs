using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Components.Data
{
    public class LearningDbContext : DbContext
    {

        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<LessonEntity> Lessons { get; set; }

        public LearningDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=artika197007;database=usersdb5;",
                new MySqlServerVersion(new Version(8, 0, 2))
            );
        }
    }
}
