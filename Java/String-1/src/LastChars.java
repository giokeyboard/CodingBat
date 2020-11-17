public class LastChars {
    public static void main(String[] args) {
        /*
         * Given 2 strings, a and b, return a new string made of the first char of a and the last char of b,
         * so "yo" and "java" yields "ya". If either string is length 0, use '@' for its missing char.
         *
         * lastChars("last", "chars") → "ls"
         * lastChars("yo", "java") → "ya"
         * lastChars("hi", "") → "h@"
         */
        System.out.println(lastChars("last", "chars"));
        System.out.println(lastChars("yo", "java"));
        System.out.println(lastChars("hi", ""));
    }

    public static String lastChars(String a, String b) {
        StringBuilder sb = new StringBuilder();
        sb.append((a.length() == 0) ? '@' : a.charAt(0));
        sb.append((b.length() == 0) ? '@' : b.charAt(b.length() - 1));
        return sb.toString();
    }
}
