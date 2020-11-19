using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat,
             * and a boolean indicating if we are on vacation,
             * return a string of the form "7:00" indicating when the alarm clock should ring.
             * Weekdays, the alarm should be "7:00" and on the weekend it should be "10:00".
             * Unless we are on vacation -- then on weekdays it should be "10:00" and weekends it should be "off".
             *
             * alarmClock(1, false) → "7:00"
             * alarmClock(5, false) → "7:00"
             * alarmClock(0, false) → "10:00"
             */
            Console.WriteLine(AlarmClock(1, false));
            Console.WriteLine(AlarmClock(5, false));
            Console.WriteLine(AlarmClock(0, false));
        }

        private static string AlarmClock(int day, bool vacation)
        {
            if (day == 0 || day == 6) { return (vacation) ? "off" : "10:00"; }
            return (vacation) ? "10:00" : "7:00";
        }
    }
}
