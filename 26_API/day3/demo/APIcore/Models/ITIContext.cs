using Microsoft.EntityFrameworkCore;
namespace APIcore.Models
{
    public class ITIContext:DbContext
    {
        public ITIContext(DbContextOptions option):base(option)
        {
                
        }
        public virtual DbSet<student> Students { get; set; }
        public virtual DbSet<department> Departments { get; set; }
    }
}
