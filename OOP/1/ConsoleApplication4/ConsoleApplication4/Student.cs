using System;

namespace ConsoleApplication4
{
    public class Student
    {
        private string _name;
        private DateTime _DateTime;
        private int[] _marks;
        private int _rating;


        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public DateTime Age
        {
            get => _DateTime;
            set => _DateTime = value;
        }
        
        public int[] Mark
        {
            get => _marks;
            set => _marks = value;
        }

        public Student(string name, DateTime Age)
        {
            _name = name;
            _DateTime = Age;
            Random rand = new Random();
            _marks = new int[rand.Next(1, 30)];


        }

        public string GetFullInfo()
        {
            return $"Student ' s name{_name}, age {_DateTime.Date}, rating {_rating}  ";
        }

        public int GetRating()
        {
            int _rating;
            _rating = _marks[0] + _marks[1] + _marks[2];
            return _rating;
        }

        public int GetAge()
        {
            var currentDate = DateTime.Now;
            int age = currentDate.Year - _DateTime.Year;
            if (currentDate.Month < _DateTime.Month ||
                (currentDate.Month == _DateTime.Month && currentDate.Day < _DateTime.Day))
                age--;
            return age;
        }

    }
}