public class StrCopies {
    public static void main(String[] args) {
        /*
         * Given a string and a non-empty substring sub,
         * compute recursively if at least n copies of sub appear in the string somewhere, possibly with overlapping.
         * N will be non-negative.
         *
         * strCopies("catcowcat", "cat", 2) → true
         * strCopies("catcowcat", "cow", 2) → false
         * strCopies("catcowcat", "cow", 1) → true
         */
        System.out.println(strCopies("catcowcat", "cat", 2));
        System.out.println(strCopies("catcowcat", "cow", 2));
        System.out.println(strCopies("catcowcat", "cow", 1));
    }

    public static boolean strCopies(String str, String sub, int n) {
        if (n == 0) return true;
        if (str.length() < sub.length()) return n <= 0;
        if (str.startsWith(sub)) return strCopies(str.substring(1), sub, n - 1);
        return strCopies(str.substring(1), sub, n);
    }
}
