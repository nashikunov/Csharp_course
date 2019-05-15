using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число");
            int x = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите цифру для поиска");
            int y = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int f = x;
            
            while (f > 0)
            {
                f /= 10;
                ++count1;
            }
            
                int[] array = new int[count1];
            
                    for (int i = 0; i < count1; i++)
				    {		
                        array[i] = x % 10;
                        x = x / 10 ;
                        
                            if (y == array[i])
                            {
							    ++count2;
						    }
						
					} 
						
	      Console.WriteLine("Ваша цифра "+y+ " встретилась в заданном числе "+count2+ " раз.");
	      Console.ReadLine();
      
      }
    
    
    }  


}
