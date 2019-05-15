using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication1
{
    public class Person
    {
        private string _name;
        private DateTime _birthdate;
        private string _phoneNumber;
        private string _email;
				
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
      

        public DateTime Age
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }
        
       

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public Person()
        {
            
        }
        
        public Person(string name, DateTime age) // konstruktor
        {
            _name = name;
            _birthdate = age;
        }

        public Person(string name, DateTime age, string phoneNumber, string email) : this(name, age)
        {
            _phoneNumber = phoneNumber;
            _email = email;
        }

        public string GetFullInfo()
        {
            return $"Person ' s name {_name}, age {_birthdate}, phone number {_phoneNumber}, email {_email}";
        }

        public int GetAGe()
        {
            var currentDate = DateTime.Now;
            int age = currentDate.Year - _birthdate.Year;
            if (currentDate.Month < _birthdate.Month ||
                (currentDate.Month == _birthdate.Month && currentDate.Day < _birthdate.Day))
                age--;
            return age;
        }
     
    }
}