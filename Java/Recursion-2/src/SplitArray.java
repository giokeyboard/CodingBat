public class SplitArray {
    public static void main(String[] args) {
        /*
         * Given an array of ints, is it possible to divide the ints into two groups,
         * so that the sums of the two groups are the same. Every int must be in one group or the other.
         * Write a recursive helper method that takes whatever arguments you like, and make the initial call
         * to your recursive helper from splitArray(). (No loops needed.)
         *
         * splitArray([2, 2]) → true
         * splitArray([2, 3]) → false
         * splitArray([5, 2, 3]) → true
         */
        System.out.println(splitArray(new int[]{2, 2}));
        System.out.println(splitArray(new int[]{2, 3}));
        System.out.println(splitArray(new int[]{5, 2, 3}));
    }

    public static boolean splitArray(int[] nums) {
        return splitHelper(nums, 0, 0, 0);
    }

    private static boolean splitHelper(int[] nums, int i, int total1, int total2) {
        if (i == nums.length) return total1 == total2;
        return splitHelper(nums, i + 1, total1 + nums[i], total2) ||
                splitHelper(nums, i + 1, total1, total2 + nums[i]);
    }
}
