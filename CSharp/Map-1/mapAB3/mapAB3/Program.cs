using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Modify and return the given map as follows:
             * if exactly one of the keys "a" or "b" has a value in the map (but not both),
             * set the other to have that same value in the map.
             *
             * mapAB3({"a": "aaa", "c": "cake"}) → {"a": "aaa", "b": "aaa", "c": "cake"}
             * mapAB3({"b": "bbb", "c": "cake"}) → {"a": "bbb", "b": "bbb", "c": "cake"}
             * mapAB3({"a": "aaa", "b": "bbb", "c": "cake"}) → {"a": "aaa", "b": "bbb", "c": "cake"}
             */
            MapAB3(new Dictionary<string, string>()
            {
                {"a", "aaa" },
                { "c", "cake"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB3(new Dictionary<string, string>()
            {
                {"b", "bbb" },
                { "c", "cake"}
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB3(new Dictionary<string, string>()
            {
                {"a", "aaa" },
                { "b", "bbb" },
                { "c", "cake"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        static Dictionary<String, String> MapAB3(Dictionary<String, String> map)
        {
            if (map.ContainsKey("a") && !map.ContainsKey("b")) map["b"] = map["a"];
            if (map.ContainsKey("b") && !map.ContainsKey("a")) map["a"] = map["b"];
            return map;
        }
    }
}
