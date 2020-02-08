using System.Collections.Generic;

namespace VojsaceCinema.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Proffesor { get; set; }
        public string SemestarYear { get; set; }
        public string Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}