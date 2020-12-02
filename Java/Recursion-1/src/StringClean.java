public class StringClean {
    public static void main(String[] args) {
        /*
         * Given a string, return recursively a "cleaned" string where adjacent chars that are the same
         * have been reduced to a single char. So "yyzzza" yields "yza".
         *
         * stringClean("yyzzza") → "yza"
         * stringClean("abbbcdd") → "abcd"
         * stringClean("Hello") → "Helo"
         */
        System.out.println(stringClean("yyzzza"));
        System.out.println(stringClean("abbbcdd"));
        System.out.println(stringClean("Hello"));
    }

    public static String stringClean(String str) {
        if (str.length() < 2) return str;
        if (str.charAt(0) != str.charAt(1)) return str.charAt(0) + stringClean(str.substring(1));
        return stringClean(str.substring(1));
    }
}
