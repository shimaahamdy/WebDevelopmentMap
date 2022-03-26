using System.ComponentModel.DataAnnotations;

namespace Day8_Demo_42.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Too long Name.....")]
        public string Name { get; set; }

        public double Price { get; set; }
    }
}
