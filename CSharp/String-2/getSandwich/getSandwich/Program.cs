using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSandwich
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A sandwich is two pieces of bread with something in between.
             * Return the string that is between the first and last appearance of "bread" in the given string,
             * or return the empty string "" if there are not two pieces of bread.
             *
             * getSandwich("breadjambread") → "jam"
             * getSandwich("xxbreadjambreadyy") → "jam"
             * getSandwich("xxbreadyy") → ""
             */
            Console.WriteLine(GetSandwich("breadjambread"));
            Console.WriteLine(GetSandwich("xxbreadjambreadyy"));
            Console.WriteLine(GetSandwich("xxbreadyy"));
        }

        private static string GetSandwich(string str)
        {
            StringBuilder sb = new StringBuilder();
            if (str.IndexOf("bread") != -1 && str.LastIndexOf("bread") != str.IndexOf("bread"))
            {
                int startIndex = str.IndexOf("bread") + "bread".Length;
                int endIndex = str.LastIndexOf("bread");
                sb.Append(str.Substring(startIndex, endIndex - startIndex));
            }
            return sb.ToString();
        }
    }
}
