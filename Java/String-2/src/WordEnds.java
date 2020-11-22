public class WordEnds {
    public static void main(String[] args) {
        /*
         * Given a string and a non-empty word string, return a string made of each char just before and just after
         * every appearance of the word in the string.
         * Ignore cases where there is no char before or after the word,
         * and a char may be included twice if it is between two words.
         *
         * wordEnds("abcXY123XYijk", "XY") → "c13i"
         * wordEnds("XY123XY", "XY") → "13"
         * wordEnds("XY1XY", "XY") → "11"
         */
        System.out.println(wordEnds("XYXY", "XY"));
        System.out.println(wordEnds("abcXY123XYijk", "XY"));
        System.out.println(wordEnds("XY123XY", "XY"));
        System.out.println(wordEnds("XY1XY", "XY"));
    }

    public static String wordEnds(String str, String word) {
        if (!str.contains(word)) return "";

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i <= str.length() - word.length(); i++) {
            if (i > 0 && str.substring(i).startsWith(word)) {
                sb.append(str.charAt(i - 1));
            }
            if (i < str.length() - word.length() && str.substring(i).startsWith(word)) {
                sb.append(str.charAt(i + word.length()));
            }
        }
        return sb.toString();
    }
}
