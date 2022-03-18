using Dapper;
using LoginManger.Entites;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginManger.Dapper
{
    public class LogManger
    {
        IDbConnection dBConnection = new SqlConnection("Data Source=.; Initial Catalog=MyLoginManger;Integrated Security = true");

        public List<Frontend> GetAllFrontend()
            => dBConnection.Query<Frontend>("Select * from Frontends")?.AsList() ?? new();

        public Frontend GetFrontendByID(int id)
            => dBConnection.QueryFirstOrDefault<Frontend>("Select * from Frontends where Id = @resID",
                new { resID = id });

        public List<Kitchen> GetAllKitchens()
          => dBConnection.Query<Kitchen>("Select * from Kitchens")?.AsList() ?? new();

       
    }
}
