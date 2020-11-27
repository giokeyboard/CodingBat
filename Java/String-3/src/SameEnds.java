public class SameEnds {
    public static void main(String[] args) {
        /*
         * Given a string, return the longest substring that appears at both the beginning and
         * end of the string without overlapping. For example, sameEnds("abXab") is "ab".
         *
         * sameEnds("abXYab") → "ab"
         * sameEnds("xx") → "x"
         * sameEnds("xxx") → "x"
         */
        System.out.println(sameEnds("abXYab"));
        System.out.println(sameEnds("xx"));
        System.out.println(sameEnds("xxx"));

    }

    public static String sameEnds(String string) {
        int firstEnd = string.length() / 2;
        int secondStart = (string.length() % 2 == 0) ? string.length() / 2 : string.length() / 2 + 1;
        String first = string.substring(0, firstEnd);
        String second = string.substring(secondStart);

        while (!first.equals(second)) {
            first = first.substring(0, first.length() - 1);
            second = second.substring(1);
        }

        return first;
    }
}
