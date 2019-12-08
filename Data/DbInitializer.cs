using Microsoft.EntityFrameworkCore.Internal;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class DbInitializer
    {
        //start
        
        public static void Initialize(CinemaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            var category = new Category[]
            {
                new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
            

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
          
            
                
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
        
        //end
    }
}