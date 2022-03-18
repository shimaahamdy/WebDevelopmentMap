using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_E.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "EmployeeName required")]
        [MaxLength(30, ErrorMessage = "Too long")]
        [MinLength(8, ErrorMessage = "too Short")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets allowed.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "username required")]
        [MaxLength(30, ErrorMessage = "Too long Name ")]
        [MinLength(8, ErrorMessage = "too Short")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets & numbers allowed.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "password required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [EnumDataType(typeof(Genderity))]
        public Genderity Gender { get; set; }
        [Range(3200, 20000)]
        public decimal Salary { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Required(ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Compare("Email", ErrorMessage = "Email doesn`t matah")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Phone;



    }
}