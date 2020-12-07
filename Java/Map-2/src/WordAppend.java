import java.util.HashMap;
import java.util.Map;

public class WordAppend {
    public static void main(String[] args) {
        /*
         * Loop over the given array of strings to build a result string like this:
         * when a string appears the 2nd, 4th, 6th, etc. time in the array, append the string to the result.
         * Return the empty string if no string appears a 2nd time.
         *
         * wordAppend(["a", "b", "a"]) → "a"
         * wordAppend(["a", "b", "a", "c", "a", "d", "a"]) → "aa"
         * wordAppend(["a", "", "a"]) → "a"
         */
        System.out.println(wordAppend(new String[]{"a", "b", "a"}));
        System.out.println(wordAppend(new String[]{"a", "b", "a", "c", "a", "d", "a"}));
        System.out.println(wordAppend(new String[]{"a", "", "a"}));
    }

    public static String wordAppend(String[] strings) {
        StringBuilder sb = new StringBuilder();
        Map<String, Integer> map = new HashMap<>();
        for (String s : strings) {
            if (map.containsKey(s)) {
                int count = map.get(s);
                map.put(s, ++count);
            }
            else map.put(s, 1);

            if (map.get(s) != 0 && map.get(s) % 2 == 0) sb.append(s);
        }
        return sb.toString();
    }
}
