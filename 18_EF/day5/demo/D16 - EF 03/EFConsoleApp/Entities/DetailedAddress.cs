using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Entities
{
    public class DetailedAddress
    {
        [Required]
        [MaxLength(100)]
        public string AddressLine01 { get; set; }
        [MaxLength(100)]
        public string? AddressLine02 { get; set; }
        [Required, MaxLength(20)]
        public string ZipCode { get; set; }

        [StringLength(2, MinimumLength = 2)]
        public string? City { get; set; }
        public bool IsActive { get; set; }
    }
}
