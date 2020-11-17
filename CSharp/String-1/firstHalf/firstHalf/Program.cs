using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given a string of even length, return the first half. So the string "WooHoo" yields "Woo".
            *
            * firstHalf("WooHoo") → "Woo"
            * firstHalf("HelloThere") → "Hello"
            * firstHalf("abcdef") → "abc"
            */
            Console.WriteLine(FirstHalf("WooHoo"));
            Console.WriteLine(FirstHalf("HelloThere"));
            Console.WriteLine(FirstHalf("abcdef"));
        }

        private static string FirstHalf(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }
}
