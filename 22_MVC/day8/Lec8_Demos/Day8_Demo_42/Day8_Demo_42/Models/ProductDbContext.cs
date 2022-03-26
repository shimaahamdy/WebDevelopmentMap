using Microsoft.EntityFrameworkCore;

namespace Day8_Demo_42.Models
{
    public class ProductDbContext : DbContext
    {
        //request  service of type "DbContextOptions"

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
