using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower = int.Parse(Console.ReadLine());
            int higher = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] array1 = new int[n, n];          
            array1 = Generic(lower, higher, n);
            Print(array1);

            int lower1 = int.Parse(Console.ReadLine());
            int higher1 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            lower = lower1;
            higher = higher1;
            n = n1;
            int[,] array2 = new int[n, n];
            array2 = Generic(lower, higher, n);
            Print(array2);

            int[,] array3 = new int[array1.GetLength(0), (array1.GetLength(1) + array2.GetLength(1))];
            array3 = Perestanovka(array1, array2);

            Print(array3);


            Console.ReadLine();

        }
        
      
        static int[,] Generic(int lower, int higher, int n)
        {
            int[,] array = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    array[i, j] = rand.Next(lower, higher);                               
                }                
                
            }
            return array;
        }

        static int[,] Perestanovka(int[,] array1, int[,] array2)
        {
            int[,] array = new int[array1.GetLength(0), (array1.GetLength(1) + array2.GetLength(1))];
            if ((array1.GetLength(0) == array2.GetLength(0)) & (array1.GetLength(1) == array2.GetLength(1)))
            {               
                for (int k = 0; k < array1.GetLength(0); ++k )
                {
                    for (int m = 0; m < array1.GetLength(1) + array2.GetLength(1); ++m)
                    {
                        if (m % 2 != 0)
                        {
                            if (m- array2.GetLength(1) <= 0)
                            {
                                array[k, m] = array2[k, m];
                            }
                            else
                            {
                                array[k, m] = array2[k, m - array2.GetLength(1)];
                            }
                        }
                        else
                        {
                            if (m - array1.GetLength(1) <= 0)
                            {
                                array[k, m] = array1[k, m];
                            }
                            else
                            {
                                array[k, m] = array1[k, m - array1.GetLength(1)];
                            }

                        }

                    }
                }

            }
            else
            {               
                array = null;
            }
            return array;
        }

        static int[,] Print(int[,] array)
        {
            int[,] array3 = new int[array.GetLength(0), array.GetLength(1)];
            for (int n = 0; n < array.GetLength(0); ++n)
            {
                for (int l = 0; l < array.GetLength(1); ++l)
                {
                    array3[n, l] = array[n, l];
                    Console.Write(array3[n, l] + "\t");
                }
                Console.WriteLine();
            }
            return array3;
        }
    }
}
