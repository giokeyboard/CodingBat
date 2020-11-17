using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given a string, return true if the first 2 chars in the string also
            * appear at the end of the string, such as with "edited".
            *
            * frontAgain("edited") → true
            * frontAgain("edit") → false
            * frontAgain("ed") → true
            */
            Console.WriteLine(frontAgain("edited"));
            Console.WriteLine(frontAgain("edit"));
            Console.WriteLine(frontAgain("ed"));
        }

        private static bool frontAgain(string v)
        {
            if (v.Length < 2) { return false; }
            return v.Substring(0, 2).Equals(v.Substring(v.Length - 2));
        }
    }
}
