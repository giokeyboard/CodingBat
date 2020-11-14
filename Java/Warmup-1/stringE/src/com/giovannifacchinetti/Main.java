package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Return true if the given string contains between 1 and 3 'e' chars.
         *
         * stringE("Hello") → true
         * stringE("Heelle") → true
         * stringE("Heelele") → false
         */
        System.out.println(stringE("Hello"));
        System.out.println(stringE("Heelle"));
        System.out.println(stringE("Heelele"));
    }

    private static boolean stringE(String str) {
        int count = 0;
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) == 'e') {
                count++;
            }
        }
        return count >= 1 && count <= 3;
    }
}
