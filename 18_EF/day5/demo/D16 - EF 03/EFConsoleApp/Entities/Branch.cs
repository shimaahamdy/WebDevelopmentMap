using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Entities
{
    public class Branch
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }
        [Required]
        public DetailedAddress Address { get; set; }

        public BranchStyle Style { get; set; }

    }
}
