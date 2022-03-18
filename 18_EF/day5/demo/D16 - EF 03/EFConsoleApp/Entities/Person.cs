using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Entities
{
    [Table("People")]
    public  class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        public bool IsEmployee { get; protected set; }
    }


    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }
        public Teacher() => IsEmployee = true;
    }

    public class Student : Person
    {
        public Student() => IsEmployee = false;
        public int Grade { get; set; }
    }

    
}
