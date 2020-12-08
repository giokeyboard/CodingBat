import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class MoreY {
    public static void main(String[] args) {
        /*
         * Given a list of strings, return a list where each string has "y" added at its start and end.
         *
         * moreY(["a", "b", "c"]) → ["yay", "yby", "ycy"]
         * moreY(["hello", "there"]) → ["yhelloy", "ytherey"]
         * moreY(["yay"]) → ["yyayy"]
         */
        System.out.println(moreY(Arrays.asList("a", "b", "c")));
        System.out.println(moreY(Arrays.asList("hello", "there")));
        System.out.println(moreY(Arrays.asList("yay")));
    }

    public static List<String> moreY(List<String> strings) {
        return strings.stream().map(s -> 'y' + s + 'y').collect(Collectors.toList());
    }
}
