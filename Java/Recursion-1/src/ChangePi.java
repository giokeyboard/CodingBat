public class ChangePi {
    public static void main(String[] args) {
        /*
         * Given a string, compute recursively (no loops) a new string where
         * all appearances of "pi" have been replaced by "3.14".
         *
         * changePi("xpix") → "x3.14x"
         * changePi("pipi") → "3.143.14"
         * changePi("pip") → "3.14p"
         */
        System.out.println(changePi("xpix"));
        System.out.println(changePi("pipi"));
        System.out.println(changePi("pip"));
    }

    public static String changePi(String str) {
        if (str.length() < 2) return str;
        if (str.startsWith("pi")) return "3.14" + changePi(str.substring(2));
        return str.charAt(0) + changePi(str.substring(1));
    }
}
