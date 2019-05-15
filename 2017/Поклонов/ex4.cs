using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1="око, за";
			
			string[] word;
			
			char[] sep; // массив разделителей
			
			sep = new char[]{' ',','};
			
			s1=s1.Insert(7, " око");
			Console.WriteLine(s1);
			Console.ReadLine();
			
			
			s1=s1.Replace("око", "зуб");
			Console.WriteLine(s1);
			Console.ReadLine();
			
			word=s1.Split(sep);
			    
			    for(int i=0;i<word.Length;i++)
			        Console.Write(" {0,5}",word[i]);
			    Console.ReadLine();
			
			s1=string.Join (">", word);
			Console.WriteLine(s1);
			Console.ReadLine();
		}
	}
}
			
	
			
		
