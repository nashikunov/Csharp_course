using System;
using System.Collections.Generic;

namespace Seminar2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //  memory structure
            // stack heap? что там хранится?
            // stack значимые, структуры
            // heap ссылочные, экз класса

             // в стэке выделяется область под мэином. 
            
            int c;

            SimpleOutFunc(out c);
           


        }

        static void SimpleFunc(int param)
        {
            param = 100;
        }

        static void SimpleRefFunc(ref int param) // при реф как зеркало, т.е b = 100 param = 100
        {
            param = 100;
        }

        static void SimpleOutFunc(out int param)
        {
            param = 100;
        }
    }
}
