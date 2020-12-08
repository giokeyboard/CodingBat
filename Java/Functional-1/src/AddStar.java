import java.util.Arrays;
import java.util.List;

public class AddStar {
    public static void main(String[] args) {
        /*
         * Given a list of strings, return a list where each string has "*" added at its end.
         *
         * addStar(["a", "bb", "ccc"]) → ["a*", "bb*", "ccc*"]
         * addStar(["hello", "there"]) → ["hello*", "there*"]
         * addStar(["*"]) → ["**"]
         */
        System.out.println(addStar(Arrays.asList("a", "bb", "ccc")));
        System.out.println(addStar(Arrays.asList("hello", "there")));
        System.out.println(addStar(Arrays.asList("*")));
    }

    public static List<String> addStar(List<String> strings) {
        strings.replaceAll(s -> s + "*");
        return strings;
    }
}
