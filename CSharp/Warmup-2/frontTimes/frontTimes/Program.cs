using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars,
             * or whatever is there if the string is less than length 3. Return n copies of the front;
             *
             * frontTimes("Chocolate", 2) → "ChoCho"
             * frontTimes("Chocolate", 3) → "ChoChoCho"
             * frontTimes("Abc", 3) → "AbcAbcAbc"
             */
            Console.WriteLine(FrontTimes("Chocolate", 2));
            Console.WriteLine(FrontTimes("Chocolate", 3));
            Console.WriteLine(FrontTimes("Abc", 3));
        }

        private static string FrontTimes(string str, int n)
        {
            string front = (str.Length < 3) ? str : str.Substring(0, 3);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(front);
            }
            return sb.ToString();
        }
    }
}
