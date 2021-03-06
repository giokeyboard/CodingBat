public class Has23 {
    public static void main(String[] args) {
        /*
         * Given an int array length 2, return true if it contains a 2 or a 3.
         *
         * has23([2, 5]) → true
         * has23([4, 3]) → true
         * has23([4, 5]) → false
         */
        System.out.println(has23(new int[]{2, 5}));
        System.out.println(has23(new int[]{4, 3}));
        System.out.println(has23(new int[]{4, 5}));
    }

    public static boolean has23(int[] nums) {
        return nums[0] == 2 || nums[0] == 3 || nums[1] == 3 || nums[1] == 3;
    }
}
