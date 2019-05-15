using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int sum = 0;
            int r = rand.Next(0,100);
            double avr = 0;
            int i = 1;
            while (r > avr)
            {
                sum += r;
                avr = sum / i;
                ++i;
                Console.WriteLine("Рандомное число - " + r + ", а среднее арифметическое - " + avr);
                
                r = rand.Next(1,101);
            }
            if (r < avr)
            {
                Console.WriteLine("Рандомное число - " + r + ", меньше среднего арифметического - " + avr);
            }
            
            
                                         
           
        }
    }
}
