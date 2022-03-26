using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Codefirst.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Topic { get; set; }
        [Required]
        public int Grade { get; set; }

        //navigate to jointable
        public List<StudentCourse> StudentCourse { get; set; }

    }
}
