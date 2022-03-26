using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8Demo_Mobile.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
