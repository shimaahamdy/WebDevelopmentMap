using company;
using System;
Console.WriteLine("enter employees numbers:");
string input = Console.ReadLine();
int num;
bool success = int.TryParse(input, out num);

while (!success)
{
    Console.WriteLine("enter employees numbers:");
    input = Console.ReadLine();
   success = int.TryParse(input, out num);

}
Employee[] EmpArr = new Employee[num];
//DBA guest officer
for (int i = 0; i < num; i++)
{
    /* name */
    Console.WriteLine("enter emp name:");
    string name = Console.ReadLine();

    /* id */
    Console.WriteLine("enter emp id:");
    input = Console.ReadLine();
    int id;
    success = int.TryParse(input, out id);
    while (!success)
    {
        Console.WriteLine("enter emp id:");
        input = Console.ReadLine();
        success = int.TryParse(input, out num);

    }

    /* secutitry*/
    Console.WriteLine("enter emp securityLevel:");
    string security = Console.ReadLine();
    while(!(security.Equals("guest") || security.Equals("secretary") || security.Equals("developer") || security.Equals("officer") || security.Equals("DBA")))
    {
        Console.WriteLine("enter emp securityLevel:");
        security = Console.ReadLine();
    }


    Console.WriteLine("enter emp salary:");
    int salry;
    input = Console.ReadLine();
    success = int.TryParse(input, out salry);
    while (!success)
    {
        Console.WriteLine("enter emp salary:");
        input = Console.ReadLine();
        success = int.TryParse(input, out salry);
    }



    Console.WriteLine("enter emp hireDateYear:");
    int year;
    input = Console.ReadLine();
    success = int.TryParse(input, out year);
    while (!success)
    {
        Console.WriteLine("enter emp hireDateYear:");
        input = Console.ReadLine();
        success = int.TryParse(input, out year);
    }

    Console.WriteLine("enter emp hireDateMonth:");
    int month;
    input = Console.ReadLine();
    success = int.TryParse(input, out month);
    while (!success)
    {
        Console.WriteLine("enter emp hireDateMonth:");
        input = Console.ReadLine();
        success = int.TryParse(input, out month);
    }
    Console.WriteLine("enter emp hireDateDay:");
    int day;
    input = Console.ReadLine();
    success = int.TryParse(input, out day);
    while (!success)
    {
        Console.WriteLine("enter emp hireDateDay:");
        input = Console.ReadLine();
        success = int.TryParse(input, out day);
    }

    Console.WriteLine("enter emp gender:");
    string gender = Console.ReadLine();
    while(!(gender=="Female" || gender=="Male"))
    {
        Console.WriteLine("enter emp gender:");
        gender = Console.ReadLine();
    }

    EmpArr[i] = new Employee(id, name, security, salry, day, month, year, gender);
    Console.WriteLine("***************************************************");
}

Employee.printArray(EmpArr);

Console.WriteLine("***************************************************");


Employee.sortEmployee(ref EmpArr);
Console.WriteLine("***************************************************");

Employee.printArray(EmpArr);

EmpArr[1].Name = "ALKbeer";
Console.WriteLine(EmpArr[1].Name);

Console.WriteLine("***************************************************");

EmployeeSearch searchEmp = new EmployeeSearch(EmpArr);
Employee emp = searchEmp[5];
Console.WriteLine(emp);
