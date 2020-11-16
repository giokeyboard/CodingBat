package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a non-empty string like "Code" return a string like "CCoCodCode".
         *
         * stringSplosion("Code") → "CCoCodCode"
         * stringSplosion("abc") → "aababc"
         * stringSplosion("ab") → "aab"
         */
        System.out.println(stringSplosion("Code"));
        System.out.println(stringSplosion("abc"));
        System.out.println(stringSplosion("ab"));
    }

    public static String stringSplosion(String str) {
        String result = "";
        for (int i = 0; i < str.length() + 1; i++) {
            result += str.substring(0, i);
        }
        return result;
    }
}
