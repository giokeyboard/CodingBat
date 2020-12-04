import java.util.Arrays;

public class WordsWithout {
    public static void main(String[] args) {
        /*
         * Given an array of strings, return a new array without the strings that are equal to the target string.
         * One approach is to count the occurrences of the target string, make a new array of the correct length,
         * and then copy over the correct strings.
         *
         * wordsWithout(["a", "b", "c", "a"], "a") → ["b", "c"]
         * wordsWithout(["a", "b", "c", "a"], "b") → ["a", "c", "a"]
         * wordsWithout(["a", "b", "c", "a"], "c") → ["a", "b", "a"]
         */
        System.out.println(Arrays.toString(wordsWithout(new String[]{"a", "b", "c", "a"}, "a")));
        System.out.println(Arrays.toString(wordsWithout(new String[]{"a", "b", "c", "a"}, "b")));
        System.out.println(Arrays.toString(wordsWithout(new String[]{"a", "b", "c", "a"}, "c")));
    }

    public static String[] wordsWithout(String[] words, String target) {
        int len = 0;
        for (String word : words) {
            if (!word.equals(target)) len++;
        }

        String[] out = new String[len];
        int i = 0;
        for (String word : words) {
            if (!word.equals(target)) out[i++] = word;
        }
        return out;
    }
}
