using Microsoft.EntityFrameworkCore;
using Project_66bit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_66bit.Contexts
{
    public class ExpenseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        public ExpenseContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=auths;Username=admin;Password=756E6be3");
        }
    }
}
