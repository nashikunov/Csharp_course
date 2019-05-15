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

            int a = 0; // мы задаём сначала типа парметр кол-во. мы дальше к нему будем прибавлять 1 каждый раз, чтобы найти кол-во цифр всего
            int z ; // последняя цифра
            int f = x; // ф вводим для while
            
            while (f > 0)
            {
                f /= 10; // этой функцией мы фактически убираем одну цифру справа
                ++a; // мы прибавляем +1 к count. типа после первого раза у нас длина числа 1, потом больше и больше, ну типа цикл
            }
                                       
                    for (int i = 0; i < a; i++) // шапка цикла. всё работает до кол-ва цифр 
				    {		
                        
                        z = x % 10; // эта функция именно для последней цифры
                        
                        x = x / 10 ; // тут отбрасываем эту последнюю цифру
                        
                        Console.Write(z); //просто выводим
                        
                            
						
					} 
							      
	      Console.ReadLine();
      
      }
    
    
    }  


}

