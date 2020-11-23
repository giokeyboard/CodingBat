public class Has22 {
    public static void main(String[] args) {
        /*
         * Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
         *
         * has22([1, 2, 2]) → true
         * has22([1, 2, 1, 2]) → false
         * has22([2, 1, 2]) → false
         */
        System.out.println(has22(new int[]{1, 2, 2}));
        System.out.println(has22(new int[]{1, 2, 1, 2}));
        System.out.println(has22(new int[]{2, 1, 2}));
    }

    public static boolean has22(int[] nums) {
        for (int i = 0; i < nums.length - 1; i++) {
            if (nums[i] == 2 && nums[i] == nums[i + 1]) return true;
        }
        return false;
    }
}
