public class CountClumps {
    public static void main(String[] args) {
        /*
         * Say that a "clump" in an array is a series of 2 or more adjacent elements of the same value.
         * Return the number of clumps in the given array.
         *
         * countClumps([1, 2, 2, 3, 4, 4]) → 2
         * countClumps([1, 1, 2, 1, 1]) → 2
         * countClumps([1, 1, 1, 1, 1]) → 1
         */
        System.out.println(countClumps(new int[]{1, 2, 2, 3, 4, 4}));
        System.out.println(countClumps(new int[]{1, 1, 2, 1, 1}));
        System.out.println(countClumps(new int[]{1, 1, 1, 1, 1}));

    }

    public static int countClumps(int[] nums) {
        int clumps = 0;
        int i = 0;
        int j = i + 1;

        while (i < nums.length) {
            while (j < nums.length && nums[i] == nums[j]) {
                j++;
            }
            if (j > i + 1) {
                if(i==0) clumps++;
                else if (i > 0 && nums[i] != nums[i - 1]) {
                    clumps++;
                }
            }
            i++;
        }

        return clumps;
    }
}
