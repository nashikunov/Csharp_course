using System;

namespace Дз_Петропавловский
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            
            Console.WriteLine("Введите номер первой аудитории");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите номер второй аудитории");
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите номер третьей аудитории");
            int c = int.Parse(Console.ReadLine());

            A = a % 100;
            B = b % 100;
            C = c % 100;

            if (A >= B && A >= C)
            {
                Console.WriteLine("Аудитория № "+ a+ "имеет максимальный номер на этаже.");
            }
            else
            {
                if (B >= A && B >= C)
                {
                    Console.WriteLine("Аудитория № "+ b+ "имеет максимальный номер на этаже.");
                }
                else
                {
                    Console.WriteLine("Аудитория № "+ c+ "имеет максимальный номер на этаже.");
                }
            }

            Console.ReadLine();
        }
    }
}

