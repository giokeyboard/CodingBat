package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a string, return a version where all the "x" have been removed.
         * Except an "x" at the very start or end should not be removed.
         *
         * stringX("xxHxix") → "xHix"
         * stringX("abxxxcd") → "abcd"
         * stringX("xabxxxcdx") → "xabcdx"
         */
        System.out.println(stringX("xxHxix"));
        System.out.println(stringX("abxxxcd"));
        System.out.println(stringX("xabxxxcdx"));
    }

    public static String stringX(String str) {
        if (str.length() <= 2) {
            return str;
        }
        StringBuilder sb = new StringBuilder();
        sb.append(str.charAt(0));
        for (int i = 1; i < str.length() - 1; i++) {
            if (str.charAt(i) != 'x') {
                sb.append(str.charAt(i));
            }
        }
        sb.append(str.charAt(str.length() - 1));
        return sb.toString();
    }

}
