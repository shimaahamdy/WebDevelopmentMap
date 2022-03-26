using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codefirst.Models
{
    
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Gender Gen { get; set; }

        [EmailAddress]
        [Required]
        public string Emali { get; set; }
        
        public int PhoneNum { get; set; }
        //public DateTime date { get; set; }

        //navigate to jointable
        public List<StudentCourse> StudentCourse { get; set; }


    }
}
