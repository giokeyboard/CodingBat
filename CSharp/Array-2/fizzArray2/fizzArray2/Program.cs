using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a number n, create and return a new string array of length n,
             * containing the strings "0", "1" "2" .. through n-1. N may be 0, in which case just return a length 0 array.
             * Note: String.valueOf(xxx) will make the String form of most types.
             * The syntax to make a new string array is: new String[desired_length]
             * (See also: FizzBuzz Code)
             *
             * fizzArray2(4) → ["0", "1", "2", "3"]
             * fizzArray2(10) → ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
             * fizzArray2(2) → ["0", "1"]
             */
            Console.WriteLine($"[{String.Join(",", FizzArray2(4))}]");
            Console.WriteLine($"[{String.Join(",", FizzArray2(10))}]");
            Console.WriteLine($"[{String.Join(",", FizzArray2(2))}]");
        }

        private static string[] FizzArray2(int n)
        {
            string[] strings = new string[n];
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = Convert.ToString(i);
            }
            return strings;
        }
    }
}
