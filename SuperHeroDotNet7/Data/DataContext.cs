global using Microsoft.EntityFrameworkCore;
using SuperHeroDotNet7.Models;

namespace SuperHeroDotNet7.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=superherodb1;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
