using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catDog
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Return true if the string "cat" and "dog" appear the same number of times in the given string.
             *
             * catDog("catdog") → true
             * catDog("catcat") → false
             * catDog("1cat1cadodog") → true
             */
            Console.WriteLine(CatDog("catdog"));
            Console.WriteLine(CatDog("catcat"));
            Console.WriteLine(CatDog("1cat1cadodog"));
        }

        private static bool CatDog(string str)
        {
            int countCat = 0;
            int countDog = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 3).Equals("cat")) countCat++;
                if (str.Substring(i, 3).Equals("dog")) countDog++;
            }
            return countCat == countDog;
        }
    }
}
