import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Square56 {
    public static void main(String[] args) {
        /*
         * Given a list of integers, return a list of those numbers squared and the product added to 10,
         * omitting any of the resulting numbers that end in 5 or 6.
         *
         * square56([3, 1, 4]) → [19, 11]
         * square56([1]) → [11]
         * square56([2]) → [14]
         */
        System.out.println(square56(Arrays.asList(3, 1, 4)));
        System.out.println(square56(Arrays.asList(1)));
        System.out.println(square56(Arrays.asList(2)));
    }

    public static List<Integer> square56(List<Integer> nums) {
        return nums
                .stream()
                .map(x -> (x * x) + 10)
                .filter(x -> x % 10 != 5 && x % 10 != 6)
                .collect(Collectors.toList());
    }
}
