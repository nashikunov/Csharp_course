using System;
using System.Collections.Generic;

namespace airport
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person John = new Person("John", new DateTime(1999,12,12), true);
            Person Mike = new Person("Mike", new DateTime(1995,10,04), true);
            Person Rod = new Person("Rod", new DateTime(2004,03,07), false);
            Person Stew = new Person("Stew", new DateTime(1998,01,09), true);

            Console.WriteLine(John.GetFullInfo());
            Console.WriteLine(Mike.GetFullInfo());
            Console.WriteLine(Rod.GetFullInfo());
            Console.WriteLine(Stew.GetFullInfo());


            var d = DateTime.Now;
            Console.WriteLine($"Current time is - {d.Hour:D2}:{d.Minute:D2}:{d.Second:D2}");

        }
    }
}