using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerOrders.Models
{
    [Table("Customers")]
    public class Customer
    {
      
    
            [Key]
            public int ID { get; set; }

            [Required(ErrorMessage = "Name required")]
            [MaxLength(30, ErrorMessage = "can not be more that 30 charachters")]
            [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only Alphabets allowed.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "username required")]
            [MaxLength(30, ErrorMessage = "can not be more that 30 charachters")]
            [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets & numbers allowed.")]
            public string Username { get; set; }

            [Required(ErrorMessage = "password required")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required]
            [EnumDataType(typeof(Genderity))]
            public Genderity Gender { get; set; }


            [Required(ErrorMessage = "Email required")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }


            [DataType(DataType.PhoneNumber)]
            public int Phone;


            public List<Order> Orders { get; set; }


        }
    }