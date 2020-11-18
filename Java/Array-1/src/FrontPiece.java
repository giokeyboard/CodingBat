import java.util.Arrays;

public class FrontPiece {
    public static void main(String[] args) {
        /*
         * Given an int array of any length, return a new array of its first 2 elements.
         * If the array is smaller than length 2, use whatever elements are present.
         *
         * frontPiece([1, 2, 3]) → [1, 2]
         * frontPiece([1, 2]) → [1, 2]
         * frontPiece([1]) → [1]
         */
        System.out.println(Arrays.toString(frontPiece(new int[]{1, 2, 3})));
        System.out.println(Arrays.toString(frontPiece(new int[]{1, 2})));
        System.out.println(Arrays.toString(frontPiece(new int[]{1})));
    }

    public static int[] frontPiece(int[] nums) {
        if (nums.length == 0) {
            return new int[]{};
        }
        if (nums.length == 1) {
            return new int[]{nums[0]};
        }
        return new int[]{nums[0], nums[1]};
    }
}
