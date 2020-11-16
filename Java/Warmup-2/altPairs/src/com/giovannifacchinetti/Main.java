package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
         *
         * altPairs("kitten") → "kien"
         * altPairs("Chocolate") → "Chole"
         * altPairs("CodingHorror") → "Congrr"
         */
        System.out.println(altPairs("kitten"));
        System.out.println(altPairs("Chocolate"));
        System.out.println(altPairs("CodingHorror"));
    }

    public static String altPairs(String str) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.length(); i += 4) {
            sb.append((i != str.length() - 1) ? str.substring(i, i + 2) : str.charAt(i));
        }
        return sb.toString();
    }
}
