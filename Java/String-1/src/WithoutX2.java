public class WithoutX2 {
    public static void main(String[] args) {
        /*
         * Given a string, if one or both of the first 2 chars is 'x',
         * return the string without those 'x' chars, and otherwise return the string unchanged.
         * This is a little harder than it looks.
         *
         * withoutX2("xHi") → "Hi"
         * withoutX2("Hxi") → "Hi"
         * withoutX2("Hi") → "Hi"
         */
        System.out.println(withoutX2("xHi"));
        System.out.println(withoutX2("Hxi"));
        System.out.println(withoutX2("Hi"));
    }

    public static String withoutX2(String str) {
        StringBuilder sb = new StringBuilder();

        if (str.length() > 0 && str.charAt(0) != 'x') {
            sb.append(str.charAt(0));
        }
        if (str.length() > 1 && str.charAt(1) != 'x') {
            sb.append(str.charAt(1));
        }
        if (str.length() > 2) {
            sb.append(str.substring(2));
        }

        return sb.toString();
    }


}

