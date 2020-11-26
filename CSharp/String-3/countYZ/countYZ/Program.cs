using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countYZ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, count the number of words ending in 'y' or 'z' -- so the 'y' in "heavy" and the 'z' in "fez" count,
             * but not the 'y' in "yellow" (not case sensitive). We'll say that a y or z is at the end of a word if there is not
             * an alphabetic letter immediately following it.
             * (Note: Character.isLetter(char) tests if a char is an alphabetic letter.)
             *
             * countYZ("fez day") → 2
             * countYZ("day fez") → 2
             * countYZ("day fyyyz") → 2
             */
            Console.WriteLine(CountYZ("fez day"));
            Console.WriteLine(CountYZ("day fez"));
            Console.WriteLine(CountYZ("day fyyyz"));
        }

        private static int CountYZ(string str)
        {
            int count = 0;
            string lower = str.ToLower();
            if (lower[lower.Length - 1] == 'y' || lower[lower.Length - 1] == 'z') count++;
            for (int i = 0; i < lower.Length - 1; i++)
            {
                if (!Char.IsLetter(lower[i + 1]) && (lower[i] == 'y' || lower[i] == 'z'))
                {
                    count++;
                    i++;
                }
            }
            return count;
        }
    }
}
