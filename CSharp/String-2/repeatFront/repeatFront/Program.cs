using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatFront
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and an int n, return a string made of the first n characters of the string,
             * followed by the first n-1 characters of the string, and so on.
             * You may assume that n is between 0 and the length of the string, inclusive (i.e. n >= 0 and n <= str.length()).
             *
             * repeatFront("Chocolate", 4) → "ChocChoChC"
             * repeatFront("Chocolate", 3) → "ChoChC"
             * repeatFront("Ice Cream", 2) → "IcI"
             */
            Console.WriteLine(RepeatFront("Chocolate", 4));
            Console.WriteLine(RepeatFront("Chocolate", 3));
            Console.WriteLine(RepeatFront("Ice Cream", 2));
        }

        private static string RepeatFront(string str, int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = n; i > 0; i--)
            {
                sb.Append(str.Substring(0, i));
            }

            return sb.ToString();
        }
    }
}
