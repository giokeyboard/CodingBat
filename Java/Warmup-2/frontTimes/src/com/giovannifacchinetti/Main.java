package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars,
         * or whatever is there if the string is less than length 3. Return n copies of the front;
         *
         * frontTimes("Chocolate", 2) → "ChoCho"
         * frontTimes("Chocolate", 3) → "ChoChoCho"
         * frontTimes("Abc", 3) → "AbcAbcAbc"
         */
        System.out.println(frontTimes("Chocolate", 2));
        System.out.println(frontTimes("Chocolate", 3));
        System.out.println(frontTimes("Abc", 3));
    }

    public static String frontTimes(String str, int n) {
        String front = (str.length() < 3) ? str : str.substring(0, 3);
        String result = "";
        for (int i = 0; i < n; i++) {
            result += front;
        }
        return result;
    }
}
