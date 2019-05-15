using PrimeFinder.Core;
using System;
using System.Threading.Tasks;

namespace PrimeFinder.ConsoleUI
{
	class Program
    {
		static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

			// Find nth prime here

			var locator = new PrimeLocator();

            //locator.FillNPrimes(n);

            var task = Task.Factory.StartNew(locator.FillNPrimes, n);

            while (!task.IsCompleted || locator.Primes.Count > 0)
            {
                //Console.WriteLine("Computing...");
                //Task.Delay(500).Wait();
                if (locator.Primes.TryDequeue(out int number))
                    Console.WriteLine(number);
                //if (locator.Primes.Count > 0)
                //{
                //    Console.WriteLine(locator.Primes[0]);
                //    lock (locator.Lock)
                //    {
                //        locator.Primes.RemoveAt(0);
                //    }
                //    //locator.Primes.RemoveAt(0);
                //}
            }
			//Console.WriteLine(task.Result); //block            

            Console.ReadKey();
        }
    }
}
