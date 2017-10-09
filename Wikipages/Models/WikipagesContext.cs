using Microsoft.EntityFrameworkCore;

namespace Wikipages.Models
{
    public class WikipagesContext : DbContext
    {
        public DbSet<Business> Business { get; set; }
        public DbSet<BusinessType> BusinessType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=3306;database=wikipages;uid=root;pwd=root;");
    }
}