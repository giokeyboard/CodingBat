using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
             *
             * altPairs("kitten") → "kien"
             * altPairs("Chocolate") → "Chole"
             * altPairs("CodingHorror") → "Congrr"
             */
            Console.WriteLine(AltPairs("kitten"));
            Console.WriteLine(AltPairs("Chocolate"));
            Console.WriteLine(AltPairs("CodingHorror"));
        }

        private static string AltPairs(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i+=4)
            {
                sb.Append((i != str.Length - 1) ? str.Substring(i, 2) : str[i].ToString());
            }
            return sb.ToString();
        }
    }
}
