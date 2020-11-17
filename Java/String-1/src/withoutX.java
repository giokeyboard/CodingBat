public class withoutX {
    public static void main(String[] args) {
        /*
         * Given a string, if the first or last chars are 'x', return the string without those 'x' chars,
         * and otherwise return the string unchanged.
         *
         * withoutX("xHix") → "Hi"
         * withoutX("xHi") → "Hi"
         * withoutX("Hxix") → "Hxi"
         */
        System.out.println(withoutX("xHix"));
        System.out.println(withoutX("xHi"));
        System.out.println(withoutX("Hxix"));
    }

    public static String withoutX(String str) {
        int start = (str.length() > 0 && str.charAt(0) == 'x') ? 1 : 0;
        int end = (str.length() > 1 && str.charAt(str.length() - 1) == 'x') ? str.length() - 1 : str.length();
        return str.substring(start, end);
    }
}
