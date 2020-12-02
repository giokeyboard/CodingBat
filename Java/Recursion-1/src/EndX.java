public class EndX {
    public static void main(String[] args) {
        /*
         * Given a string, compute recursively a new string where all the lowercase 'x' chars
         * have been moved to the end of the string.
         *
         * endX("xxre") → "rexx"
         * endX("xxhixx") → "hixxxx"
         * endX("xhixhix") → "hihixxx"
         */
        System.out.println(endX("xxre"));
        System.out.println(endX("xxhixx"));
        System.out.println(endX("xhixhix"));
    }

    public static String endX(String str) {
        if (str.length() == 0) return str;
        if (str.charAt(0) == 'x') return endX(str.substring(1)) + str.charAt(0);
        return str.charAt(0) + endX(str.substring(1));
    }
}
