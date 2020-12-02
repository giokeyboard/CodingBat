public class StrDist {
    public static void main(String[] args) {
        /*
         * Given a string and a non-empty substring sub,
         * compute recursively the largest substring which starts and ends with sub and return its length.
         *
         * strDist("catcowcat", "cat") → 9
         * strDist("catcowcat", "cow") → 3
         * strDist("cccatcowcatxx", "cat") → 9
         */
        System.out.println(strDist("catcowcat", "cat"));
        System.out.println(strDist("catcowcat", "cow"));
        System.out.println(strDist("cccatcowcatxx", "cat"));
    }

    public static int strDist(String str, String sub) {
        if (str.length() < sub.length()) return 0;
        if (str.startsWith(sub) && str.endsWith(sub)) return str.length();
        if (!str.startsWith(sub)) return strDist(str.substring(1), sub);
        return strDist(str.substring(0, str.length() - 1), sub);
    }
}
