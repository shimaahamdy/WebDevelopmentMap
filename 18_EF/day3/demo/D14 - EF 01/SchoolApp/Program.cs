using Microsoft.EntityFrameworkCore;
using SchoolApp;

using (SchoolContext Context = new SchoolContext())
{
    Context.Database.EnsureDeleted();
    Context.Database.EnsureCreated();


    #region Insert
    //Teacher T = new() { FullName = "Ahmed Ali", BirthDate = new DateTime(1990, 1, 1) };

    //Context.Teachers.Add(T); 
    #endregion

    #region Select , update
    ////Select
    ////Default for ALL L2E queries , Run on Database
    //Teacher teacher = (from T in Context.Teachers
    //                  where T.Age == null
    //                  select T).FirstOrDefault();


    //if (teacher != null)
    //    teacher.Age = DateTime.Now.Year - teacher.BirthDate.Year;
    /////Change in Local Copy (DBset.Local) 
    #endregion

    #region Delete
    //var T = Context.Teachers.FirstOrDefault();

    //Context.Teachers.Remove(T);
    /////removed locally 

    //Context.SaveChanges(); 
    #endregion

    #region EntityState
    //Teacher teacher = new Teacher() { FullName = "Sally Ali", BirthDate = new(1990, 1, 1), Age = 32 };

    /////V1.
    ////Context.Teachers.Add(teacher); ///valid EFCore , EF 6.4.X
    ////V2.
    ////Context.Add(teacher); ///valid in EFCore Only
    ////V3. Manually change EntityState
    //Console.WriteLine(Context.Entry(teacher).State);

    //Context.Entry(teacher).State = EntityState.Added;

    //Context.SaveChanges();

    //Console.WriteLine(Context.Entry(teacher).State); 
    #endregion

    //Console.WriteLine(T.ID);

    Department D = new() { Name = "Secondary Level", Branch = "Alex" };

    Context.Add(D);

    Context.Add(new Teacher() { FullName = "Ahmed Sayed", Department = D, BirthDate = new(1990, 1, 1) });

    Context.SaveChanges();


}