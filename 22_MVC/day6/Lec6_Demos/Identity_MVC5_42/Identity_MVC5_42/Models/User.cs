using System.ComponentModel.DataAnnotations;

namespace Identity_MVC5_42.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }

        public string Phone { get; set; }
        public string Country { get; set; }
    }
}