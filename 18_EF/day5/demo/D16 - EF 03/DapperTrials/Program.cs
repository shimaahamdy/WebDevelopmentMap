using Dapper;
using System.Data;
using System.Data.SqlClient;
using DapperTrials;

//IDbConnection CN = new SqlConnection("Data Source=.\\MSSQL2019 ; Initial Catalog=Northwind;Integrated Security = true");

//var PrdLSt = CN.Query<Product>("Select * from Products").ToList();

//foreach (var item in PrdLSt)
//{
//    Console.WriteLine(item.ProductName);
//}


//var Prd = CN.QuerySingle<Product>("Select * From PRoducts where productID=1");

//Console.WriteLine(Prd.ProductName);


ProductManager Manager = new();

//var PrdLst = Manager.GetAll();

//foreach (var item in PrdLst)
//{
//    Console.WriteLine(item.ProductName);
//}

var PRd = Manager.GetByID(1);

Console.WriteLine(PRd.ProductName);

PRd.ProductName = "Changed By Dapper";

Manager.Update(PRd);



