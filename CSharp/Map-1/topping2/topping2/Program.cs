using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topping2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a map of food keys and their topping values, modify and return the map as follows:
             * if the key "ice cream" has a value, set that as the value for the key "yogurt" also.
             * If the key "spinach" has a value, change that value to "nuts".
             *
             * topping2({"ice cream": "cherry"}) → {"yogurt": "cherry", "ice cream": "cherry"}
             * topping2({"spinach": "dirt", "ice cream": "cherry"}) → {"yogurt": "cherry", "spinach": "nuts", "ice cream": "cherry"}
             * topping2({"yogurt": "salt"}) → {"yogurt": "salt"}
             */
            Topping2(new Dictionary<string, string>()
            {
                {"ice cream", "cherry"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            Topping2(new Dictionary<string, string>()
            {
                {"spinach", "dirt" },
                { "ice cream", "cherry"}
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            Topping2(new Dictionary<string, string>()
            {
                {"yogurt", "salt"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        private static Dictionary<string, string> Topping2(Dictionary<string, string> map)
        {
            if (map.ContainsKey("ice cream"))
            {
                map["yogurt"] = map["ice cream"];
            }
            if (map.ContainsKey("spinach"))
            {
                map["spinach"] = "nuts";
            }
            return map;
        }
    }
}
