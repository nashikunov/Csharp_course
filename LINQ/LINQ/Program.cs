using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static bool IsShortWord(string word)
        {
            return word.Length <= 4;
        }
       
        // c# строго типизирован
        static void Main(string[] args)
        {
            string[] keywords = {"var", "vsaaaar", "class", "struct", "void", "for", "foreach", "static" };

            int i = 10;
            Func<string, bool> func = s => s.StartsWith("v");
            

            Func<string, bool>[] funcs =
            {
                s => s.StartsWith("v"),
                s => s.EndsWith("r")
            };

            var firstWord = keywords.FirstOrDefault(word => funcs.All(f => f(word))); // first word which bla bla

            //Console.WriteLine(firstWord);


            var result = funcs.All(f => f("var")); // для всех методов тру
            


            //Any, All -> bool
            result = keywords.Any(word => word.Length > 4); // если для всех верно true Any хотя бы один All

            Console.WriteLine(result);

            var groups = keywords.GroupBy(word => word[0]);  // новый масств не создаётся!!!
            foreach(var group in groups)
            {
                Console.WriteLine(group.Key);  // key - критерий организации по группам, тут это word[0]
                foreach ( var word in group.OrderBy(w => w))
                {
                    Console.WriteLine(word);
                }
            }

            groups = from word in keywords
                     group word by word[0] into g
                     select g;

            var resultss = keywords.First(word => word[0] == 'f'); // FirstOrDefault if эл нет
            
            // SQL-like
            var shortKeywords = from word in keywords // новой коллекции не создается
                                where word.Length <= 4
                                orderby word.Length, word // 2 сортировки
                                select word;

            // lazy
            // C#-like (extension methods)
            shortKeywords = keywords
                .Where(word => word.Length <= 4)
                .OrderBy(word => word.Length)
                .ThenByDescending(word => word);

            foreach (var word in shortKeywords) 
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();

        }
    }
}
