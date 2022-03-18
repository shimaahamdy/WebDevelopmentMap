using LoginManger.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginManger.Context
{
    internal class MyLoginManger: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseSqlServer("Data Source =.;Initial Catalog=MyLoginManger; Integrated Security =true;");

        public virtual DbSet<Frontend> Frontends { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
     

    }
}
