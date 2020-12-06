using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topping3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a map of food keys and topping values, modify and return the map as follows:
             * if the key "potato" has a value, set that as the value for the key "fries".
             * If the key "salad" has a value, set that as the value for the key "spinach".
             *
             * topping3({"potato": "ketchup"}) → {"potato": "ketchup", "fries": "ketchup"}
             * topping3({"potato": "butter"}) → {"potato": "butter", "fries": "butter"}
             * topping3({"salad": "oil", "potato": "ketchup"}) →
             * {"spinach": "oil", "salad": "oil", "potato": "ketchup", "fries": "ketchup"}
             */
            Topping3(new Dictionary<string, string>()
            {
                {"potato", "ketchup"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            Topping3(new Dictionary<string, string>()
            {
                {"potato", "butter"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            Topping3(new Dictionary<string, string>()
            {
                {"salad", "oil" },
                { "potato", "ketchup"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

        }

        private static Dictionary<string, string> Topping3(Dictionary<string, string> map)
        {
            if (map.ContainsKey("potato"))
            {
                map["fries"] = map["potato"];
            }
            if (map.ContainsKey("salad"))
            {
                map["spinach"] = map["salad"];
            }
            return map;
        }
    }
}
