public class NonStart {
    public static void main(String[] args) {
        /*
         * Given 2 strings, return their concatenation, except omit the first char of each.
         * The strings will be at least length 1.
         *
         * nonStart("Hello", "There") → "ellohere"
         * nonStart("java", "code") → "avaode"
         * nonStart("shotl", "java") → "hotlava"
         */
        System.out.println(nonStart("Hello", "There"));
        System.out.println(nonStart("java", "code"));
        System.out.println(nonStart("shotl", "java"));
    }

    public static String nonStart(String a, String b) {
        return a.substring(1) + b.substring(1);
    }
}
