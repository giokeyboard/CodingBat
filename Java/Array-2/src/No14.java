public class No14 {
    public static void main(String[] args) {
        /*
         * Given an array of ints, return true if it contains no 1's or it contains no 4's.
         *
         * no14([1, 2, 3]) → true
         * no14([1, 2, 3, 4]) → false
         * no14([2, 3, 4]) → true
         */
        System.out.println(no14(new int[]{1, 2, 3}));
        System.out.println(no14(new int[]{1, 2, 3, 4}));
        System.out.println(no14(new int[]{2, 3, 4}));
    }

    public static boolean no14(int[] nums) {
        boolean containsOne = false;
        boolean containsFour = false;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == 1) containsOne = true;
            if (nums[i] == 4) containsFour = true;
        }
        return !(containsOne && containsFour);
    }
}

