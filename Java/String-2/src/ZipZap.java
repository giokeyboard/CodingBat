public class ZipZap {
    public static void main(String[] args) {
        /*
         * Look for patterns like "zip" and "zap" in the string -- length-3, starting with 'z' and ending with 'p'.
         * Return a string where for all such words, the middle letter is gone, so "zipXzap" yields "zpXzp".
         *
         * zipZap("zipXzap") → "zpXzp"
         * zipZap("zopzop") → "zpzp"
         * zipZap("zzzopzop") → "zzzpzp"
         */
        System.out.println(zipZap("zipXzap"));
        System.out.println(zipZap("zopzop"));
        System.out.println(zipZap("zzzopzop"));
    }

    public static String zipZap(String str) {
        if (str.length() < 3) return str;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) == 'z' && str.charAt(i + 2) == 'p') {
                sb.append(str.charAt(i) + "" + str.charAt(i + 2));
                i += 2;
            } else sb.append(str.charAt(i));
        }
        return sb.toString();
    }
}
