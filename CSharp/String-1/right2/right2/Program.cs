using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.
             * The string length will be at least 2.
             *
             * right2("Hello") → "loHel"
             * right2("java") → "vaja"
             * right2("Hi") → "Hi"
             */
            Console.WriteLine(right2("Hello"));
            Console.WriteLine(right2("java"));
            Console.WriteLine(right2("Hi"));
        }

        private static string right2(string str)
        {
            return (str.Length <= 2) ? str : str.Substring(str.Length - 2) + str.Substring(0, str.Length - 2);
        }
    }
}
