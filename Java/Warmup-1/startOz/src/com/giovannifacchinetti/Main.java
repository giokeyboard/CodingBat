package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a string, return a string made of the first 2 chars (if present),
         * however include first char only if it is 'o' and include the second only if it is 'z',
         * so "ozymandias" yields "oz".
         *
         * startOz("ozymandias") → "oz"
         * startOz("bzoo") → "z"
         * startOz("oxx") → "o"
         */
        System.out.println(startOz("ozymandias"));
        System.out.println(startOz("bzoo"));
        System.out.println(startOz("oxx"));
    }

    public static String startOz(String str) {
        String result = "";
        if (str.length() > 0 && str.charAt(0) == 'o') {
            result += str.charAt(0);
        }
        if (str.length() > 1 && str.charAt(1) == 'z') {
            result += str.charAt(1);
        }
        return result;
    }

}
