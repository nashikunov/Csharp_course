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
			Console.WriteLine("Maximum x = ");
			double a = double.Parse(Console.ReadLine());
					
			Console.WriteLine("Minimum x = ");
			double b = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Maximum y = ");
			double c = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Minimum y = ");
			double d = double.Parse(Console.ReadLine());
			
			for (double x = b; x <= a; x += 0.2)
			    {
					for (double y = d; y <= c; y += 0.2)
					{
					    if ((y >= 0) && ((y <= Math.Pow(x,2) && x >= 0 && y <= Math.Sqrt(x) && y <= Math.Sqrt(9 - Math.Pow(x,2))) || (y <= Math.Pow(x,2) && y >= -1*x && x<= 0 && y <= Math.Sqrt(9 - Math.Pow(x,2)))))
					      {
													Console.WriteLine("Point (" +x+ ";" +y+ ")");
						  }
						
						
				    
				    
				    }
				    
						
						
					
					    
				}
	    }
	}
}
			
