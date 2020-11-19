using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squirrelPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The squirrels in Palo Alto spend most of the day playing.
             * In particular, they play if the temperature is between 60 and 90 (inclusive).
             * Unless it is summer, then the upper limit is 100 instead of 90.
             * Given an int temperature and a boolean isSummer, return true if the squirrels play and false otherwise.
             *
             * squirrelPlay(70, false) → true
             * squirrelPlay(95, false) → false
             * squirrelPlay(95, true) → true
             */
            Console.WriteLine(SquirrelPlay(70, false));
            Console.WriteLine(SquirrelPlay(95, false));
            Console.WriteLine(SquirrelPlay(95, true));
        }

        private static bool SquirrelPlay(int temp, bool isSummer)
        {
            return temp >= 60 && ((isSummer) ? temp <= 100 : temp <= 90);
        }
    }
}
