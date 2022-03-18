using BenchmarkDotNet.Attributes;
using Dapper;
using Microsoft.EntityFrameworkCore;
using NorthWindConsole.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindConsole
{
    public class DappervsEF
    {
        NorthwindContext context = new NorthwindContext();
        IDbConnection DBConnection;

        public DappervsEF()
        {
            DBConnection = context.Database.GetDbConnection();
        }

        [Benchmark]
        public void DapperFun()
        {
            var PrdLst = DBConnection.Query<Product>("Select * from Products").AsList();
        }
        
        [Benchmark]
        public void EFFun()
        {
            var PRdLst = (from P in context.Products
                          select P).ToList();
        }
    }
}
