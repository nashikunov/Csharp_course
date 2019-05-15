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
			Console.WriteLine("Введите размер квадратной матрицы");
			uint n = uint.Parse(Console.ReadLine());
		
			int[,] array = new int[n,n];
			for (int i = 0; i < array.GetLength(0); ++i)
			{
				for (int j = 0; j < array.GetLength(1); ++j)
				{
					if (i == j)
					{
						array[i,j] = 0;
					}
					else
					{
						if (j > i)
						{
							array[i,j] = 1;
						}
						else
						{
							array[i,j] = -1;
						}
					}
					Console.Write(array[i, j]+ "\t");
				}
				
				Console.WriteLine();
			}
			
			
		
		
	    }
	}
}
			



