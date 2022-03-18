using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    ///Inherit Target
    class EmployeeAdapter : Person
    {
        ///Compose Adaptee
        Employee employee;

        public EmployeeAdapter(Employee E) => employee = E;

        ///Delegation
        public string FName 
        {
            get => employee.FullName.Split(' ')[0];

            set => employee.FullName = $"{value} {employee.FullName.Split(' ')[1]}"; 
        }
        public string LName
        {
            get => employee.FullName.Split(' ')[1];

            set => employee.FullName = $"{employee.FullName.Split(' ')[0]} {value}";
        }
        public decimal AnnualSalary 
        { 
            get => Convert.ToDecimal( employee.MonthlySalary * 12) ;
            set => employee.MonthlySalary = Convert.ToDouble(value / 12); 
        }
    }
}
