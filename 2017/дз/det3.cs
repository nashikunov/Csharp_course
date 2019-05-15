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
			int[,] array = new int[3, 3];
			Random rand = new Random();
			int det;
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					array[i,j] = rand.Next(0,10);
					Console.Write(array[i, j]+ "\t");
					
									
				}
				Console.WriteLine();
			}
			det = array[1,1] * array[2,2] * array[3,3] + array[1,2] * array[2,3] * array[3,1] + array[2,1] * array[3,2] * array[1,3] - array[3,1] * array[2,2] *
			
			
			
			Console.ReadLine();
		
		
	    }
	}
}
			


