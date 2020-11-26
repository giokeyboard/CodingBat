public class EqualIsNot {
    public static void main(String[] args) {
        /*
         * Given a string, return true if the number of appearances of "is" anywhere in the string is equal to
         * the number of appearances of "not" anywhere in the string (case sensitive).
         *
         * equalIsNot("This is not") → false
         * equalIsNot("This is notnot") → true
         * equalIsNot("noisxxnotyynotxisi") → true
         */
        System.out.println(equalIsNot("This is not"));
        System.out.println(equalIsNot("This is notnot"));
        System.out.println(equalIsNot("noisxxnotyynotxisi"));
    }

    public static boolean equalIsNot(String str) {
        int countIs = 0;
        int countNot = 0;

        for (int i = 0; i < str.length(); i++) {
            if (str.substring(i).startsWith("is")) {
                countIs++;
                i += "is".length() - 1;
            }
            if (str.substring(i).startsWith("not")) {
                countNot++;
                i += "not".length() - 1;
            }
        }

        return countIs == countNot;
    }
}
