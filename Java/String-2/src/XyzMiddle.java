public class XyzMiddle {
    public static void main(String[] args) {
        /*
         * Given a string, does "xyz" appear in the middle of the string? To define middle,
         * we'll say that the number of chars to the left and right of the "xyz" must differ by at most one.
         * This problem is harder than it looks.
         *
         * xyzMiddle("AAxyzBB") → true
         * xyzMiddle("AxyzBB") → true
         * xyzMiddle("AxyzBBB") → false
         */
        System.out.println(xyzMiddle("AAxyzBB"));
        System.out.println(xyzMiddle("AxyzBB"));
        System.out.println(xyzMiddle("AxyzBBB"));

        System.out.println(xyzMiddle("AAxyzB"));
    }

    public static boolean xyzMiddle(String str) {
        while (str.length() > 4) {
            str = str.substring(1, str.length() - 1);
        }
        return str.contains("xyz");

//        ALTERNATIVE SOLUTION: fails few tests not shown explicitly
//        if (str.indexOf("xyz") == -1 || str.length() < 3) return false;
//        return (str.length() % 2 != 0) ?
//                str.charAt(str.length() / 2) == 'y' :
//                str.charAt(str.length() / 2) == 'y' || str.charAt(str.length() / 2) == 'z';
    }
}
