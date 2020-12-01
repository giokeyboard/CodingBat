using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeXY
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a string, compute recursively (no loops) a new string where all the
             * lowercase 'x' chars have been changed to 'y' chars.
             *
             * changeXY("codex") → "codey"
             * changeXY("xxhixx") → "yyhiyy"
             * changeXY("xhixhix") → "yhiyhiy"
             */
            Console.WriteLine(ChangeXY("codex"));
            Console.WriteLine(ChangeXY("xxhixx"));
            Console.WriteLine(ChangeXY("xhixhix"));
        }

        private static string ChangeXY(string str)
        {
            if (str.Length == 0) return "";
            if (str[0] == 'x') return 'y' + ChangeXY(str.Substring(1));
            return str[0] + ChangeXY(str.Substring(1));
        }
    }
}
