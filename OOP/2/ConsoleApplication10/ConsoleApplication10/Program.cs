using System;
using System.Collections.Generic;

namespace ConsoleApplication10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Assignment a = new Assignment(1, "a", "b", DateTime.Now);
            a.ChangeDeadLine((DateTime.Now.AddDays(1)));



        }
    }
}