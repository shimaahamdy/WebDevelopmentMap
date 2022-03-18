using HotelManagemet.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Context
{
    public class MyFrontTEndReservation : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlServer("Data Source =.;Initial Catalog=MyFrontTEndReservation; Integrated Security =true;");

        public virtual DbSet<Reservation> Reservations { get; set; }


        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.CardCvc).IsFixedLength();

                entity.Property(e => e.CardType).IsFixedLength();

                entity.Property(e => e.PaymentType).IsFixedLength();

                entity.Property(e => e.RoomFloor).IsFixedLength();

                entity.Property(e => e.RoomNumber).IsFixedLength();

                entity.Property(e => e.RoomType).IsFixedLength();

                entity.Property(e => e.ZipCode).IsFixedLength();
            });

            base.OnModelCreating(modelBuilder);
        }

        
    }
}
