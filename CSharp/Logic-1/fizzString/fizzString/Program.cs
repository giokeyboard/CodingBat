using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string str, if the string starts with "f" return "Fizz".
             * If the string ends with "b" return "Buzz". If both the "f" and "b" conditions are true, return "FizzBuzz".
             * In all other cases, return the string unchanged. (See also: FizzBuzz Code)
             *
             * fizzString("fig") → "Fizz"
             * fizzString("dib") → "Buzz"
             * fizzString("fib") → "FizzBuzz"
             */
            Console.WriteLine(fizzString("fig"));
            Console.WriteLine(fizzString("dib"));
            Console.WriteLine(fizzString("fib"));
        }

        private static string fizzString(string str)
        {
            if (str.StartsWith("f") && str.EndsWith("b")) { return "FizzBuzz"; }
            if (str.StartsWith("f")) { return "Fizz"; }
            if (str.EndsWith("b")) { return "Buzz"; }
            return str;
        }
    }
}
