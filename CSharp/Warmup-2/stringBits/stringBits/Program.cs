using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
             *
             * stringBits("Hello") → "Hlo"
             * stringBits("Hi") → "H"
             * stringBits("Heeololeo") → "Hello"
             */
            Console.WriteLine(StringBits("Hello"));
            Console.WriteLine(StringBits("Hi"));
            Console.WriteLine(StringBits("Heeololeo"));
        }

        private static string StringBits(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i += 2)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
