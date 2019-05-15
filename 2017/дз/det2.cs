using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    class Program
    {
        static void Main(string[] args)
        {
			int[,] array = new int[2, 2];
			int a = 1, b = 1;
			Random rand = new Random();
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i,j] = rand.Next(-50,50);
					Console.Write(array[i, j]+ "\t");
					if (i == j)
					{
						a *= array[i,j];
					}
					else 
					{
						b *= array[i,j];
					}
					
				}
				Console.WriteLine();
			}
			Console.WriteLine("Det = "+(a - b));
			
			
			
			Console.ReadLine();
		
		
	    }
	}
}
			


