using System; 

namespace ДЗ_Фибоначи 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            int sum;
            sum = 0;
            Console.WriteLine("Введите колличество чисел последовательности Фибоначи"); 

            uint n = uint.Parse(Console.ReadLine()); 

            int[] Posl = new int[n]; 
            Posl[0] = 1; 
            Posl[1] = 1; 
            Console.Write("1, 1, ");

                for (int i = 2; i < n; i++) 
                { 
                    Posl[i] = Posl[i - 1] + Posl[i - 2]; 
                    Console.Write(Posl[i] + ", "); 
                        if (Posl[i] == Posl[n-1])
                        {
							Console.Write(Posl[i]+ ".");
						}
						
                }
				Console.WriteLine("");
				Console.WriteLine("Сc какого числа вывести сумму чисел?");
				int k = int.Parse(Console.ReadLine());
				
				for (int m = k - 1; m < n; m++)
				    {
						sum = sum + Posl[m];
					}
					
					Console.WriteLine("Сумма чисел от "+ k +"-ого эллемента до "+ n+"-ого эллемента равна - "+ sum);
					Console.ReadLine();
					                           
        } 
    } 
}
