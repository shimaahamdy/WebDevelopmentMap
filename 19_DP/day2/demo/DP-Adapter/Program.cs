using DP_Adapter;

Console.WriteLine("Hello, World!");

Person P02 = new Person() { FName = "Amr", LName = "Nabiel", AnnualSalary = 100_000 };

PersonEngine.ProcessPerson(P02);


Employee E = new() { FullName = "Ahmed Ali", MonthlySalary = 2000 };

//PersonEngine.ProcessPerson(new EmployeeAdapter(E)); 

//PersonEngine.ProcessPerson(E);///Not Valid

EmployeeAdapter Adapter = new EmployeeAdapter(E);

PersonEngine.ProcessPerson(Adapter);

