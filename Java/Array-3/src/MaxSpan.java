public class MaxSpan {
    public static void main(String[] args) {
        /*
         * Consider the leftmost and rightmost appearances of some value in an array.
         * We'll say that the "span" is the number of elements between the two inclusive.
         * A single value has a span of 1. Returns the largest span found in the given array. (Efficiency is not a priority.)
         *
         * maxSpan([1, 2, 1, 1, 3]) → 4
         * maxSpan([1, 4, 2, 1, 4, 1, 4]) → 6
         * maxSpan([1, 4, 2, 1, 4, 4, 4]) → 6
         */
        System.out.println(maxSpan(new int[]{1, 2, 1, 1, 3}));
        System.out.println(maxSpan(new int[]{1, 4, 2, 1, 4, 1, 4}));
        System.out.println(maxSpan(new int[]{1, 4, 2, 1, 4, 4, 4}));
    }

    public static int maxSpan(int[] nums) {
        int span = 0;
        for (int i = 0; i < nums.length; i++) {
            for (int j = nums.length - 1; j >= i; j--) {
                if (nums[i] == nums[j]) span = Math.max(span, j + 1 - i);
            }
        }
        return span;
    }
}
