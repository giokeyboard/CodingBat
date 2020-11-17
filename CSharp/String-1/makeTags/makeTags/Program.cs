using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeTags
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text.
             * In this example, the "i" tag makes <i> and </i> which surround the word "Yay".
             * Given tag and word strings, create the HTML string with tags around the word, e.g. "<i>Yay</i>".
             *
             * makeTags("i", "Yay") → "<i>Yay</i>"
             * makeTags("i", "Hello") → "<i>Hello</i>"
             * makeTags("cite", "Yay") → "<cite>Yay</cite>"
             */
            Console.WriteLine(MakeTags("i", "Yay"));
            Console.WriteLine(MakeTags("i", "Hello"));
            Console.WriteLine(MakeTags("cite", "Yay"));
        }

        private static string MakeTags(string tag, string word)
        {
            return $"<{tag}>{word}</{tag}>";
        }
    }
}
