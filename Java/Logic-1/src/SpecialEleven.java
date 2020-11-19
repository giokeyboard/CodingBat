public class SpecialEleven {
    public static void main(String[] args) {
        /*
         * We'll say a number is special if it is a multiple of 11 or if it is one more than a multiple of 11.
         * Return true if the given non-negative number is special. Use the % "mod" operator -- see Introduction to Mod
         *
         * specialEleven(22) → true
         * specialEleven(23) → true
         * specialEleven(24) → false
         */
        System.out.println(specialEleven(22));
        System.out.println(specialEleven(23));
        System.out.println(specialEleven(24));
    }

    public static boolean specialEleven(int n) {
        return n % 11 <= 1;
    }
}
