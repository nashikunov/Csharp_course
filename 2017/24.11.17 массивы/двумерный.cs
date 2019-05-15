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
			char rep;
			do
			{
				int[,] array = new int[2, 2];
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
			Console.WriteLine("for repeat push Y ");
			rep = char.Parse(Console.ReadLine());
			
			
			}
			while ((rep == 'y' || rep == 'Y'));
		
		
	    }
	}
}
			

