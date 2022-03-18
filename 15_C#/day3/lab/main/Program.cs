using company;

Console.WriteLine("enter employees numbers");
int num = int.Parse(Console.ReadLine());
Employee[] EmpArr = new Employee[num];
for (int i = 0; i < num; i++)
{
    Console.WriteLine("enter emp name");
    string name = Console.ReadLine();
    Console.WriteLine("enter emp id");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("enter emp securityLevel");
    int securityLevel = int.Parse(Console.ReadLine());
    Console.WriteLine("enter emp salary");
    int salry = int.Parse(Console.ReadLine());
    Console.WriteLine("enter emp hireDateYear");
    int year = int.Parse(Console.ReadLine());
    Console.WriteLine("enter emp hireDateMonth");
    int month = int.Parse(Console.ReadLine());
    Console.WriteLine("enter emp hireDateDay");
    int day = int.Parse(Console.ReadLine());
    Console.WriteLine("enter emp gender");
    string gender = Console.ReadLine();

    EmpArr[i] = new Employee(id, name, securityLevel, salry, day, month, year, gender);
   
}

for (int i = 0; i < num; ++i)
    Console.WriteLine(EmpArr[i]);
