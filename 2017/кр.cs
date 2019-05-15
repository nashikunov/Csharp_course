using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    class Program
    {
        static int Count(int a)
        {
			int count = 0;
			if (a == 1)
			{
				count ++;
			}
			return count;
		
		}
        static void Main(string[] args)
        {
			int count = 0;
			Console.WriteLine("N=");
			int N = int.Parse(Console.ReadLine());
			Random rand = new Random();
			int[,] array = new int[N,N];
			int[] posl = new int[N];
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					array[i,j] = rand.Next(0,2);
					Console.Write(array[i,j]+ "\t");
					
					
					if (array[i,j] == 1)
					{
						count ++;
					}
					
				}
				
				posl[i] = count;
				count = 0;
				
				
				Console.WriteLine();
			}
			Console.WriteLine();
			for (int k = 0; k < N; k++)
			{
				Console.Write(posl[k]+ "\t");
			}
			
			Console.ReadLine();
		
	    }
	}
}
			



