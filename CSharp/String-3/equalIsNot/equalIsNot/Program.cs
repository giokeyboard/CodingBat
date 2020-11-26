using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalIsNot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return true if the number of appearances of "is" anywhere in the string is equal to
             * the number of appearances of "not" anywhere in the string (case sensitive).
             *
             * equalIsNot("This is not") → false
             * equalIsNot("This is notnot") → true
             * equalIsNot("noisxxnotyynotxisi") → true
             */
            Console.WriteLine(EqualIsNot("This is not"));
            Console.WriteLine(EqualIsNot("This is notnot"));
            Console.WriteLine(EqualIsNot("noisxxnotyynotxisi"));
        }

        private static bool EqualIsNot(string str)
        {
            int countIs = 0;
            int countNot = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i).StartsWith("is"))
                {
                    countIs++;
                    i += "is".Length - 1;
                }
                if (str.Substring(i).StartsWith("not"))
                {
                    countNot++;
                    i += "not".Length - 1;
                }
            }

            return countIs == countNot;
        }
    }
}
