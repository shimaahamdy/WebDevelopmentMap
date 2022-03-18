using EFConsoleApp;
using EFConsoleApp.Context;
using EFConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

using CompanyContext Context = new();

Context.Database.Migrate();

#region Inheritance
////Context.Students.Add(new() { FullName = "Ahmed Ali", Grade = 10 });
////Context.Teachers.Add(new() { FullName = "Sally Sayed" , HireDate = new DateTime(1990 , 1 , 1)});

//Context.Add(new Student() { FullName = "Ahmed Ali", Grade = 10 });
//Context.People.Add(new Teacher() { FullName = "Sally Sayed", HireDate = new DateTime(1990, 1, 1) });



//Context.SaveChanges();


////foreach (var item in Context.Students)
////{
////    Console.WriteLine($"{item.FullName} {item.Grade}");
////}


////foreach (var item in Context.Teachers)
////{
////    Console.WriteLine($"{item.FullName} {item.HireDate}");
////}

//foreach (var item in Context.People.OfType<Student>())
//{
//    Console.WriteLine($"{item.FullName} {item.Grade}");
//}


//foreach (var item in Context.People.OfType<Teacher>())
//{
//    Console.WriteLine($"{item.FullName} {item.HireDate}");
//} 
#endregion


//DetailedAddress DetailedAddress = new()
//{
//    AddressLine01 = "B148 Smart Village",
//    City = "Gz",
//    ZipCode = "12111",
//    IsActive = true
//};

//Context.Add(new Branch() { Address = DetailedAddress, Style = BranchStyle.HyperMarket, Title = "HQ" });
//Context.SaveChanges();

//Console.WriteLine(Context.Branches.Skip(1).First().Style);

Order O = new() { Price = new Dollars(50) };
Context.Add(O);
Context.SaveChanges();

var ordr = Context.Orders.First();
Console.WriteLine(ordr.Price);
