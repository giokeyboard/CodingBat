public class Either24 {
    public static void main(String[] args) {
        /*
         * Given an array of ints, return true if the array contains a 2 next to a 2 or a 4 next to a 4, but not both.
         *
         * either24([1, 2, 2]) → true
         * either24([4, 4, 1]) → true
         * either24([4, 4, 1, 2, 2]) → false
         */
        System.out.println(either24(new int[]{1, 2, 2}));
        System.out.println(either24(new int[]{4, 4, 1}));
        System.out.println(either24(new int[]{4, 4, 1, 2, 2}));
    }

    public static boolean either24(int[] nums) {
        boolean flag2 = false;
        boolean flag4 = false;
        for (int i = 0; i < nums.length - 1; i++) {
            if (nums[i] == nums[i + 1] && nums[i] == 2) flag2 = true;
            if (nums[i] == nums[i + 1] && nums[i] == 4) flag4 = true;
            if (flag2 && flag4) return false;
        }
        return flag2 != flag4;
    }
}
