public class CountAbc {
    public static void main(String[] args) {
        /*
         * Count recursively the total number of "abc" and "aba" substrings that appear in the given string.
         *
         * countAbc("abc") → 1
         * countAbc("abcxxabc") → 2
         * countAbc("abaxxaba") → 2
         */
        System.out.println(countAbc("abc"));
        System.out.println(countAbc("abcxxabc"));
        System.out.println(countAbc("abaxxaba"));
    }

    public static int countAbc(String str) {
        if (str.length() < 3) return 0;
        if (str.startsWith("abc") || str.startsWith("aba")) return 1 + countAbc(str.substring(1));
        return countAbc(str.substring(1));
    }
}
