using EFConsoleApp01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp01
{
    internal class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> Builder)
        {
            Builder.Ignore(P => P.Created); //[Not Mapped]
            Builder.HasKey(P => P.PID);// [Key]

            Builder.Property(P => P.FName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(true);

            Builder.Property(P => P.LName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(true);

            Builder.Property(P => P.Age)
                .IsRequired();

            Builder.Property(P => P.Amount)
                .HasColumnType("money")
                .HasDefaultValue(1000);
        }
    }
}
