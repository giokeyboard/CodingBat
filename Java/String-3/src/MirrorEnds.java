public class MirrorEnds {
    public static void main(String[] args) {
        /*
         * Given a string, look for a mirror image (backwards) string at both the beginning and end of the given string.
         * In other words, zero or more characters at the very beginning of the given string, and at the very end of the
         * string in reverse order (possibly overlapping). For example, the string "abXYZba" has the mirror end "ab".
         *
         * mirrorEnds("abXYZba") → "ab"
         * mirrorEnds("abca") → "a"
         * mirrorEnds("aba") → "aba"
         */
        System.out.println(mirrorEnds("abXYZba"));
        System.out.println(mirrorEnds("abca"));
        System.out.println(mirrorEnds("aba"));
    }

    public static String mirrorEnds(String string) {
        StringBuilder sb = new StringBuilder(string);
        String reversed = sb.reverse().toString();

        while (!string.equals(reversed)) {
            string = string.substring(0, string.length() - 1);
            reversed = reversed.substring(0, reversed.length() - 1);
        }

        return string;
    }
}
