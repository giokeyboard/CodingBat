package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a string, return true if the string starts with "hi" and false otherwise.
         *
         * startHi("hi there") → true
         * startHi("hi") → true
         * startHi("hello hi") → false
         */
        System.out.println(startHi("hi there"));
        System.out.println(startHi("hi"));
        System.out.println(startHi("hello hi"));
    }

    public static boolean startHi(String str) {
        return str.startsWith("hi");
    }
}
