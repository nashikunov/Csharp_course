using System;

namespace ConsoleApplication10
{
    public class Assignment
    {
        public int Id { get; private set; } = 0;
        public string Name { get; private set; }
        public string Text { get; set; }
        public DateTime Deadline { get; private set; }

        public Assignment(int id, string name, string text, DateTime deadline)
        {
            Id = id;
            Name = name;
            Text = text;
            Deadline = deadline;
        }

        public Assignment ChangeDeadLine(DateTime deadline)
        {
            return  new Assignment(Id, Name, Text, Deadline);
        }

        public void Print()
        {
            Console.WriteLine($"{Name} till {});
        }
        


    }
}