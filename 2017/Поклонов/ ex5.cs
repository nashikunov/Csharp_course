using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Start
{ 
    class Program
    {
  static void Main(string[] args)
  
  {
    Console.Title = "Таблица"; 
    Console.Clear();
    Console.WriteLine("Число  Корень");
    for (doule i = 0; i <= 10; i++)
    
    {
     Console.WriteLine ("{0,4} {1,8:F4}", i, Math.Sqrt(i));
    }
    
    Console.ReadKey();
    
  }
 }
}