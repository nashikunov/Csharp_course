using System;
using System.Collections.Generic;

namespace ДЗ_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое положительное число");
            uint x = uint.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите второе положительное число");
            uint y = uint.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;

                }
                else
                {
                    if (y > x)
                    {
                        y = y - x;
                    }
                }
			}

                if (x == 1)
                {
                     Console.WriteLine("Числа взаимно простые");
                
                }
                else
                {
                    Console.WriteLine("Числа взаимно не простые");
                }
		      
                                                                                                                                              
            
        }
    }
}
