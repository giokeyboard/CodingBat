using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerCell
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Your cell phone rings. Return true if you should answer it.
             * Normally you answer, except in the morning you only answer if it is your mom calling.
             * In all cases, if you are asleep, you do not answer.
             *
             * answerCell(false, false, false) → true
             * answerCell(false, false, true) → false
             * answerCell(true, false, false) → false
             */
            Console.WriteLine(AnswerCell(false, false, false));
            Console.WriteLine(AnswerCell(false, false, true));
            Console.WriteLine(AnswerCell(true, false, false));
        }

        private static bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            return !isAsleep && ((isMorning && isMom) || !isMorning);
        }
    }
}
