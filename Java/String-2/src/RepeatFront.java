public class RepeatFront {
    public static void main(String[] args) {
        /*
         * Given a string and an int n, return a string made of the first n characters of the string,
         * followed by the first n-1 characters of the string, and so on.
         * You may assume that n is between 0 and the length of the string, inclusive (i.e. n >= 0 and n <= str.length()).
         *
         * repeatFront("Chocolate", 4) → "ChocChoChC"
         * repeatFront("Chocolate", 3) → "ChoChC"
         * repeatFront("Ice Cream", 2) → "IcI"
         */
        System.out.println(repeatFront("Chocolate", 4));
        System.out.println(repeatFront("Chocolate", 3));
        System.out.println(repeatFront("Ice Cream", 2));
    }

    public static String repeatFront(String str, int n) {
        StringBuilder sb = new StringBuilder();

        for (int i = n; i > 0; i--) {
            sb.append(str, 0, i);
        }

        return sb.toString();
    }
}
