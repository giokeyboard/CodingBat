public class LastTwo {
    public static void main(String[] args) {
        /*
         * Given a string of any length, return a new string where the last 2 chars,
         * if present, are swapped, so "coding" yields "codign".
         *
         * lastTwo("coding") → "codign"
         * lastTwo("cat") → "cta"
         * lastTwo("ab") → "ba"
         */
        System.out.println(lastTwo("coding"));
        System.out.println(lastTwo("cat"));
        System.out.println(lastTwo("ab"));
    }

    public static String lastTwo(String str) {
        return str.length() < 2 ? str : str.substring(0, str.length() - 2) + str.charAt(str.length() - 1) + str.charAt(str.length() - 2);
    }
}
