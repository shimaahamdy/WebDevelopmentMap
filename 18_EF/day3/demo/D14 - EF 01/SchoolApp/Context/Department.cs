using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    /// Data Annotations
    [Table("Sections")]
    public class Department
    {
        [Key] //PK , Identity
        public int DeptID { get; set; }
        [Required] //not Null
        [MaxLength(40)] //nvarchar (40)
        public string Name { get; set; }
        [NotMapped]
        public DateTime CreateDate { get; } = DateTime.Now;
        [MaxLength(20)]
        [Column("SchoolBranch")]
        public string Branch { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
    }
}
