using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobThere
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the given string contains a "bob" string, but where the middle 'o' char can be any char.
             *
             * bobThere("abcbob") → true
             * bobThere("b9b") → true
             * bobThere("bac") → false
             */
            Console.WriteLine(BobThere("abcbob"));
            Console.WriteLine(BobThere("b9b"));
            Console.WriteLine(BobThere("bac"));
        }

        private static bool BobThere(string str)
        {
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str[i] == 'b' && str[i + 2] == 'b') return true;
            }
            return false;
        }
    }
}
