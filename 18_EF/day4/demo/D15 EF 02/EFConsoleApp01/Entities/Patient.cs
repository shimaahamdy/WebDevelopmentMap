using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp01.Entities
{
    ///POCO Class
    ///Plain Old CLR Object
    public class Patient
    {
        public int PID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public decimal Amount { get; set; } 
        public int? Age { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public virtual ICollection<Doctor> doctors {  get; set; } = new HashSet<Doctor>();

        public virtual ICollection<PatientClienc> PatientCliencs { get; set; } = new HashSet<PatientClienc>();

    }
}
