using System;

namespace company
{
    public class EmployeeSearch
    {
        Employee[] Employees;
        public EmployeeSearch(Employee []Emp)
        {
            Employees = new Employee[Emp.Length];
            for (int i = 0; i < Emp?.Length; i++)
            {
                Employees[i] = Emp[i];
            }
        }

        public Employee this[int index]
        {
            get
            {
                for (int i = 0; i < Employees?.Length; i++)
                { 
                    if(Employees[i].ID == index)
                        return Employees[i];

                }
                return new Employee();
            }
        }
    }

    
}
