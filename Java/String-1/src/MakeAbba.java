public class MakeAbba {
    public static void main(String[] args) {
        /*
         * Given two strings, a and b, return the result of putting them together in the order abba,
         * e.g. "Hi" and "Bye" returns "HiByeByeHi".
         *
         * makeAbba("Hi", "Bye") → "HiByeByeHi"
         * makeAbba("Yo", "Alice") → "YoAliceAliceYo"
         * makeAbba("What", "Up") → "WhatUpUpWhat"
         */
        System.out.println(makeAbba("Hi", "Bye"));
        System.out.println(makeAbba("Yo", "Alice"));
        System.out.println(makeAbba("What", "Up"));
    }

    public static String makeAbba(String a, String b) {
        return a + b + b + a;
    }
}
