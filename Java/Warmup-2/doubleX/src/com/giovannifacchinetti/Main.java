package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         *
         * doubleX("axxbb") → true
         * doubleX("axaxax") → false
         * doubleX("xxxxx") → true
         */
        System.out.println(doubleX("axxbb"));
        System.out.println(doubleX("axaxax"));
        System.out.println(doubleX("xxxxx"));
    }

    public static boolean doubleX(String str) {
        return (str.indexOf('x') >= 0 && str.length() > str.indexOf('x') + 1 &&
                str.charAt(str.indexOf('x') + 1) == 'x');

        /* Alternative solution
        int i = str.indexOf("x");
        if (i == -1) return false; // no "x" at all
        String x = str.substring(i);
        return x.startsWith("xx");
        */
    }
}
