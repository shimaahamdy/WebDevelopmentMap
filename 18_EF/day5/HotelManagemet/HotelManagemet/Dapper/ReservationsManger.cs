using Dapper;
using HotelManagemet.Entites;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagemet.Dapper
{
    public class ReservationsManger
    {
        IDbConnection dBConnection = new SqlConnection("Data Source=.; Initial Catalog=MyFrontTEndReservation;Integrated Security = true");

        public List<Reservation> GetAll()
            => dBConnection.Query<Reservation>("Select * from Reservations")?.AsList() ?? new();

        public Reservation GetByID(int id)
            => dBConnection.QueryFirstOrDefault<Reservation>("Select * from Reservations where Id = @resID",
                new { resID = id });

    }
}
