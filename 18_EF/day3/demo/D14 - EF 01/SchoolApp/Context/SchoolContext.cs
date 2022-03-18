using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class SchoolContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=.\MSSQL2019;Initial Catalog=SchoolDB;Integrated Security = true; TrustServerCertificate=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

    }
}
