using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seeColor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, if the string begins with "red" or "blue" return that color string,
             * otherwise return the empty string.
             *
             * seeColor("redxx") → "red"
             * seeColor("xxred") → ""
             * seeColor("blueTimes") → "blue"
             */
            Console.WriteLine(seeColor("redxx"));
            Console.WriteLine(seeColor("xxred"));
            Console.WriteLine(seeColor("blueTimes"));
        }

        private static string seeColor(string str)
        {
            if (str.StartsWith("red"))
            {
                return "red";
            }
            else if (str.StartsWith("blue"))
            {
                return "blue";
            }
            return "";
        }
    }
}
