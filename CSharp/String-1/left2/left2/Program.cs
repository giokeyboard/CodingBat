using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace left2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end.
             * The string length will be at least 2.
             *
             * left2("Hello") → "lloHe"
             * left2("java") → "vaja"
             * left2("Hi") → "Hi"
             */
            Console.WriteLine(Left2("Hello"));
            Console.WriteLine(Left2("java"));
            Console.WriteLine(Left2("Hi"));
        }

        private static string Left2(string v)
        {
            return (v.Length <= 2) ? v : v.Substring(2) + v.Substring(0, 2);
        }
    }
}
