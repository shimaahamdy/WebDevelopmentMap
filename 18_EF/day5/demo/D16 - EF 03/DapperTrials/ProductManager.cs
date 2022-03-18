using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTrials
{
    public class ProductManager : IManager<Product>
    {
        IDbConnection dBConnection = new SqlConnection("Data Source=.\\MSSQL2019 ; Initial Catalog=Northwind;Integrated Security = true");

        public bool Add(Product item)
        {
            try
            {
                return 
                dBConnection.Execute("INSERT INTO Products ([ProductName], [SupplierID], [CategoryID], [QuantityPerUnit], " +
                "[UnitPrice], [UnitsInStock], [UnitsOnOrder], [ReorderLevel], [Discontinued]) VALUES " +
                "(@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock," +
                " @UnitsOnOrder, @ReorderLevel, @Discontinued)", item)
                >0;
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int ID)
            => dBConnection.Execute("DeleteProductByID", new { ProductID = ID },
                commandType: CommandType.StoredProcedure) > 0;

        public List<Product> GetAll()
            => dBConnection.Query<Product>("Select * from Products")?.AsList()?? new ();

        public Product GetByID(int id)
            => dBConnection.QueryFirstOrDefault<Product>("Select * from Products where ProductID = @ProductID",
                new { ProductID = id });

        public bool Update(Product item)
            => dBConnection.Execute("[PrdsUpdateCommand]", item, commandType: CommandType.StoredProcedure) > 0;
        //=> dBConnection.Execute("[NewProductUpdateCommand]", 
        //    new {
        //        ProducID = item.ProductId ,
        //        Original_ProductID = item.ProductId
        //    }, 
        //    commandType: CommandType.StoredProcedure) > 0;

    }
}
