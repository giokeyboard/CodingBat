import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Lower {
    public static void main(String[] args) {
        /*
         * Given a list of strings, return a list where each string is converted to lower case
         * (Note: String toLowerCase() method).
         *
         * lower(["Hello", "Hi"]) → ["hello", "hi"]
         * lower(["AAA", "BBB", "ccc"]) → ["aaa", "bbb", "ccc"]
         * lower(["KitteN", "ChocolaTE"]) → ["kitten", "chocolate"]
         */
        System.out.println(lower(Arrays.asList("Hello", "Hi")));
        System.out.println(lower(Arrays.asList("AAA", "BBB", "ccc")));
        System.out.println(lower(Arrays.asList("KitteN", "ChocolaTE")));
    }

    public static List<String> lower(List<String> strings) {
        return strings.stream().map(s -> s.toLowerCase()).collect(Collectors.toList());
    }
}
