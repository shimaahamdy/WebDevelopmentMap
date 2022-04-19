using Microsoft.EntityFrameworkCore;

namespace Task2.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
