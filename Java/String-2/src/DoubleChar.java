public class DoubleChar {
    public static void main(String[] args) {
        /*
         * Given a string, return a string where for every char in the original, there are two chars.
         *
         * doubleChar("The") → "TThhee"
         * doubleChar("AAbb") → "AAAAbbbb"
         * doubleChar("Hi-There") → "HHii--TThheerree"
         */
        System.out.println(doubleChar("The"));
        System.out.println(doubleChar("AAbb"));
        System.out.println(doubleChar("Hi-There"));
    }

    public static String doubleChar(String str) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.length(); i++) {
            sb.append(str.charAt(i) + "" + str.charAt(i));
        }
        return sb.toString();
    }
}
