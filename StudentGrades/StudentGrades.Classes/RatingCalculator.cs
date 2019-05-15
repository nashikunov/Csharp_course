using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades.Classes
{
    public interface IRatingCalculator
    {
        int GetRating(Student student);
    }

    public class SimpleRatingCalculator : IRatingCalculator
    {


        public int GetRating(Student student) 
        {
            int rating = 0;
            foreach (var grade in student.Grades)
                rating += grade.Value;
            return rating;
        }
    }

        public class HSERatingCalculator : IRatingCalculator
    {
            public int GetRating(Student student)
            {
                int rating = 0;
                foreach (var grade in student.Grades)
                    rating += grade.Value * grade.Course.Credits;
                return rating;
            }
        }




    
}
