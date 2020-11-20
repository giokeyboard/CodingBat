public class XyzThere {
    public static void main(String[] args) {
        /*
         * Return true if the given string contains an appearance of "xyz" where
         * the xyz is not directly preceeded by a period (.). So "xxyz" counts but "x.xyz" does not.
         *
         * xyzThere("abcxyz") → true
         * xyzThere("abc.xyz") → false
         * xyzThere("xyz.abc") → true
         */
        System.out.println(xyzThere("abcxyz"));
        System.out.println(xyzThere("abc.xyz"));
        System.out.println(xyzThere("xyz.abc"));
    }

    public static boolean xyzThere(String str) {
        if (str.startsWith("xyz")) return true;
        for (int i = 0; i < str.length() - 3; i++) {
            if (str.charAt(i) != '.' && str.startsWith("xyz", i + 1)) return true;
        }
        return false;
    }
}
