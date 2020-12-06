using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Modify and return the given map as follows: if the keys "a" and "b" have values that have different lengths,
             * then set "c" to have the longer value.
             * If the values exist and have the same length, change them both to the empty string in the map.
             *
             * mapAB4({"a": "aaa", "b": "bb", "c": "cake"}) → {"a": "aaa", "b": "bb", "c": "aaa"}
             * mapAB4({"a": "aa", "b": "bbb", "c": "cake"}) → {"a": "aa", "b": "bbb", "c": "bbb"}
             * mapAB4({"a": "aa", "b": "bbb"}) → {"a": "aa", "b": "bbb", "c": "bbb"}
             */
            MapAB4(new Dictionary<string, string>()
            {
                { "a", "aaa" },
                { "b", "bb" },
                { "c", "cake"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB4(new Dictionary<string, string>()
            {
                { "a", "aa" },
                { "b", "bbb" },
                { "c", "cake"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapAB4(new Dictionary<string, string>()
            {
                { "a", "aa" },
                { "b", "bbb"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        static Dictionary<String, String> MapAB4(Dictionary<String, String> map)
        {
            if (map.ContainsKey("a") && map.ContainsKey("b"))
            {
                if (map["a"].Length == map["b"].Length)
                {
                    map["a"] = "";
                    map["b"] = "";
                }
                else
                {
                    String longer = (map["a"].Length > map["b"].Length) ? map["a"] : map["b"];
                    map["c"] = longer;
                }
            }
            return map;
        }
    }
}
