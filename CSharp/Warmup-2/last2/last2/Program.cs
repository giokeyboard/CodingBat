using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given a string, return the count of the number of times that a substring length 2 appears in the string
            * and also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
            *
            * last2("hixxhi") → 1
            * last2("xaxxaxaxx") → 1
            * last2("axxxaaxx") → 2
            */
            Console.WriteLine(Last2("hixxhi"));
            Console.WriteLine(Last2("xaxxaxaxx"));
            Console.WriteLine(Last2("axxxaaxx"));
        }

        private static int Last2(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length-2; i++)
            {
                if(str.Substring(i,2).Equals(str.Substring(str.Length-2))) { count++; };
            }
            return count;
        }
    }
}
