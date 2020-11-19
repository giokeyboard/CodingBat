using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caughtSpeeding
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are driving a little too fast, and a police officer stops you.
             * Write code to compute the result, encoded as an int value: 0=no ticket, 1=small ticket, 2=big ticket.
             * If speed is 60 or less, the result is 0. If speed is between 61 and 80 inclusive, the result is 1.
             * If speed is 81 or more, the result is 2.
             * Unless it is your birthday -- on that day, your speed can be 5 higher in all cases.
             *
             * caughtSpeeding(60, false) → 0
             * caughtSpeeding(65, false) → 1
             * caughtSpeeding(65, true) → 0
             */
            Console.WriteLine(CaughtSpeeding(60, false));
            Console.WriteLine(CaughtSpeeding(65, false));
            Console.WriteLine(CaughtSpeeding(65, true));
        }

        private static int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (speed <= ((isBirthday) ? 65 : 60)) { return 0; }
            if (speed >= ((isBirthday) ? 66 : 61) && speed <= ((isBirthday) ? 85 : 80)) { return 1; }
            return 2;
        }
    }
}
