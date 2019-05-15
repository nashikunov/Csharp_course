using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, i, n;

            char rep = 'Y';

            do
            {
                Random ran = new Random();
                n=10;
                i=0;
                sum = 0;

                do
                {
                     i = ran.Next(-100,101);
                     Console.WriteLine(i.ToString());
                     sum = sum + i; // sum+=i;
                     n++;

                }while(n<10);

                 Console.WriteLine("Сумма сгенеренрованных чисел равна: " + sum.ToString());


                Console.WriteLine("Повторить программу? Y/N");

            rep=char.Parse(Console.ReadLine());

            } while (rep == 'Y' || rep == 'y');
        }
    }
}
