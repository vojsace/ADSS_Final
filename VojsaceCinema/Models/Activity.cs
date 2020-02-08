using System;

namespace VojsaceCinema.Models
{
    public enum  ActivityType
    {
        Presentation, Homework, Quiz
    }
    public class Activity
    {
        public int ActivityId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime DatePresented { get; set; }
        public ActivityType? ActivityType { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}