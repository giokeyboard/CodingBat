package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Suppose the string "yak" is unlucky.
         * Given a string, return a version where all the "yak" are removed, but the "a" can be any char.
         * The "yak" strings will not overlap.
         *
         * stringYak("yakpak") → "pak"
         * stringYak("pakyak") → "pak"
         * stringYak("yak123ya") → "123ya"
         */
        System.out.println(stringYak("yakpak"));
        System.out.println(stringYak("pakyak"));
        System.out.println(stringYak("yak123ya"));
    }

    public static String stringYak(String str) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < str.length(); i++) {
            if (i + 2 < str.length() && str.charAt(i) == 'y' && str.charAt(i + 2) == 'k') {
                i += 2;
            } else {
                sb.append(str.charAt(i));
            }
        }

        return sb.toString();
    }
}
