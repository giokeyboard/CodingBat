import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class WordsWithoutList {
    public static void main(String[] args) {
        /*
         * Given an array of strings, return a new List (e.g. an ArrayList) where
         * all the strings of the given length are omitted.
         * See wordsWithout() below which is more difficult because it uses arrays.
         *
         * wordsWithoutList(["a", "bb", "b", "ccc"], 1) → ["bb", "ccc"]
         * wordsWithoutList(["a", "bb", "b", "ccc"], 3) → ["a", "bb", "b"]
         * wordsWithoutList(["a", "bb", "b", "ccc"], 4) → ["a", "bb", "b", "ccc"]
         */
        System.out.println(Arrays.toString(wordsWithoutList(new String[]{"a", "bb", "b", "ccc"}, 1).toArray()));
        System.out.println(Arrays.toString(wordsWithoutList(new String[]{"a", "bb", "b", "ccc"}, 3).toArray()));
        System.out.println(Arrays.toString(wordsWithoutList(new String[]{"a", "bb", "b", "ccc"}, 4).toArray()));
    }

    public static List wordsWithoutList(String[] words, int len) {
        List<String> output = new ArrayList<>();
        for (String word : words) {
            if (word.length() != len) output.add(word);
        }
        return output;
    }
}
