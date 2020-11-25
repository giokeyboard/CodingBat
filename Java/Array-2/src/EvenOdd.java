import java.util.Arrays;

public class EvenOdd {
    public static void main(String[] args) {
        /*
         * Return an array that contains the exact same numbers as the given array, but rearranged so that
         * all the even numbers come before all the odd numbers. Other than that, the numbers can be in any order.
         * You may modify and return the given array, or make a new array.
         *
         * evenOdd([1, 0, 1, 0, 0, 1, 1]) → [0, 0, 0, 1, 1, 1, 1]
         * evenOdd([3, 3, 2]) → [2, 3, 3]
         * evenOdd([2, 2, 2]) → [2, 2, 2]
         */
        System.out.println(Arrays.toString(evenOdd(new int[]{1, 0, 1, 0, 0, 1, 1})));
        System.out.println(Arrays.toString(evenOdd(new int[]{3, 3, 2})));
        System.out.println(Arrays.toString(evenOdd(new int[]{2, 2, 2})));
    }

    public static int[] evenOdd(int[] nums) {
        int index = 0;
        while (index < nums.length && nums[index] % 2 == 0) index++;

        for (int i = index + 1; i < nums.length; i++) {
            if (nums[i] % 2 == 0) {
                int temp = nums[index];
                nums[index++] = nums[i];
                nums[i] = temp;
            }
        }

        return nums;
    }
}
