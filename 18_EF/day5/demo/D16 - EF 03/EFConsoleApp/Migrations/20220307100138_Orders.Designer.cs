﻿// <auto-generated />
using System;
using EFConsoleApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFConsoleApp.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20220307100138_Orders")]
    partial class Orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFConsoleApp.Entities.Branch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("EFConsoleApp.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EFConsoleApp.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsEmployee")
                        .HasColumnType("bit");

                    b.Property<string>("PType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("PType").HasValue("Person");
                });

            modelBuilder.Entity("EFConsoleApp.Entities.Student", b =>
                {
                    b.HasBaseType("EFConsoleApp.Entities.Person");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.ToTable("People");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("EFConsoleApp.Entities.Teacher", b =>
                {
                    b.HasBaseType("EFConsoleApp.Entities.Person");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.ToTable("People");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("EFConsoleApp.Entities.Branch", b =>
                {
                    b.OwnsOne("EFConsoleApp.Entities.DetailedAddress", "Address", b1 =>
                        {
                            b1.Property<int>("BranchID")
                                .HasColumnType("int");

                            b1.Property<string>("AddressLine01")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("AddressLine02")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<string>("City")
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.Property<bool>("IsActive")
                                .HasColumnType("bit");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.HasKey("BranchID");

                            b1.ToTable("Branches");

                            b1.WithOwner()
                                .HasForeignKey("BranchID");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
