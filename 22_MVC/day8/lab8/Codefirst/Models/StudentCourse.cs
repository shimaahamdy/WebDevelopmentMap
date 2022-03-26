namespace Codefirst.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }

        //navagation to student & course
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
