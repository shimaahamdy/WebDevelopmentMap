namespace company
{
    public struct Employee
    {
        int id;
        securityLevel security;
        decimal salry;
        HiringDate hireDate;
        gender employeeGender;
        string name;

        public Employee(int _id,String _name, string _securityLevel, int _salary, int day, int month, int year, string _gender)
        {
            id= _id;
            name = _name;
            security = (securityLevel)Enum.Parse(typeof(securityLevel),_securityLevel);
            salry = _salary;
            hireDate = new HiringDate(day, month, year);
            employeeGender = (gender)Enum.Parse(typeof(gender), _gender);
        }


            public override string ToString()
        {
            return string.Format($"ID: {id} name:{name} hireDate:{hireDate} salary:{salry}$");
        }
        
        /***********************************************************/
        public int ID
        {
            get { return id; }
        }

        public securityLevel Security
        {
            get { return security; }
            set { security = value; }
        }
        public decimal Salry
        {
            get { return salry; }
            set { salry = value; }
        }
        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public gender EmployeeGender
        {
            get { return employeeGender; }
            set { employeeGender = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /* 0 boxing and unboxing there is no convert from object to value type */
        public static  void sortEmployee(ref Employee[] EmpArr) //ref by value
        {
            for (int i=0;i<EmpArr?.Length -1;++i)
            {
                // Find the minimum element in unsorted array
                int minEmp = i;
                for (int j = i + 1; j < EmpArr?.Length; ++j)
                    if (EmpArr[j].hireDate.year < EmpArr[minEmp].hireDate.year)
                        minEmp = j;
                    else if (EmpArr[j].hireDate.year == EmpArr[minEmp].hireDate.year)
                    {
                        if(EmpArr[j].hireDate.month < EmpArr[minEmp].hireDate.month)
                            minEmp = j;
                        else if(EmpArr[j].hireDate.day < EmpArr[minEmp].hireDate.day)
                            minEmp = j;
                    }

                // Swap the found minimum element with the first element
                swapEmp( ref EmpArr[minEmp], ref EmpArr[i]);
            }
        }
        private static void swapEmp(ref Employee emp1, ref Employee emp2)
        {
            Employee temp = emp1;
            emp1 = emp2;
            emp2 = temp;
        }
        public static void printArray(Employee[] EmpArr)
        {

            for (int i = 0; i < EmpArr?.Length; ++i)
                Console.WriteLine(EmpArr[i]);
        }



    }
}

    
