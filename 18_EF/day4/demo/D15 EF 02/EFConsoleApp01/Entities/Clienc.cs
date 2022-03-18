using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp01.Entities
{
    public class Clienc
    {
        public int ID { get; set; }
        
        [MaxLength(20)]
        public string? Branch { get; set; }

        public virtual ICollection<PatientClienc> PatientCliencs { get; set; } = new HashSet<PatientClienc>();

    }
}
