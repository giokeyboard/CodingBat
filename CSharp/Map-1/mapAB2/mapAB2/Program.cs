using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Modify and return the given map as follows:
             * if the keys "a" and "b" are both in the map and have equal values, remove them both.
             *
             * mapAB2({"a": "aaa", "b": "aaa", "c": "cake"}) → {"c": "cake"}
             * mapAB2({"a": "aaa", "b": "bbb"}) → {"a": "aaa", "b": "bbb"}
             * mapAB2({"a": "aaa", "b": "bbb", "c": "aaa"}) → {"a": "aaa", "b": "bbb", "c": "aaa"}
             */
            MapAB2(new Dictionary<string, string>()
            {
                {"a", "aaa" },
                { "b", "aaa" },
                { "c", "cake"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB2(new Dictionary<string, string>()
            {
                {"a", "aaa" },
                { "b", "bbb"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB2(new Dictionary<string, string>()
            {
                {"a", "aaa" },
                { "b", "bbb" },
                { "c", "aaa"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        static Dictionary<String, String> MapAB2(Dictionary<String, String> map)
        {
            if (map.ContainsKey("a") && map.ContainsKey("b") && map["a"] == map["b"])
            {
                map.Remove("a");
                map.Remove("b");
            }
            return map;
        }
    }
}
