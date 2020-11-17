public class DeFront {
    public static void main(String[] args) {
        /*
         * Given a string, return a version without the first 2 chars.
         * Except keep the first char if it is 'a' and keep the second char if it is 'b'.
         * The string may be any length. Harder than it looks.
         *
         * deFront("Hello") → "llo"
         * deFront("java") → "va"
         * deFront("away") → "aay"
         */
        System.out.println(deFront("Hello"));
        System.out.println(deFront("java"));
        System.out.println(deFront("away"));
    }

    public static String deFront(String str) {
        StringBuilder sb = new StringBuilder();
        if (str.length() > 0 && str.charAt(0) == 'a') {
            sb.append(str.charAt(0));
        }
        if (str.length() > 1) {
            sb.append((str.charAt(1) == 'b') ? str.substring(1) : str.substring(2));
        }
        return sb.toString();
    }
}
