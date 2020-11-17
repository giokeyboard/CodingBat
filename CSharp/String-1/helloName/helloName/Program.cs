using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloName
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!".
             *
             * helloName("Bob") → "Hello Bob!"
             * helloName("Alice") → "Hello Alice!"
             * helloName("X") → "Hello X!"
             */
            Console.WriteLine(HelloName("Bob"));
            Console.WriteLine(HelloName("Alice"));
            Console.WriteLine(HelloName("X"));
        }

        private static string HelloName(string name)
        {
            return $"Hello {name}!";
        }
    }
}
