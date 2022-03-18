using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    
    public class Teacher
    {
        ///Per EF Convensions : PK , Identity
        public int ID { get; set; }

        ///Nullable Data Type : allow Null
        ///Refrence Type : Allow Null
        ///nvarchar (max)
        public string FullName { get; set; }

        ///Nullable Value Type : Allow null
        public int? Age { get; set; }

        ///non Nullable Value Type : Not Allow Null
        public DateTime BirthDate { get; set; }

        ///Navigational Property
        public virtual Department Department { get; set; }

    }
}
