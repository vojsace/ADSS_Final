using System.ComponentModel.DataAnnotations;

namespace VojsaceCinema.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string StudentYear { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}