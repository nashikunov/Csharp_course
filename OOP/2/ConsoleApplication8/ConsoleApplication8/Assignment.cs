using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication8
{
    public class Assignment
    {
        private int _id;
        private string _name;
        private string _text;
        private DateTime _Deadline;
        
        

        public int Id
        {
            get
            {
                return _id;
                
            }
            set
            {
                _id = value;
                
            }
        }
        
        public string name
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
        
        public string text
        {
            get
            {
                return _text;
                
            }
            set
            {
                _text = value;
                
            }
        }
        
        public DateTime deadline
        {
            get
            {
                return _Deadline;
                
            }
            set
            {
                _Deadline = value;
                
            }
        }

        public Assignment(int id, string name, string text, DateTime deadline)
        {
            _id = id;
            _name = name;
            _text = text;
            _Deadline = deadline;
        }

        public string Print()
        {
            return $"id - {_id}, name - {_name}, text - {_text}, deadline - {_Deadline:D}";
        }
        
    }
}