using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace PrimeFinder.Core
{
	public class PrimeLocator
	{	
		private bool IsPrime(int number)
		{
			if (number <= 1)
				return false;
			if (number < 3)
				return true;
			if (number % 2 == 0)
				return false;
			int divisor = 3;
			int upper = (int)Math.Sqrt(number);
			while (divisor <= upper && number % divisor != 0)
				divisor += 2;
			return divisor > upper;
		}

        // list is not thread safety

            // concurrent does

        //public List<int> Primes { get; set; } = new List<int>();
        public object Lock { get; set; } = new object();
        public ConcurrentQueue<int> Primes { get; set; } = new ConcurrentQueue<int>();

        public void FillNPrimes(object n)
        {
            int cnt = 0;
            int currNumber = 0;
            //Primes = new List<int>();
            while (cnt < (int)n)
            {
                currNumber++;
                if (IsPrime(currNumber))
                {
                    
                    cnt++;
                    Console.WriteLine($"Adding {currNumber}");
                    Primes.Enqueue(currNumber);
                    //lock (Lock)
                    //{
                    //    Primes.Add(currNumber);
                    //}
                }
                
            }
        }

        //public event Action<int> OnResultReady;

        public int GetNthPrime(object n)
		{
			int cnt = 0;
			int currNumber = 0;
			while (cnt < (int)n)
			{
				currNumber++;
				if (IsPrime(currNumber))
					cnt++;
              
			}
            //OnResultReady?.Invoke(currNumber);
			return currNumber;
		}
	}
}
