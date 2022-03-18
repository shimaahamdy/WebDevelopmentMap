using NorthWindConsole;
using Microsoft.EntityFrameworkCore;
using NorthWindConsole.Context;
using BenchmarkDotNet;
using BenchmarkDotNet.Running;

using NorthwindContext Context = new();

#region Stored Procedures
//var Proc = new NorthwindContextProcedures(Context);

//// var SPTask = Proc.CustOrderHistAsync("ALFKI");

////Console.WriteLine("Main Work");

////List<CustOrderHistResult> Lst = SPTask.Result;


////List<CustOrderHistResult> Lst = await Proc.CustOrderHistAsync("ALFKI");

////foreach (var item in Lst)
////{
////    Console.WriteLine(item);
////}

////var oParam = new OutputParameter<int>();

//await Proc.UpdateProductNameByProductIDAsync(1, "Test Update" /*, oParam*/);

////Console.WriteLine(oParam.Value);


//Console.WriteLine(Context.Products.FirstOrDefault()?.ProductName??"NA"); 
#endregion

#region Lazy Loading

//var Results = (from P in Context.Products
//               //.Include(p => p.Category)
//              where P.UnitsInStock ==0
//               //select new {P.ProductName , P.Category.CategoryName}
//               select P
//              ).ToList();

//ProductEngine.PrintProducts(Results , Context);

#endregion

var Summary = BenchmarkRunner.Run<DappervsEF>();


class ProductEngine
{
    public static void PrintProducts(List<Product> Results ,NorthwindContext context)
    {
       
        foreach (var item in Results)
        {
            //Console.WriteLine(item.ProductName);
            //Console.WriteLine(item);
            //Console.WriteLine($"{item.ProductName} {item.Category.CategoryName}");//unsafe
            
            ///explicit Loading Manually
            //if (item.Category == null)
            //    context.Entry(item).Reference(P => P.Category).Load(); //Extra Trip to DB
            //    //context.Entry(Cat).Collection(C => C.Products).Load();

            ///To Enable Explicit Loading Automatically
            ///EF 6.4 Lazy Loading Style
            ///Install Package Microsoft.EntityFrameworkcore.Proxies
            ///on Context class
            ///optionBuilder.useLazyLoadingProxies(true);

            Console.WriteLine($"{item.ProductName} {item.Category?.CategoryName ?? "NA"}");//unsafe

        }
    }
}