public class LoneSum {
    public static void main(String[] args) {
        /*
         * Given 3 int values, a b c, return their sum.
         * However, if one of the values is the same as another of the values, it does not count towards the sum.
         *
         * loneSum(1, 2, 3) → 6
         * loneSum(3, 2, 3) → 2
         * loneSum(3, 3, 3) → 0
         */
        System.out.println(loneSum(1, 2, 3));
        System.out.println(loneSum(3, 2, 3));
        System.out.println(loneSum(3, 3, 3));
    }

    public static int loneSum(int a, int b, int c) {
        if (a == b) return (a == c) ? 0 : c;
        if (b == c) return a;
        if (a == c) return b;
        return a + b + c;
    }
}
