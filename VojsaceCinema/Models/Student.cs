using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VojsaceCinema.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public int StudentId { get; set; }
        public DateTime StudentEnrolledDate { get; set; }
        public DateTime DOB { get; set; }
        public string Description { get; set; }
        public bool IsRegular { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
