using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startHi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return true if the string starts with "hi" and false otherwise.
             *
             * startHi("hi there") → true
             * startHi("hi") → true
             * startHi("hello hi") → false
             */
            Console.WriteLine(StartHi("hi there"));
            Console.WriteLine(StartHi("hi"));
            Console.WriteLine(StartHi("hello hi"));
        }

        private static bool StartHi(string str)
        {
            return str.StartsWith("hi");
        }
    }
}
