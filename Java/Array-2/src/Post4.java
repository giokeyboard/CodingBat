import java.util.Arrays;

public class Post4 {
    public static void main(String[] args) {
        /*
         * Given a non-empty array of ints, return a new array containing the elements from the original array
         * that come after the last 4 in the original array. The original array will contain at least one 4.
         * Note that it is valid in java to create an array of length 0.
         *
         * post4([2, 4, 1, 2]) → [1, 2]
         * post4([4, 1, 4, 2]) → [2]
         * post4([4, 4, 1, 2, 3]) → [1, 2, 3]
         */
        System.out.println(Arrays.toString(post4(new int[]{2, 4, 1, 2})));
        System.out.println(Arrays.toString(post4(new int[]{4, 1, 4, 2})));
        System.out.println(Arrays.toString(post4(new int[]{4, 4, 1, 2, 3})));
    }

    public static int[] post4(int[] nums) {
        int index = 0;
        for (int i = nums.length - 1; i >= 0; i--) {
            if (nums[i] == 4) {
                index = i + 1;
                break;
            }
        }
        int[] result = new int[nums.length - index];
        for (int i = 0; i < result.length; i++) {
            result[i] = nums[index++];
        }
        return result;
    }
}
