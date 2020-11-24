public class Has12 {
    public static void main(String[] args) {
        /*
         * Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in the array.
         *
         * has12([1, 3, 2]) → true
         * has12([3, 1, 2]) → true
         * has12([3, 1, 4, 5, 2]) → true
         */
        System.out.println(has12(new int[]{1, 3, 2}));
        System.out.println(has12(new int[]{3, 1, 2}));
        System.out.println(has12(new int[]{3, 1, 4, 5, 2}));
    }

    public static boolean has12(int[] nums) {
        boolean flag = false;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == 1) flag = true;
            if (flag && nums[i] == 2) return true;
        }
        return false;
    }
}
