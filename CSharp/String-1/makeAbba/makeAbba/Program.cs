using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeAbba
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given two strings, a and b, return the result of putting them together in the order abba,
             * e.g. "Hi" and "Bye" returns "HiByeByeHi".
             *
             * makeAbba("Hi", "Bye") → "HiByeByeHi"
             * makeAbba("Yo", "Alice") → "YoAliceAliceYo"
             * makeAbba("What", "Up") → "WhatUpUpWhat"
             */
            Console.WriteLine(MakeAbba("Hi", "Bye"));
            Console.WriteLine(MakeAbba("Yo", "Alice"));
            Console.WriteLine(MakeAbba("What", "Up"));
        }

        private static string MakeAbba(string a, string b)
        {
            return a + b + b + a;
        }
    }
}
