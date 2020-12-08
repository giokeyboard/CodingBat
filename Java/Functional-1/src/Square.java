import java.util.Arrays;
import java.util.List;

public class Square {
    public static void main(String[] args) {
        /*
         * Given a list of integers, return a list where each integer is multiplied with itself.
         *
         * square([1, 2, 3]) → [1, 4, 9]
         * square([6, 8, -6, -8, 1]) → [36, 64, 36, 64, 1]
         * square([]) → []
         */
        System.out.println(square(Arrays.asList(1, 2, 3)));
        System.out.println(square(Arrays.asList(6, 8, -6, -8, 1)));
        System.out.println(square(Arrays.asList()));
    }

    public static List<Integer> square(List<Integer> nums) {
        nums.replaceAll(n -> n * n);
        return nums;
    }
}
