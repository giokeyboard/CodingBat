public class CanBalance {
    public static void main(String[] args) {
        /*
         * Given a non-empty array, return true if there is a place to split the array so that
         * the sum of the numbers on one side is equal to the sum of the numbers on the other side.
         *
         * canBalance([1, 1, 1, 2, 1]) → true
         * canBalance([2, 1, 1, 2, 1]) → false
         * canBalance([10, 10]) → true
         */
        System.out.println(canBalance(new int[]{1, 1, 1, 2, 1}));
        System.out.println(canBalance(new int[]{2, 1, 1, 2, 1}));
        System.out.println(canBalance(new int[]{10, 10}));
    }

    public static boolean canBalance(int[] nums) {
        int sumFirst = 0;
        int sumSecond = 0;
        for (int i = 0; i < nums.length - 1; i++) {
            sumFirst += nums[i];
            for (int j = i + 1; j < nums.length; j++) {
                sumSecond += nums[j];
            }
            if (sumFirst == sumSecond) return true;
            sumSecond = 0;
        }
        return false;
    }
}
