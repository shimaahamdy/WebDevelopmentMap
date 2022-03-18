using EFConsoleApp01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatusGeneric;

namespace EFConsoleApp01.Context
{
    public class HospitalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source = .\\MSSQL2019;Initial Catalog=HospitalDB; Integrated Security =true;");
    
    
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Patient> Patients { get; set; }

        ///Mapping 
        ///1. EF Convemsions : Default 
        ///2. Data Annotation 
        ///3. Fluent API : OnModelCreating
        ///4. Configuration class : Refactor each entity Fluent API into Separate class


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region EF6.4 Style for Fluent API

            //modelBuilder.Entity<Department>().HasData(new Department() { DeptName = "ICU"  , ID = -1});

            //modelBuilder.Entity<Patient>()
            //    .Ignore(P => P.Created) //[Not Mapped]
            //    .HasKey(P => P.PID);// [Key]

            //modelBuilder.Entity<Patient>().Property(P => P.FName)
            //    .IsRequired()
            //    .HasMaxLength(50)
            //    .IsUnicode(true);

            //modelBuilder.Entity<Patient>().Property(P => P.LName)
            //    .IsRequired()
            //    .HasMaxLength(50)
            //    .IsUnicode(true);

            //modelBuilder.Entity<Patient>().Property(P => P.Age)
            //    .IsRequired();

            //modelBuilder.Entity<Patient>().Property(P => P.Amount)
            //    .HasColumnType("money")
            //    .HasDefaultValue(1000);
            #endregion

            #region Fluent API Style in EF Core

            //modelBuilder.Entity<Patient>(Builder =>
            //{
            //    Builder.Ignore(P => P.Created); //[Not Mapped]
            //    Builder.HasKey(P => P.PID);// [Key]

            //    Builder.Property(P => P.FName)
            //        .IsRequired()
            //        .HasMaxLength(50)
            //        .IsUnicode(true);

            //    Builder.Property(P => P.LName)
            //        .IsRequired()
            //        .HasMaxLength(50)
            //        .IsUnicode(true);

            //    Builder.Property(P => P.Age)
            //        .IsRequired();

            //    Builder.Property(P => P.Amount)
            //        .HasColumnType("money")
            //        .HasDefaultValue(1000);
            //});

            #endregion

            //4. Configuration Class
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            ///use Separate Configuration class per Each and every Entity

            modelBuilder.Entity<PatientClienc>()
                .HasKey(V => new { V.PatientPID, V.CliencID });


            base.OnModelCreating(modelBuilder);
        }


        #region Enforce Validation on Model Before Save Changes
        //public override int SaveChanges()
        //{
        //    //Enforce EF 6.4 Validation Style 
        //    //Validate before Connection to DB
        //    //Overhead Cost , used only if there are no validation in UI
        //    //var Entries = from e in ChangeTracker.Entries()
        //    //               where e.State == EntityState.Modified || e.State == EntityState.Added
        //    //               select e;

        //    //foreach (var Entry in Entries)
        //    //{
        //    //    var ValidatorContext = new ValidationContext(Entry.Entity);
        //    //    Validator.ValidateObject(Entry.Entity, ValidatorContext, true);
        //    //}

        //    ///another Solution
        //    var Entries = from e in ChangeTracker.Entries()
        //                   where e.State == EntityState.Modified || e.State == EntityState.Added
        //                   select e;

        //    var Status = new StatusGenericHandler();

        //    foreach (var Entry in Entries)
        //    {
        //        if (Entry.Entity is Doctor D)
        //        {
        //            if ((D.Age < 20) || (D.Age > 70))
        //                Status.AddError("Age must be in Range of 20 , 70" , nameof(D.Age));
        //            ///Validate All Properties Manually
        //        }
        //    }


        //    //Only SaveChanges is there are no Errors
        //    if (!Status.IsValid) return -1;

        //    return base.SaveChanges();
        //}
        #endregion


    }
}
