using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onException_HandleError.Models
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