public class Split53 {
    public static void main(String[] args) {
        /*
         * Given an array of ints, is it possible to divide the ints into two groups,
         * so that the sum of the two groups is the same, with these constraints:
         * all the values that are multiple of 5 must be in one group,
         * and all the values that are a multiple of 3 (and not a multiple of 5) must be in the other.
         * (No loops needed.)
         *
         * split53([1, 1]) → true
         * split53([1, 1, 1]) → false
         * split53([2, 4, 2]) → true
         */
        System.out.println(split53(new int[]{1, 1}));
        System.out.println(split53(new int[]{1, 1, 1}));
        System.out.println(split53(new int[]{2, 4, 2}));
    }

    public static boolean split53(int[] nums) {
        return splitHelper(nums, 0, 0, 0);
    }

    private static boolean splitHelper(int[] nums, int i, int sum1, int sum2) {
        if (i == nums.length) return sum1 == sum2;
        if (nums[i] % 5 == 0) return splitHelper(nums, i + 1, sum1 + nums[i], sum2);
        if (nums[i] % 3 == 0) return splitHelper(nums, i + 1, sum1, sum2 + nums[i]);
        return splitHelper(nums, i + 1, sum1 + nums[i], sum2) || splitHelper(nums, i + 1, sum1, sum2 + nums[i]);
    }
}
