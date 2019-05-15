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
			Console.WriteLine("Input x = ");
			    double x = double.Parse(Console.ReadLine());
			    
			Console.WriteLine("Input y = ");
			    double y = double.Parse(Console.ReadLine());
			    
			if (y <= Math.Sqrt(x+4) && y >= Math.Pow(x,3) && y >= -1*Math.Pow(x,3) - 1 && x <= 0 || y >= 0.6*x - 3 && y <= -1*Math.Pow(x,3) - 1 && x>= 0)
			{
			    Console.WriteLine("Точка попала");
			}
			    
			else 
			{
			    Console.WriteLine("Точка не попала");
			}
	    }
	}
}
			
