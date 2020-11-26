public class CountTriple {
    public static void main(String[] args) {
        /*
         * We'll say that a "triple" in a string is a char appearing three times in a row.
         * Return the number of triples in the given string. The triples may overlap.
         *
         * countTriple("abcXXXabc") → 1
         * countTriple("xxxabyyyycd") → 3
         * countTriple("a") → 0
         */
        System.out.println(countTriple("abcXXXabc"));
        System.out.println(countTriple("xxxabyyyycd"));
        System.out.println(countTriple("a"));
    }

    public static int countTriple(String str) {
        int countTriple = 0;
        for (int i = 0; i < str.length() - 2; i++) {
            if (str.charAt(i) == str.charAt(i + 1) && str.charAt(i + 1) == str.charAt(i + 2)) countTriple++;
        }
        return countTriple;
    }
}
