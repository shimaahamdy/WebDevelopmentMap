using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp01.Entities
{
    public class Doctor
    {
        [Key]
        public int DID { get; set; }

        [Required]
        [MaxLength(40)]
        public string FName { get; set; }

        [Required]
        [MaxLength(40)]
        public string LName { get; set; }

        [Range(20 , 70)]
        public int? Age {  get; set; }

        [MaxLength(120)]
        [EmailAddress]
        public string? Email { get; set; }

        [MaxLength (100)]
        [Phone]
        public string? PhoneNumber { get; set; }

        //[Column (TypeName ="money")]
        //public decimal Salary { get; set; }

        public Department Department { get; set; }

        public virtual ICollection<Patient> Patients { get; set; } = new HashSet<Patient>();

    }
}
