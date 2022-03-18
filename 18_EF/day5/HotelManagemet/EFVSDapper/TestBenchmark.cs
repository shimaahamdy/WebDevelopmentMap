using BenchmarkDotNet.Attributes;
using HotelManagement.Context;
using HotelManagemet.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFVSDapper
{
    public class TestBenchmark
    {
        ReservationsManger manger = new ReservationsManger();

        MyFrontTEndReservation context = new MyFrontTEndReservation();

       

        [Benchmark]
        public void DapperFun()
        {
            var PrdLst = manger.GetAll();
        }

        [Benchmark]
        public void EFFun()
        {
            var PRdLst = (from R in context.Reservations
                          select R).ToList();
        }
    }
}
