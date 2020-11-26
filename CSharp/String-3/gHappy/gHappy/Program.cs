using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gHappy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * We'll say that a lowercase 'g' in a string is "happy" if there is another 'g' immediately to its left or right.
             * Return true if all the g's in the given string are happy.
             *
             * gHappy("xxggxx") → true
             * gHappy("xxgxx") → false
             * gHappy("xxggyygxx") → false
             */
            Console.WriteLine(GHappy("xxggxx"));
            Console.WriteLine(GHappy("xxgxx"));
            Console.WriteLine(GHappy("xxggyygxx"));
        }

        private static bool GHappy(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'g')
                {
                    if ((i > 0 && str[i - 1] == str[i]) || (i < str.Length - 1 && str[i + 1] == str[i])) continue;
                    else return false;
                }
            }

            return true;
        }
    }
}
