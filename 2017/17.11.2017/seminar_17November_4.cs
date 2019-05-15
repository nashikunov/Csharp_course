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
			double avg = 0;
			Random rand = new Random();
			
			Console.WriteLine("Сколько чисел нужно");
			    int x = int.Parse(Console.ReadLine());
			for (int i = 0; i < x; i++)
			{
				int r = rand.Next(1,11);
				Console.WriteLine(r);
				avg += r;
			}
			Console.WriteLine(avg / x);
			Console.ReadLine();
		
			
				
			
		
	    }
	}
}
			
