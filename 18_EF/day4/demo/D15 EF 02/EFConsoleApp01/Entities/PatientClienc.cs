using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp01.Entities
{
    public class PatientClienc
    {
        public int CliencID { get; set; }
        public int PatientPID { get; set; }

        public DateTime Visit { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Clienc Clienc { get; set; }
    }
}
