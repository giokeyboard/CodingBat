import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class NoZ {
    public static void main(String[] args) {
        /*
         * Given a list of strings, return a list of the strings, omitting any string that contains a "z".
         * (Note: the str.contains(x) method returns a boolean)
         *
         * noZ(["aaa", "bbb", "aza"]) → ["aaa", "bbb"]
         * noZ(["hziz", "hzello", "hi"]) → ["hi"]
         * noZ(["hello", "howz", "are", "youz"]) → ["hello", "are"]
         */
        System.out.println(noZ(Arrays.asList("aaa", "bbb", "aza")));
        System.out.println(noZ(Arrays.asList("hziz", "hzello", "hi")));
        System.out.println(noZ(Arrays.asList("hello", "howz", "are", "youz")));
    }

    public static List<String> noZ(List<String> strings) {
        return strings.stream().filter(x -> !x.contains("z")).collect(Collectors.toList());
    }
}
