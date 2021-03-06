import java.util.Arrays;

public class ZeroFront {
    public static void main(String[] args) {
        /*
         * Return an array that contains the exact same numbers as the given array,
         * but rearranged so that all the zeros are grouped at the start of the array.
         * The order of the non-zero numbers does not matter. So {1, 0, 0, 1} becomes {0 ,0, 1, 1}.
         * You may modify and return the given array or make a new array.
         *
         * zeroFront([1, 0, 0, 1]) → [0, 0, 1, 1]
         * zeroFront([0, 1, 1, 0, 1]) → [0, 0, 1, 1, 1]
         * zeroFront([1, 0]) → [0, 1]
         */
        System.out.println(Arrays.toString(zeroFront(new int[]{1, 0, 0, 1})));
        System.out.println(Arrays.toString(zeroFront(new int[]{0, 1, 1, 0, 1})));
        System.out.println(Arrays.toString(zeroFront(new int[]{1, 0})));
    }

    public static int[] zeroFront(int[] nums) {
        if (nums.length < 2) return nums;

        int index = 0;
        while (nums[index] == 0) index++;

        for (int i = index + 1; i < nums.length; i++) {
            if (nums[i] == 0) {
                int temp = nums[index];
                nums[index++] = nums[i];
                nums[i] = temp;
            }
        }

        return nums;
    }
}
