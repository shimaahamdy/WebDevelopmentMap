﻿using System.ComponentModel.DataAnnotations;

namespace Task2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }

        [Required]
        public char Gender { get; set; }

        
        public float Salary { get; set; }
    }
}
