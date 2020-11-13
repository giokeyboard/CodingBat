package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a string, return a new string where the first and last chars have been exchanged.
         *
         * frontBack("code") → "eodc"
         * frontBack("a") → "a"
         * frontBack("ab") → "ba"*/
        System.out.println(frontBack("code"));
        System.out.println(frontBack("a"));
        System.out.println(frontBack("ab"));
    }

    public static String frontBack(String str) {
        return (str.length() < 2) ? str : str.charAt(str.length() - 1) + str.substring(1, str.length() - 1) + str.charAt(0);
    }
}
