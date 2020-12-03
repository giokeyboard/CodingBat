public class WordsCount {
    public static void main(String[] args) {
        /*
         * Given an array of strings, return the count of the number of strings with the given length.
         *
         * wordsCount(["a", "bb", "b", "ccc"], 1) → 2
         * wordsCount(["a", "bb", "b", "ccc"], 3) → 1
         * wordsCount(["a", "bb", "b", "ccc"], 4) → 0
         */
        System.out.println(wordsCount(new String[]{"a", "bb", "b", "ccc"}, 1));
        System.out.println(wordsCount(new String[]{"a", "bb", "b", "ccc"}, 3));
        System.out.println(wordsCount(new String[]{"a", "bb", "b", "ccc"}, 4));
    }

    public static int wordsCount(String[] words, int len) {
        int count = 0;
        for (int i = 0; i < words.length; i++) {
            if (words[i].length() == len) count++;
        }
        return count;
    }
}
