using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp01.Entities
{
    public class Department
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string DeptName { get; set; }


        public ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();


    }
}
