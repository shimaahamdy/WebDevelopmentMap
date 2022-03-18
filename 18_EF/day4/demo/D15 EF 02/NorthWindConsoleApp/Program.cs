using Microsoft.EntityFrameworkCore;
using NorthWindConsoleApp.Context;

using (NorthwindContext Context = new())
{
    #region Find , Local
    //var Results = Context.Products.Take(10).ToList();
    /////Take first 10 Products , load them in Local


    //var Prd = Context.Products.First(P => P.UnitPrice > 100);
    /////local (10 + 1 )

    ////Console.WriteLine(Context.Products.Count()); //DB

    ////Console.WriteLine(Context.Products.Local.Count()); //Offline

    //////Console.WriteLine(Context.Products.Any(P => P.UnitsInStock ==0)); //DB

    ////if (Context.Products.Local.Any(P => P.UnitsInStock == 0)) //Offline
    ////    Console.WriteLine("True");
    ////else
    ////    Console.WriteLine(Context.Products.Any(P => P.UnitsInStock == 0)); //DB


    //var Prd = Context.Products.Find(7);
    ////check in Local First , return from Local if Object with the same PK exists
    //Console.WriteLine(Prd?.ProductName ?? "NA");

    //Prd = Context.Products.Find(18);
    ////if no match in Local , Check in DB , return object with PK == 18
    //Console.WriteLine(Prd?.ProductName ?? "NA");


    //Prd = Context.Products.Find(180);
    ////return null if no object in local & DB matching PK


    //Console.WriteLine(Prd?.ProductName??"NA"); 
    #endregion

    //var Prds = Context.Products.FromSqlRaw("Select * From Products" );

    //int n = 0;

    //var Prds = Context.Products.FromSqlInterpolated($" Select * from Products where UnitsInStock = {n}");

    ///Entites returned from FromSqlRaw & FromSqlInterpolated Tracked Entities

    //var Prds = Context.Products.FromSqlRaw("Exec DiscontinuedProducts");


    //var Prds = Context.Products.FromSqlRaw("Select * From Products")
    //    .OrderBy(P => P.UnitPrice)
    //    .Take(2)
    //    .ToList();


    //foreach (var item in Prds)
    //{
    //    Console.WriteLine(item.ProductName);
    //}

    //Prds[0].Discontinued = false;

    //Context.SaveChanges();

    //Context.Database.ExecuteSqlRaw(); //non Select Query

    ///return Non Tracked Entities , Read Only
    //var Result = Context.Products.AsNoTracking().Where(P => P.UnitPrice > 20);




}