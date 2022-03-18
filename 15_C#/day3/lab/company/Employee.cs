namespace company
{
    public struct Employee
    {
        int ID;
        int securityLevel;
        decimal salry;
        HiringDate hireDate;
        gender employeeGender;
        string name;

        public Employee(int _ID,String _name, int _securityLevel, int _salary, int day, int month, int year, string _gender)
        {
            ID = _ID;
            name = _name;
            securityLevel = _securityLevel;
            salry = _salary;
            hireDate = new HiringDate(day, month, year);
            employeeGender = (gender)Enum.Parse(typeof(gender), _gender);
        }

            public override string ToString()
        {
            return string.Format($"ID: {ID} name:{name} salary:{salry}$");
        }
            
            public int getId()
        {
            return ID;
        }
            public void setId(int _id)
        {
            ID = _id;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string _name)
        {
            name = _name;
        }

        public int getSecurityLevel()
        {
            return securityLevel;
        }
        public void setSecurityLevel(int _securityLevel)
        {
            securityLevel = _securityLevel;
        }

        public decimal getSalary()
        {
            return salry;
        }
        public void setSalary(decimal _salary)
        {
            salry = _salary;
        }
        public int getHireDateYear()
        {
            return hireDate.year;
        }
        public int getHireDateMonth()
        {
            return hireDate.month;
        }
        public int getHireDateDay()
        {
            return hireDate.day;
        }
        public void setHireDate(int _day,int _month, int _year)
        {
            hireDate.year = _year;
            hireDate.month = _month;
            hireDate.day = _day;
        }
        
        public string getGender()
        {
            if (employeeGender == gender.Female) return "Female";
            else return "Male";
        }


    }

    
}