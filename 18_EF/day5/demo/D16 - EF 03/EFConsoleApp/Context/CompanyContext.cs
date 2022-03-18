using EFConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Context
{
    public class CompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=.\MSSQL2019;Initial Catalog=CompanyDB;Integrated Security=true;");

        //public virtual DbSet<Teacher> Teachers { get; set; }
        //public virtual DbSet<Student>  Students { get; set; }
        ///One DBSet Per Hirarchy 
        public virtual DbSet<Person> People { get; set; }

        public virtual DbSet<Branch> Branches { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Order>()
                .Property(O => O.Price)
                .HasConversion(V => V.Amount, V => new Dollars(V));


            modelBuilder.Entity<Branch>()
                .OwnsOne(B => B.Address); ///Mapped to Branches Table
            //.ToTable("Detailed Address");


            modelBuilder.Entity<Teacher>()
                .Property(T => T.HireDate)
                .HasConversion(new ValueConverter<DateTime, DateTime>(
                    toDB => toDB,
                    fromDB => DateTime.SpecifyKind(fromDB, DateTimeKind.Utc))
                    );
            

            #region User Defined Enum to String Value Converter
            var Converter = new ValueConverter<BranchStyle, string>
                (
                  toDB => toDB.ToString(),
                  FromDB => (BranchStyle)Enum.Parse(typeof(BranchStyle), FromDB)
                  , new ConverterMappingHints(size: 20, unicode: false)
                );

            modelBuilder.Entity<Branch>()
                .Property(B => B.Style)
                .HasConversion(Converter);
            #endregion

            ///using Built in Value converter
            ///https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions?tabs=data-annotations
            //modelBuilder.Entity<Branch>()
            //    .Property(x => x.Address)
            //    .HasConversion<string>();


            #region Inheritance
            ///DBSet per Derived Class , TPH , Automatcally Generated Discriminator nvarchar(max)
            //modelBuilder.Entity<Student>().HasBaseType<Person>();
            //modelBuilder.Entity<Teacher>().HasBaseType<Person>();


            ///DBSet Per Derived Class , TPH , Use IsEmployee as Discriminator Col
            //modelBuilder.Entity<Person>()
            //    .HasDiscriminator(P => P.IsEmployee)
            //    //.HasDiscriminator<string>("PersonType")
            //    .HasValue<Teacher>(true)
            //    .HasValue<Student>(false);

            ///One DBSet Per Hirarchy 
            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("PType")
                .HasValue<Student>("Student")
                .HasValue<Teacher>("Teacher");

            //DBSet per Derived Class , TPT , Automatcally Generated Discriminator nvarchar(max)
            //modelBuilder.Entity<Student>().HasBaseType<Person>().ToTable("Students");
            //modelBuilder.Entity<Teacher>().HasBaseType<Person>().ToTable("Teachers");

            #endregion

            base.OnModelCreating(modelBuilder);
        }


    }
}
