using System;

namespace airport
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                
            }
        }

        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }
            set
            {
                _birthdate = value;
                
            }
        }

        private bool _student;
        public bool student
        {
            get
            {
                return _student;
                
            }
            set
            {
                _student = value;
                
            }
        }

        public Person(string name, DateTime birthdate, bool student)
        {
            _name = name;
            _birthdate = birthdate;
            _student = student;
        }

        public string GetFullInfo()
        {
            return $"Person ' s name - {_name}, Birthdate - {_birthdate:D}, Student - {_student}";
        }

    }
}