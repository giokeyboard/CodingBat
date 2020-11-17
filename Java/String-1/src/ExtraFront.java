public class ExtraFront {
    public static void main(String[] args) {
        /*
         * Given a string, return a new string made of 3 copies of the first 2 chars of the original string.
         * The string may be any length. If there are fewer than 2 chars, use whatever is there.
         *
         * extraFront("Hello") → "HeHeHe"
         * extraFront("ab") → "ababab"
         * extraFront("H") → "HHH"
         */
        System.out.println(extraFront("Hello"));
        System.out.println(extraFront("ab"));
        System.out.println(extraFront("H"));
    }

    public static String extraFront(String str) {
        return (str.length() < 3) ? str + str + str : str.substring(0, 2) + str.substring(0, 2) + str.substring(0, 2);
    }
}
