import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class NoNeg {
    public static void main(String[] args) {
        /*
         * Given a list of integers, return a list of the integers, omitting any that are less than 0.
         *
         * noNeg([1, -2]) → [1]
         * noNeg([-3, -3, 3, 3]) → [3, 3]
         * noNeg([-1, -1, -1]) → []
         */
        System.out.println(noNeg(Arrays.asList(1, -2)));
        System.out.println(noNeg(Arrays.asList(-3, -3, 3, 3)));
        System.out.println(noNeg(Arrays.asList(-1, -1, -1)));
    }

    public static List<Integer> noNeg(List<Integer> nums) {
        return nums.stream().filter(x -> x >= 0).collect(Collectors.toList());
    }
}
