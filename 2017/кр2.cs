using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{
    class Program
    {
        
			static int Stepen(int x, int n)
			{
				int result;
				result = 1;
				for (int i = 0; i < n; i++)
				{
					result = result * x;
				}
				
				return result;	
				
			}
			static void Main(string[] args)
			{
				int y;
				
				Console.WriteLine("x=");
				Console.WriteLine("n=");
				int x = int.Parse(Console.ReadLine());
				int n = int.Parse(Console.ReadLine());
				y = Stepen(x, n);
				Console.WriteLine(y);
				
			}
	}
}
	
				
			
		
	

			


