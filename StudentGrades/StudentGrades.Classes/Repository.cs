using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades.Classes {
    public class Repository {
        public List<Course> Courses { get; set; } 
        public List<Student> Students { get; set; } // reference - connected id - connected

        public Repository() {
            // Sample data set
            Courses = new List<Course>
            {
                new Course
                {
                    Name = "Programming",
                    Credits = 5
                },
                new Course
                {
                    Name = "Calculus",
                    Credits = 6
                }
            };

            Students = new List<Student>
            {
                new Student
                {
                    Name = "Ivan Ivanov",
                    Grades = new List<CourseGrade>
                    {
                        new CourseGrade
                        {
                            Course = Courses[0],
                            Value = 9
                        },
                        new CourseGrade
                        {
                            Course = Courses[1],
                            Value = 8
                        }
                    }
                },
                new Student
                {
                    Name = "Dmitry Petrov",
                    Grades = new List<CourseGrade>
                    {
                        new CourseGrade
                        {
                            Course = Courses[1],
                            Value = 6
                        }
                    }
                }
            };
        }

        public bool CanDeleteCourse(Course course) {
            // No marks were given for a course - it can be then deleted
            return Students.All(s => s.Grades.All(g => g.Course != course));
        }

        

    }
}
