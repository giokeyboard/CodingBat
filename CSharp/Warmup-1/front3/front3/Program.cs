using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given a string, we'll say that the front is the first 3 chars of the string.
            * If the string length is less than 3, the front is whatever is there.
            * Return a new string which is 3 copies of the front.
            *
            * front3("Java") → "JavJavJav"
            * front3("Chocolate") → "ChoChoCho"
            * front3("abc") → "abcabcabc"
            */
            Console.WriteLine(Front3("Java"));
            Console.WriteLine(Front3("Chocolate"));
            Console.WriteLine(Front3("abc"));
        }

        private static string Front3(string str)
        {
            if (str.Length <= 3) { return str + str + str; }
            return str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);
        }
    }
}
