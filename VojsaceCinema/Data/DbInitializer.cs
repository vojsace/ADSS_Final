using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VojsaceCinema.Models;

namespace VojsaceCinema.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student{Id=1001, StudentName= "Zvonko", StudentEmail= "zvonko_zver@yahoo.com", StudentId= 1001,StudentEnrolledDate=DateTime.Parse("2018-01-01"),Description="Positive person"},
                new Student{Id=1002, StudentName= "Trajko", StudentEmail= "tale_zver@yahoo.com", StudentId= 1002,StudentEnrolledDate=DateTime.Parse("2019-01-01"),Description="Smart person"},
                new Student{Id=1003, StudentName= "Zoran", StudentEmail= "zoki_zver@yahoo.com", StudentId= 1003,StudentEnrolledDate=DateTime.Parse("2019-07-03"),Description="Lazy person"},
                new Student{Id=1004, StudentName= "Goran", StudentEmail= "goran_zver@yahoo.com", StudentId= 1004,StudentEnrolledDate=DateTime.Parse("2014-07-03"),Description="Studies with his youger brother Zoran"}
            };

            foreach (Student s in students)
            {
                context.Add(s);
            }

            var courses = new Course[]
           {
                new Course{ CourseName="Calculus", Proffesor="Jack Daniels", SemestarYear="II",Description="Quick Maths"},
                new Course{ CourseName="History", Proffesor="Lisa Banderas", SemestarYear="III",Description="History classes are the best"},
                new Course{ CourseName="Programming", Proffesor="Josh Mush", SemestarYear="V",Description="Learh how to Hack"},
                new Course{ CourseName="Databases", Proffesor="Benny Williams", SemestarYear="V",Description="Data is the most expensive part in IT world"}
           };

            foreach (Course c in courses)
            {
                context.Add(c);
            }

            var enrollments = new Enrollment[]
          {
                new Enrollment{ StudentId= 1001, CourseId=1,StudentYear="2018"},
                new Enrollment{ StudentId= 1002, CourseId=2,StudentYear="2019"},
                new Enrollment{ StudentId= 1002, CourseId=3,StudentYear="2019"},
                new Enrollment{ StudentId= 1003, CourseId=2,StudentYear="2019"},
                new Enrollment{ StudentId= 1004, CourseId=3,StudentYear="2017"},
                new Enrollment{ StudentId= 1004, CourseId=4,StudentYear="2019"}

         };

            foreach (Enrollment e in enrollments)
            {
                context.Add(e);
            }

            var activities = new Activity[]
          {
                new Activity{ StudentId=1001, CourseId=1,DatePresented=DateTime.Parse("2018-07-03"), ActivityType=ActivityType.Presentation},
                new Activity{ StudentId=1002, CourseId=2,DatePresented=DateTime.Parse("2019-06-09"), ActivityType=ActivityType.Homework},
                new Activity{ StudentId=1003, CourseId=1,DatePresented=DateTime.Parse("2019-02-07"), ActivityType=ActivityType.Quiz}


         };

            foreach (Activity a in activities)
            {
                context.Add(a);
            }

            context.SaveChanges();
        }
    }
}
