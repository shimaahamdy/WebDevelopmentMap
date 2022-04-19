using Microsoft.AspNetCore.SignalR;
using Task2.Models;

namespace Task2.Hubs
{
    public class EmployeeHub: Hub
    {
        private readonly EmployeeContext _context;

        public EmployeeHub(EmployeeContext context)
        {
            _context = context;
        }
        public void submitEmp(string name, int age,char Gender,float salary)
        {
            Employee employee = new Employee()
            {
                Name = name,
                Age = age,
                Gender = Gender,
                Salary = salary
            };
            _context.Add(employee);
            _context.SaveChangesAsync();
            Clients.All.SendAsync("newEmp", name, age, Gender, salary);
        }
    }
}
