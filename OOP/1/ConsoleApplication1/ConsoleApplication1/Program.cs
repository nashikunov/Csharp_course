using System;
using System.Collections.Generic;
using System.Security;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Name = "a",
                Age = new DateTime(2000, 10, 10),
                Email = "as@x.a",
                PhoneNumber = "+79859057437"

            };
            
            
            Person p2 = new Person("a", new DateTime(2000, 10, 10));
            Person p3 = new Person("a", new DateTime(2000, 10, 10), "sfsd", "sfd@sd.c");
            Person p4 = new Person("a", new DateTime(2000, 10, 10))
            {
                Email = "ssf@ds.ds",
                PhoneNumber = "sadfs"

            };
            
            Console.WriteLine(p4.GetFullInfo());
            

            DateTime d = new DateTime(2000, 4, 5);
            var d2 = DateTime.Now;
            Console.WriteLine($"Current time: {d2.Hour:D2}:{d2.Minute:D2}:{d2.Second:D2}");
            var difference = (d2 - d).Days;
            Console.WriteLine(difference);
            Console.ReadLine();

        }
    }
}