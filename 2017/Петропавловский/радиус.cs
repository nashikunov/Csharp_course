using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности.");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Нажмите X для длины окружности" +
                              "Нажмите Y для площади окружности");
            if (Console.ReadKey().Key == ConsoleKey.X)
            {
                Console.WriteLine("L = " + 2 * Math.PI * r);
            }
            else
            {
                if (Console.ReadKey().Key == ConsoleKey.Y) 
                {
                    Console.WriteLine("S = "+ Math.PI*Math.Pow(r,2));
                }
                else
                {
                    Console.WriteLine("Введена неверная кнопка.");
                }
            }


            
                
            
            
        }
    }
}
