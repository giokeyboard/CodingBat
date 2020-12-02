using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestParen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return true if it is a nesting of zero or more pairs of parenthesis,
             * like "(())" or "((()))".
             * Suggestion: check the first and last chars, and then recur on what's inside them.
             *
             * nestParen("(())") → true
             * nestParen("((()))") → true
             * nestParen("(((x))") → false
             */
            Console.WriteLine(NestParen("(())"));
            Console.WriteLine(NestParen("((()))"));
            Console.WriteLine(NestParen("(((x))"));
        }

        private static bool NestParen(string str)
        {
            if (str.Length == 0) return true;
            if (str[0] == '(' && str[str.Length - 1] == ')') return NestParen(str.Substring(1, str.Length - 2));
            return false;
        }
    }
}
