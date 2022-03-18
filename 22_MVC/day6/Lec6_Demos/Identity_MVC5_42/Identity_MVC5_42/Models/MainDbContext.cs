using System.Data.Entity;

namespace Identity_MVC5_42.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base("myConn")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}