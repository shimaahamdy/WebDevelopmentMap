using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    struct Employee
    {
        public int EmpID;

        string FullName;

        internal void SetName (string _Name)
        { FullName = _Name.Length <= 8 ? _Name : _Name.Substring(0, 8); }

        public string GetName ()
        { return FullName; }
        

        decimal salary;
        
        public decimal Salary
        {
            get { return salary; }
            internal set { salary = value > 2000? value : 2000; }
        }

        public decimal Taxes
        { get { return 0.2M*salary; } }

    }
}
