public class SameStarChar {
    public static void main(String[] args) {
        /*
         * Returns true if for every '*' (star) in the string, if there are chars both immediately before and after the star,
         * they are the same.
         *
         * sameStarChar("xy*yzz") → true
         * sameStarChar("xy*zzz") → false
         * sameStarChar("*xa*az") → true
         */
        System.out.println(sameStarChar("xy*yzz"));
        System.out.println(sameStarChar("xy*zzz"));
        System.out.println(sameStarChar("*xa*az"));
    }

    public static boolean sameStarChar(String str) {
        if (str.length() < 3 || str.indexOf('*') < 0) return true;
        boolean result = false;
        for (int i = 1; i < str.length() - 1; i++) {
            result = str.charAt(i) == '*' ? str.charAt(i - 1) == str.charAt(i + 1) : result;
        }
        return result;
    }
}

