package com.giovannifacchinetti;

public class Main {

    public static void main(String[] args) {
        /*
         * Return true if the given string begins with "mix",
         *  except the 'm' can be anything, so "pix", "9ix" .. all count.
         *
         * mixStart("mix snacks") → true
         * mixStart("pix snacks") → true
         * mixStart("piz snacks") → false
         */
        System.out.println(mixStart("mix snacks"));
        System.out.println(mixStart("pix snacks"));
        System.out.println(mixStart("piz snacks"));
    }

    public static boolean mixStart(String str) {
        return str.length() > 0 && str.substring(1).startsWith("ix");
    }
}
