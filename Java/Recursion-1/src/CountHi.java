public class CountHi {
    public static void main(String[] args) {
        /*
         * Given a string, compute recursively (no loops) the number of times lowercase "hi" appears in the string.
         *
         * countHi("xxhixx") → 1
         * countHi("xhixhix") → 2
         * countHi("hi") → 1
         */
        System.out.println(countHi("xxhixx"));
        System.out.println(countHi("xhixhix"));
        System.out.println(countHi("hi"));
    }

    public static int countHi(String str) {
        if (str.length() < 2) return 0;
        if (str.startsWith("hi")) return 1 + countHi(str.substring(1));
        return countHi(str.substring(1));
    }
}
