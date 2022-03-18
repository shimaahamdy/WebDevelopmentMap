using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    ///Adaptee
     class Employee
    {
        public string FullName { get; set; }

        public double MonthlySalary { get; set; }

        public override string ToString()
            => $"Employee {FullName} , Monthly Salary {MonthlySalary}";
    }
}
