using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapShare
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Modify and return the given map as follows: if the key "a" has a value,
             * set the key "b" to have that same value.
             * In all cases remove the key "c", leaving the rest of the map unchanged.
             *
             * mapShare({"a": "aaa", "b": "bbb", "c": "ccc"}) → {"a": "aaa", "b": "aaa"}
             * mapShare({"b": "xyz", "c": "ccc"}) → {"b": "xyz"}
             * mapShare({"a": "aaa", "c": "meh", "d": "hi"}) → {"a": "aaa", "b": "aaa", "d": "hi"}
             */
            MapShare(new Dictionary<string, string>() {
                { "a", "aaa" },
                { "b", "bbb" },
                { "c", "ccc" } })
                .ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapShare(new Dictionary<string, string>() {
                {"b", "xyz" },{ "c", "ccc"} }
                ).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            MapShare(new Dictionary<string, string>() {
                { "a", "aaa" },
                { "c", "meh" },
                { "d", "hi" } })
                .ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        private static Dictionary<string, string> MapShare(Dictionary<string, string> map)
        {
            if (map.ContainsKey("a"))
            {
                map["b"] = map["a"];
            }
            map.Remove("c");
            return map;
        }
    }
}
