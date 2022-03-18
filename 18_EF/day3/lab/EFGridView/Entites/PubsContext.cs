﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFGridView.Entites;

namespace EFGridView.Context
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
        {
        }

        public PubsContext(DbContextOptions<PubsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Title> Titles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=pubs;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PubId)
                    .HasName("UPKCL_pubind");

                entity.Property(e => e.PubId).IsFixedLength();

                entity.Property(e => e.Country).HasDefaultValueSql("('USA')");

                entity.Property(e => e.State).IsFixedLength();
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.PubId).IsFixedLength();

                entity.Property(e => e.Pubdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasDefaultValueSql("('UNDECIDED')")
                    .IsFixedLength();

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.Titles)
                    .HasForeignKey(d => d.PubId)
                    .HasConstraintName("FK__titles__pub_id__1A14E395");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}