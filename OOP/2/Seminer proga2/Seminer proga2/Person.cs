using System;

namespace Seminerproga2
{
    public class Person
    {
        private string name;
        private DateTime age;
        Passport passport;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public DateTime Age
        {
            get { return age; }
            set { age = value; }
        }
        
        internal Passport Passport
        {
            get { return passport; }
            set { passport = value; }
        }
    }
    
}