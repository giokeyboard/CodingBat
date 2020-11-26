public class WithoutString {
    public static void main(String[] args) {
        /*
         * Given two strings, base and remove, return a version of the base string where all instances of the remove string
         * have been removed (not case sensitive). You may assume that the remove string is length 1 or more.
         * Remove only non-overlapping instances, so with "xxx" removing "xx" leaves "x".
         *
         * withoutString("Hello there", "llo") → "He there"
         * withoutString("Hello there", "e") → "Hllo thr"
         * withoutString("Hello there", "x") → "Hello there"
         */
        System.out.println(withoutString("Hello there", "llo"));
        System.out.println(withoutString("Hello there", "e"));
        System.out.println(withoutString("Hello there", "x"));
    }

    public static String withoutString(String base, String remove) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < base.length(); i++) {
            if (!base.toLowerCase().substring(i).startsWith(remove.toLowerCase()))
                sb.append(base.charAt(i));
            else i += remove.length() - 1;
        }
        return sb.toString();
    }
}
