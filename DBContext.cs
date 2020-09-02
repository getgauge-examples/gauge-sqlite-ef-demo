using Microsoft.EntityFrameworkCore;

namespace netcore.template
{
    class NorthWindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=./data/northwind_small.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
