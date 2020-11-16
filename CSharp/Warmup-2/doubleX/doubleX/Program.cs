using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
            *
            * doubleX("axxbb") → true
            * doubleX("axaxax") → false
            * doubleX("xxxxx") → true
            */
            Console.WriteLine(DoubleX("axxbb"));
            Console.WriteLine(DoubleX("axaxax"));
            Console.WriteLine(DoubleX("xxxxx"));
        }

        private static bool DoubleX(string str)
        {
            int index = str.IndexOf('x');
            if (index == -1) { return false; }

            return str.Substring(index).StartsWith("xx");
        }
    }
}
