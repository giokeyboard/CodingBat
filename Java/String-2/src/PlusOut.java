public class PlusOut {
    public static void main(String[] args) {
        /*
         * Given a string and a non-empty word string, return a version of the original String where all chars
         * have been replaced by pluses ("+"), except for appearances of the word string which are preserved unchanged.
         *
         * plusOut("12xy34", "xy") → "++xy++"
         * plusOut("12xy34", "1") → "1+++++"
         * plusOut("12xy34xyabcxy", "xy") → "++xy++xy+++xy"
         */
        System.out.println(plusOut("12xy34", "xy"));
        System.out.println(plusOut("12xy34", "1"));
        System.out.println(plusOut("12xy34xyabcxy", "xy"));
    }

    public static String plusOut(String str, String word) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.length(); i++) {
            if (!str.substring(i).startsWith(word)) sb.append("+");
            else {
                sb.append(word);
                i += word.length() - 1;
            }
        }
        return sb.toString();
    }
}
