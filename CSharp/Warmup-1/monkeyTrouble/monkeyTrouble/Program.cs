using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monkeyTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * We have two monkeys, a and b, and the parameters aSmile and bSmile indicate if each is smiling.
            * We are in trouble if they are both smiling or if neither of them is smiling. Return true if we are in trouble.
            *
            * monkeyTrouble(true, true) → true
            * monkeyTrouble(false, false) → true
            * monkeyTrouble(true, false) → false
            */
            Console.WriteLine(monkeyTrouble(true, true));
            Console.WriteLine(monkeyTrouble(false, false));
            Console.WriteLine(monkeyTrouble(true, false));
        }

        private static bool monkeyTrouble(bool aSmile, bool bSmile)
        {
            return aSmile == bSmile;
        }
    }
}
