using System;

namespace MyProject
{
    class Program
    {
     public static void   Main()
        {
            double x, y;

            Console.WriteLine("Введите значние координаты Х");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значние координаты Y");
            y = double.Parse(Console.ReadLine());

            if ((x * x + y * y <= 4.0 && x <= 0) || (x * x + y * y <= 4.0 && y >= x && x > 0))
                Console.WriteLine("Точка с координатами (" + x.ToString() + ";" + y.ToString() + ") принадлежит заданной области");
                else
                Console.WriteLine("Точка с координатами (" + x.ToString() + ";" + y.ToString() + ") не принадлежит заданной области");
           
         Console.ReadLine();

        }
    }
}