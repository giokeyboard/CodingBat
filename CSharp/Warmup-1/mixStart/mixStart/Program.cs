using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixStart
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given string begins with "mix",
             *  except the 'm' can be anything, so "pix", "9ix" .. all count.
             *
             * mixStart("mix snacks") → true
             * mixStart("pix snacks") → true
             * mixStart("piz snacks") → false
             */
            Console.WriteLine(MixStart("mix snacks"));
            Console.WriteLine(MixStart("pix snacks"));
            Console.WriteLine(MixStart("piz snacks"));
        }

        private static bool MixStart(string str)
        {
            return (str.Length > 0) && str.Substring(1).StartsWith("ix");
        }
    }
}
