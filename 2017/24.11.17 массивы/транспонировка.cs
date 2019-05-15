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
			Console.WriteLine("n = ");
			uint n = uint.Parse(Console.ReadLine());
			
			Console.WriteLine("m = ");
			uint m = uint.Parse(Console.ReadLine());
			
			int[,] array = new int[n, m];
			
			Random rand = new Random();
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i,j] = rand.Next(0,10);
					Console.Write(array[i, j]+ "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			
			int[,] array1 = new int[m, n];
			
			for (int a = 0; a < array1.GetLength(0); a++)
			{
				for (int b = 0; b < array1.GetLength(1); b++)
				{
					array1[a,b] = array[b,a];
					Console.Write(array[b,a]+ "\t");
				}
				Console.WriteLine();
			}
			
			Console.ReadLine();
		
		
	    }
	}
}
			


