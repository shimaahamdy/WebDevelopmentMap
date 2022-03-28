using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace APIcore.Models
{
    public class student
    {
        public int id { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(50)]

        public string email { get; set; }
        [MaxLength(50)]

        public string password { get; set; }
        public int? age { get; set; }
        [ForeignKey("Department")]
        public int? deptid { get; set; }
        public virtual department Department { get; set; }
    }
}
