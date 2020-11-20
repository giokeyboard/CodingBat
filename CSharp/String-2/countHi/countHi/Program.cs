using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countHi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return the number of times that the string "hi" appears anywhere in the given string.
             *
             * countHi("abc hi ho") → 1
             * countHi("ABChi hi") → 2
             * countHi("hihi") → 2
             */
            Console.WriteLine(CountHi("abc hi ho"));
            Console.WriteLine(CountHi("ABChi hi"));
            Console.WriteLine(CountHi("hihi"));
        }

        private static int CountHi(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2).Equals("hi")) count++;
            }
            return count;
        }
    }
}
