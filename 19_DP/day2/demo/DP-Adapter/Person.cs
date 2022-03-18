using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    ///Target
    class Person
    {
        public virtual string FName { get; set; }
        public virtual string LName { get; set; }

        public virtual decimal AnnualSalary { get; set; }

    }

    class PersonEngine
    {
        public static void ProcessPerson (Person P)
        {
            Console.WriteLine($"{P.FName} {P.LName} Annual Salary : {P.AnnualSalary}");
        }
    }
}
