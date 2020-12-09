import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Two2 {
    public static void main(String[] args) {
        /*
         * Given a list of non-negative integers, return a list of those numbers multiplied by 2,
         * omitting any of the resulting numbers that end in 2.
         *
         * two2([1, 2, 3]) → [4, 6]
         * two2([2, 6, 11]) → [4]
         * two2([0]) → [0]
         */
        System.out.println(two2(Arrays.asList(1, 2, 3)));
        System.out.println(two2(Arrays.asList(2, 6, 11)));
        System.out.println(two2(Arrays.asList(0)));
    }

    public static List<Integer> two2(List<Integer> nums) {
        return nums.stream().map(x -> 2 * x).filter(x -> x % 10 != 2).collect(Collectors.toList());
    }
}
