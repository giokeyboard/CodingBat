public class SplitOdd10 {
    public static void main(String[] args) {
        /*
         * Given an array of ints, is it possible to divide the ints into two groups,
         * so that the sum of one group is a multiple of 10, and the sum of the other group is odd.
         * Every int must be in one group or the other.
         * Write a recursive helper method that takes whatever arguments you like, and make the initial call to
         * your recursive helper from splitOdd10(). (No loops needed.)
         *
         * splitOdd10([5, 5, 5]) → true
         * splitOdd10([5, 5, 6]) → false
         * splitOdd10([5, 5, 6, 1]) → true
         */
        System.out.println(splitOdd10(new int[]{5, 5, 5}));
        System.out.println(splitOdd10(new int[]{5, 5, 6}));
        System.out.println(splitOdd10(new int[]{5, 5, 6, 1}));
    }

    public static boolean splitOdd10(int[] nums) {
        return splitHelper(nums,0,0,0);
    }

    private static boolean splitHelper(int[] nums, int i, int sum1, int sum2) {
        if (i == nums.length) return sum1 % 10 == 0 && sum2 % 2 == 1;
        return splitHelper(nums, i + 1, sum1 + nums[i], sum2) || splitHelper(nums, i + 1, sum1, sum2 + nums[i]);
    }
}
