import java.util.Arrays;

public class Fix23 {
    public static void main(String[] args) {
        /*
         * Given an int array length 3, if there is a 2 in the array immediately followed by a 3,
         * set the 3 element to 0. Return the changed array.
         *
         * fix23([1, 2, 3]) → [1, 2, 0]
         * fix23([2, 3, 5]) → [2, 0, 5]
         * fix23([1, 2, 1]) → [1, 2, 1]
         */
        System.out.println(Arrays.toString(fix23(new int[]{1, 2, 3})));
        System.out.println(Arrays.toString(fix23(new int[]{2, 3, 5})));
        System.out.println(Arrays.toString(fix23(new int[]{1, 2, 1})));
    }

    public static int[] fix23(int[] nums) {
        int[] output = nums;
        output[1] = (output[1] == 3 && output[0] == 2) ? 0 : output[1];
        output[2] = (output[2] == 3 && output[1] == 2) ? 0 : output[2];
        return output;
    }
}
