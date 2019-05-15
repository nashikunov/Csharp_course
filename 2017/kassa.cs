using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char x;
            int a = 0;
            int b = 0;
            int c = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum = 0;
            int apple = 39;
            int chocolate = 120;
            int sprite = 65;
            int money, change;
            Menu();           
            x = Char.Parse(Console.ReadLine());
            if (x == 'a' || x == 'A')
            {
                Console.Clear();
                Console.WriteLine("Сколько яблок вы хотите приобрести?");
                a = int.Parse(Console.ReadLine());
                sum1 = a * apple;
                Console.Clear();
                Menu(); 
                x = Char.Parse(Console.ReadLine());          
            }
            
            if (x == 'c' || x == 'C')
            {
                Console.Clear();
                Console.WriteLine("Сколько плиток шоколада вы хотите приобрести?");
                b = int.Parse(Console.ReadLine());
                sum2 = b * chocolate;
                Console.Clear();
                Menu();   
                x = Char.Parse(Console.ReadLine());        
            }
            
            if (x == 's' || x == 'S')
            { 
                Console.Clear();
                Console.WriteLine("Сколько бутылок спрайта вы хотите приобрести?");
                c = int.Parse(Console.ReadLine());
                sum3 = c * sprite;
                Console.Clear();
                Menu();
                x = Char.Parse(Console.ReadLine());           
            }
            
            if (x == 'e' || x == 'E')
            { 
                sum = sum1 + sum2 + sum3;
                Console.Clear();
                Console.WriteLine("Particulars"+"\t"+"\t"+ "Qty    Rate    Amount");
                Console.WriteLine("Apple                    "+a+"      "+apple+"       "+sum1);
                Console.WriteLine("Chocolate                "+b+"      "+chocolate+"      "+sum2);
                Console.WriteLine("Sprite                   "+c+"      "+sprite+"       "+sum3);
                Console.WriteLine();                
                Console.WriteLine("Total - "+ sum);
                Console.WriteLine();
                Console.WriteLine("Put yor money");
                money = int.Parse(Console.ReadLine());
                Console.Clear();
                change = money - sum;
                Console.WriteLine("Your change - "+change);
                Console.WriteLine("Thank you! Have a nice day!");
                
            }       
        }
        
        static void Menu()
        {
            int apple = 39;
            int chocolate = 120;
            int sprite = 65;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Apple price - "+apple);
            Console.WriteLine("Chocolate price - "+chocolate);
            Console.WriteLine("Sprite price - "+sprite);
            Console.WriteLine();
            Console.WriteLine("To buy apple push 'A'");
            Console.WriteLine("To buy chocolate push 'C'");
            Console.WriteLine("To buy sprite push 'S'"); 
            Console.WriteLine("To pay push 'E");

        }
    }
}
