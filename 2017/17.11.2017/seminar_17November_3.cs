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
			
			bool repeat = true;
			Random rand = new Random();
			while (repeat)
			{
				Console.Clear();
				Console.WriteLine("ESC to exit");
				Console.WriteLine(rand.Next());
				
				if (Console.ReadKey().Key == ConsoleKey.Escape) // любая клавиша сравнимая с эск
				{
					repeat = false;
				}
			}
		
	    }
	}
}
			
