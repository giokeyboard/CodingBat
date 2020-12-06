using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapBully
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Modify and return the given map as follows: if the key "a" has a value, set the key "b" to have that value,
             * and set the key "a" to have the value "". Basically "b" is a bully, taking the value and replacing it with
             * the empty string.
             *
             * mapBully({"a": "candy", "b": "dirt"}) → {"a": "", "b": "candy"}
             * mapBully({"a": "candy"}) → {"a": "", "b": "candy"}
             * mapBully({"a": "candy", "b": "carrot", "c": "meh"}) → {"a": "", "b": "candy", "c": "meh"}
             */
            MapBully(new Dictionary<string, string>() {
                { "a", "candy" },
                { "b", "dirt" }
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapBully(new Dictionary<string, string>() {
                {"a", "candy"}
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapBully(new Dictionary<string, string>() {
                {"a", "candy" }, {"b", "carrot" }, {"c", "meh"}
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
        }

        private static Dictionary<string, string> MapBully(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a"))
            {
                map["b"] = map["a"];
                map["a"] = "";
            }
            return map;
        }
    }
}
