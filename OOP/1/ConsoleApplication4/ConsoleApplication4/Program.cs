using System;
using System.Collections.Generic;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student("Kolya", new DateTime(1999, 12, 18));
            s1.GetRating();
            Console.WriteLine(s1.GetFullInfo());
        }
    }
}