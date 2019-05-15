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
			for (double x = -5; x <= 5; x += 0.2)
			    {
					for (double y = -5; y <= 5; y += 0.2)
					    {
							if (y <= Math.Sqrt(x+4) && y >= Math.Pow(x,3) && y >= -1*Math.Pow(x,3) - 1 && x <= 0 || y >= 0.6*x - 3 && y <= -1*Math.Pow(x,3) - 1 && x>= 0)
							    {
									Console.WriteLine("Точка (" + x +";" + y +")");
								}
								else
								{
								}
						}
									
					
				  
				}
			    
			    Console.ReadLine();
			
			
			
				
			
		
	    }
	}
}
			
