public class HasOne {
    public static void main(String[] args) {
        /*
         * Given a positive int n, return true if it contains a 1 digit.
         * Note: use % to get the rightmost digit, and / to discard the rightmost digit.
         *
         * hasOne(10) → true
         * hasOne(22) → false
         * hasOne(220) → false
         */
        System.out.println(hasOne(10));
        System.out.println(hasOne(22));
        System.out.println(hasOne(220));
    }

    public static boolean hasOne(int n) {
        if (n % 10 == 1) return true;
        if (n / 10 == 0) return false;
        return hasOne(n / 10);
    }
}
