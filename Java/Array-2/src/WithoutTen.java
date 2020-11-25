import java.util.Arrays;

public class WithoutTen {
    public static void main(String[] args) {
        /*
         * Return a version of the given array where all the 10's have been removed.
         * The remaining elements should shift left towards the start of the array as needed,
         * and the empty spaces a the end of the array should be 0. So {1, 10, 10, 2} yields {1, 2, 0, 0}.
         * You may modify and return the given array or make a new array.
         *
         * withoutTen([1, 10, 10, 2]) → [1, 2, 0, 0]
         * withoutTen([10, 2, 10]) → [2, 0, 0]
         * withoutTen([1, 99, 10]) → [1, 99, 0]
         */
        System.out.println(Arrays.toString(withoutTen(new int[]{1, 10, 10, 2})));
        System.out.println(Arrays.toString(withoutTen(new int[]{10, 2, 10})));
        System.out.println(Arrays.toString(withoutTen(new int[]{1, 99, 10})));

        System.out.println(Arrays.toString(withoutTen(new int[]{1})));
    }

    public static int[] withoutTen(int[] nums) {
        if (nums.length == 0) return nums;

        int index = 0;
        while (nums[index] != 10 && index < nums.length-1) index++;

        for (int i = index + 1; i < nums.length; i++) {
            if (nums[i] != 10) {
                int temp = nums[index];
                nums[index++] = nums[i];
                nums[i] = temp;
            }
        }

        for (int i = nums.length - 1; i >= 0; i--) {
            if (nums[i] == 10) nums[i] = 0;
            else if (nums[i] != 0) break;
        }

        return nums;
    }
}
