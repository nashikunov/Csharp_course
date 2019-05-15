using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Rating { get; set; }
        public int GroupId { get; set; }


        public Student(string Name, string Surname, DateTime DateOfBirth, int Rating, int GroupId)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
            this.Rating = Rating;
            this.GroupId = GroupId;
        }


    }
}
