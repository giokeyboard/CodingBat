import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class NoX {
    public static void main(String[] args) {
        /*
         * Given a list of strings, return a list where each string has all its "x" removed.
         *
         * noX(["ax", "bb", "cx"]) → ["a", "bb", "c"]
         * noX(["xxax", "xbxbx", "xxcx"]) → ["a", "bb", "c"]
         * noX(["x"]) → [""]
         */
        System.out.println(noX(Arrays.asList("ax", "bb", "cx")));
        System.out.println(noX(Arrays.asList("xxax", "xbxbx", "xxcx")));
        System.out.println(noX(Arrays.asList("x")));
    }

    public static List<String> noX(List<String> strings) {
        return strings.stream().map(s -> s.replace("x", "")).collect(Collectors.toList());
    }
}
