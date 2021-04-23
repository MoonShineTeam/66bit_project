using Microsoft.EntityFrameworkCore;
using Project_66bit.Models;

namespace Project_66bit.Contexts
{
    public sealed class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Type> Types { get; set; }

        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=auths;Username=admin;Password=756E6be3");
        }
    }
}