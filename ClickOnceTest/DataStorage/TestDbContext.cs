using ClickOnceTest.DataStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace ClickOnceTest.DataStorage
{
    public class TestDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename=Test.db");
        }
    }
}
