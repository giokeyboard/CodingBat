public class CountHi2 {
    public static void main(String[] args) {
        /*
         * Given a string, compute recursively the number of times lowercase "hi" appears in the string,
         * however do not count "hi" that have an 'x' immediately before them.
         *
         * countHi2("ahixhi") → 1
         * countHi2("ahibhi") → 2
         * countHi2("xhixhi") → 0
         */
        System.out.println(countHi2("ahixhi"));
        System.out.println(countHi2("ahibhi"));
        System.out.println(countHi2("xhixhi"));
    }

    public static int countHi2(String str) {
        if (str.length() < 2) return 0;
        if (str.startsWith("xhi")) return countHi2(str.substring(3));
        if (str.startsWith("hi")) return 1 + countHi2(str.substring(2));
        return countHi2(str.substring(1));
    }
}
