using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleepIn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on vacation.
            We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.

            sleepIn(false, false) → true
            sleepIn(true, false) → false
            sleepIn(false, true) → true
            */
            Console.WriteLine(sleepIn(false, false));
            Console.WriteLine(sleepIn(true, false));
            Console.WriteLine(sleepIn(false, true));
        }

        private static bool sleepIn(bool weekday, bool vacation)
        {
            return !weekday || vacation;
        }
    }
}
