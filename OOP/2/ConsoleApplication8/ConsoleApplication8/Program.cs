using System;
using System.Collections.Generic;

namespace ConsoleApplication8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*int[] a = new int[] {1, 2, 3, 4, 5};
            int[] b = a;

            b[0] = 0;
            Console.WriteLine(a[0]); так недьзя ибо ссылка на 1 и тот же массив в хипе */
            
            Assignment A = new Assignment(123, "Kolya", "Hello", new DateTime(2019, 04, 15) );
            Console.WriteLine(A.Print());
            
        }
    }
}