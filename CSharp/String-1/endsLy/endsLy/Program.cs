using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace endsLy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return true if it ends in "ly".
             *
             * endsLy("oddly") → true
             * endsLy("y") → false
             * endsLy("oddy") → false
             */
            Console.WriteLine(EndsLy("oddly"));
            Console.WriteLine(EndsLy("y"));
            Console.WriteLine(EndsLy("oddy"));
        }

        private static bool EndsLy(string str)
        {
            return str.EndsWith("ly");
        }
    }
}
