using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topping1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a map of food keys and topping values, modify and return the map as follows:
             * if the key "ice cream" is present, set its value to "cherry".
             * In all cases, set the key "bread" to have the value "butter".
             *
             * topping1({"ice cream": "peanuts"}) → {"bread": "butter", "ice cream": "cherry"}
             * topping1({}) → {"bread": "butter"}
             * topping1({"pancake": "syrup"}) → {"bread": "butter", "pancake": "syrup"}
             */
            Topping1(new Dictionary<string, string>()
            {
                {"ice cream", "peanuts"},
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            Topping1(new Dictionary<string, string>()
            {
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();

            Topping1(new Dictionary<string, string>()
            {
               {"pancake", "syrup"}
            }).ToList().ForEach(x => Console.WriteLine($"{x.Key},{x.Value}"));
            Console.WriteLine();
        }

        private static Dictionary<string, string> Topping1(Dictionary<string, string> map)
        {
            if (map.ContainsKey("ice cream"))
            {
                map["ice cream"] = "cherry";
            }
            map["bread"] = "butter";
            return map;
        }
    }
}
