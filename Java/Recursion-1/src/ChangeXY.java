public class ChangeXY {
    public static void main(String[] args) {
        /*
         * Given a string, compute recursively (no loops) a new string where all the
         * lowercase 'x' chars have been changed to 'y' chars.
         *
         * changeXY("codex") → "codey"
         * changeXY("xxhixx") → "yyhiyy"
         * changeXY("xhixhix") → "yhiyhiy"
         */
        System.out.println(changeXY("codex"));
        System.out.println(changeXY("xxhixx"));
        System.out.println(changeXY("xhixhix"));
    }

    public static String changeXY(String str) {
        if (str.length() == 0) return "";
        if (str.charAt(0) == 'x') return 'y' + changeXY(str.substring(1));
        return str.charAt(0) + changeXY(str.substring(1));
    }
}
