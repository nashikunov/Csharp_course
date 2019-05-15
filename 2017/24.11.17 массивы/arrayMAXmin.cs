using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Array length = ");
			uint x = uint.Parse(Console.ReadLine());
			int max = 0;
			int min = 101;
			
			int[] array = new int[x];
			Random rand = new Random();
			for (int i = 0; i < x; ++i)
			{
				Console.WriteLine(array[i] = rand.Next(0, 100));
				if (array[i] > max)
				{
					max = array[i];
				}
				
				if (array[i] < min)
				{
					min = array[i];
				}
			}
			
			Console.WriteLine("max = "+max);
			Console.WriteLine("min = "+min);
			
			
        }
        
    }
}
