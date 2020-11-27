using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, return a string where every appearance of the lowercase word "is" has been replaced with "is not".
             * The word "is" should not be immediately preceded or followed by a letter --
             * so for example the "is" in "this" does not count.
             * (Note: Character.isLetter(char) tests if a char is a letter.)
             *
             * notReplace("is test") → "is not test"
             * notReplace("is-is") → "is not-is not"
             * notReplace("This is right") → "This is not right"
             */
            Console.WriteLine(NotReplace("is test"));
            Console.WriteLine(NotReplace("is-is"));
            Console.WriteLine(NotReplace("This is right"));
            Console.WriteLine(NotReplace("t"));
            Console.WriteLine(NotReplace(""));
            Console.WriteLine(NotReplace("isis"));
        }

        private static string NotReplace(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i).Length > 1 && str.Substring(i, 2).Equals("is"))
                {
                    if ((i == 0 || !Char.IsLetter(str[i - 1])) && (i == str.Length - 2 || !Char.IsLetter(str[i + 2])))
                    {
                        sb.Append("is not");
                        i++;
                        continue;
                    }
                }
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}
