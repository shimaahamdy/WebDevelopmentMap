using System.ComponentModel.DataAnnotations;

namespace Day5_Demo_42.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Required]
        [MinAge(21)]
        public int Age { get; set; }
    }
}