using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, take the first 2 chars and return the string with the 2 chars added at both the front and back,
             *  so "kitten" yields"kikittenki". If the string length is less than 2, use whatever chars are there.
             *
             * front22("kitten") → "kikittenki"
             * front22("Ha") → "HaHaHa"
             * front22("abc") → "ababcab"
             */
            Console.WriteLine(Front22("kitten"));
            Console.WriteLine(Front22("Ha"));
            Console.WriteLine(Front22("abc"));
        }

        private static string Front22(string str)
        {
            return (str.Length < 3) ? str + str + str : str.Substring(0, 2) + str + str.Substring(0, 2);
        }
    }
}
