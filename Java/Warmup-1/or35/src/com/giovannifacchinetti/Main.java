package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Return true if the given non-negative number is a multiple of 3 or a multiple of 5.
         *  Use the % "mod" operator -- see Introduction to Mod
         *
         * or35(3) → true
         * or35(10) → true
         * or35(8) → false
         */
        System.out.println(or35(3));
        System.out.println(or35(10));
        System.out.println(or35(8));
    }

    public static boolean or35(int n) {
        return n % 3 == 0 || n % 5 == 0;
    }
}
