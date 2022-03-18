using EFConsoleApp01.Context;
using EFConsoleApp01.Entities;
using Microsoft.EntityFrameworkCore;

using ( HospitalContext Context = new())
{
    Context.Database.Migrate();
    ///C# version = PMC :> Update-Database

    #region Validation , Migration
    //Doctor D = new()
    //{
    //    FName = "Sayed",
    //    LName = "Ali",
    //    Age = 35,
    //    Email = "Ahmed.Ali02@gmail.com",
    //    PhoneNumber = "1234567"
    //};

    //Context.Add(D);

    ////EF Core No Longer Validate Model , Objects before exceuting SaveChanges
    ////EF use assumption that the data have been already validated in UI Layer or any Higher layer
    //int R = Context.SaveChanges();

    //Console.WriteLine($"Number of Rows Affected {R}");

    //Console.WriteLine(D.DID);

    //Doctor D = new()
    //{
    //    FName = "Ahmed",
    //    LName = "Ali",
    //    Age = 35,
    //    Email = "Ahmed.Ali@Hospital.com",
    //    PhoneNumber = "123456789"
    //};

    //Context.Add(D);

    //int R = Context.SaveChanges();

    //Console.WriteLine($"Number of Rows Affected {R}");

    //Console.WriteLine(D.DID); 
    #endregion


}