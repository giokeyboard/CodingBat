using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given string contains between 1 and 3 'e' chars.
             *
             * stringE("Hello") → true
             * stringE("Heelle") → true
             * stringE("Heelele") → false
             */
            Console.WriteLine(StringE("Hello"));
            Console.WriteLine(StringE("Heelle"));
            Console.WriteLine(StringE("Heelele"));
        }

        private static bool StringE(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e') { count++; }
            }

            return count >= 1 && count <= 3;
        }
    }
}
