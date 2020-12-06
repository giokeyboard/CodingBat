using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapAB
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Modify and return the given map as follows: for this problem the map may or may not contain the
             * "a" and "b" keys. If both keys are present, append their 2 string values together and store the result
             * under the key "ab".
             *
             * mapAB({"a": "Hi", "b": "There"}) → {"a": "Hi", "ab": "HiThere", "b": "There"}
             * mapAB({"a": "Hi"}) → {"a": "Hi"}
             * mapAB({"b": "There"}) → {"b": "There"}
             */
            MapAB(new Dictionary<string, string>() {
                { "a", "Hi" },
                { "b", "There" },
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB(new Dictionary<string, string>() {
                {"a", "Hi"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB(new Dictionary<string, string>() {
                {"b", "There"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        private static Dictionary<string, string> MapAB(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a") && map.ContainsKey("b"))
            {
                map["ab"] = map["a"] + map["b"];
            }
            return map;
        }
    }
}
