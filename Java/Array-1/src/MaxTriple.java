public class MaxTriple {
    public static void main(String[] args) {
        /*
         * Given an array of ints of odd length,
         * look at the first, last, and middle values in the array and return the largest.
         * The array length will be a least 1.
         *
         * maxTriple([1, 2, 3]) → 3
         * maxTriple([1, 5, 3]) → 5
         * maxTriple([5, 2, 3]) → 5
         */
        System.out.println(maxTriple(new int[]{1, 2, 3}));
        System.out.println(maxTriple(new int[]{1, 5, 3}));
        System.out.println(maxTriple(new int[]{5, 2, 3}));
    }

    public static int maxTriple(int[] nums) {
        if (nums.length == 1) {
            return nums[0];
        }
        if (nums.length == 2 || nums.length % 2 == 0) {
            return Math.max(nums[0], nums[1]);
        }
        int max = (nums[0] > nums[nums.length / 2]) ? nums[0] : nums[nums.length / 2];
        max = (max > nums[nums.length - 1]) ? max : nums[nums.length - 1];
        return max;
    }
}
