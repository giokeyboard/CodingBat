public class MixString {
    public static void main(String[] args) {
        /*
         * Given two strings, a and b, create a bigger string made of the first char of a, the first char of b,
         * the second char of a, the second char of b, and so on. Any leftover chars go at the end of the result.
         *
         * mixString("abc", "xyz") → "axbycz"
         * mixString("Hi", "There") → "HTihere"
         * mixString("xxxx", "There") → "xTxhxexre"
         */
        System.out.println(mixString("abc", "xyz"));
        System.out.println(mixString("Hi", "There"));
        System.out.println(mixString("xxxx", "There"));
    }

    public static String mixString(String a, String b) {
        StringBuilder sb = new StringBuilder();

        int i = 0;
        while (i < a.length() && i < b.length()) {
            sb.append(a.charAt(i));
            sb.append(b.charAt(i));
            i++;
        }
        if (i == a.length()) sb.append(b.substring(i));
        else if (i == b.length()) sb.append(a.substring(i));

        return sb.toString();
    }
}
