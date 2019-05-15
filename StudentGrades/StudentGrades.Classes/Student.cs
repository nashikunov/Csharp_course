using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades.Classes {
    public class Student {
        public string Name { get; set; }
        public List<CourseGrade> Grades { get; set; }

        //public int Rating
        //{
        //    get
        //    {
        //        int rating = 0;
        //        foreach (var grade in Grades)
        //            rating += grade.Value;
        //        return rating;
        //    }
        //}
            
    }
}
