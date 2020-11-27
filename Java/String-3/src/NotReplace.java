public class NotReplace {
    public static void main(String[] args) {
        /*
         * Given a string, return a string where every appearance of the lowercase word "is" has been replaced with "is not".
         * The word "is" should not be immediately preceded or followed by a letter --
         * so for example the "is" in "this" does not count.
         * (Note: Character.isLetter(char) tests if a char is a letter.)
         *
         * notReplace("is test") → "is not test"
         * notReplace("is-is") → "is not-is not"
         * notReplace("This is right") → "This is not right"
         */
        System.out.println(notReplace("is test"));
        System.out.println(notReplace("is-is"));
        System.out.println(notReplace("This is right"));
    }

    public static String notReplace(String str) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < str.length(); i++) {
            if (str.startsWith("is", i)) {
                if ((i == 0 || (i > 0 && !Character.isLetter(str.charAt(i - 1)))) &&
                        (i == str.length() - 2 || (i < str.length() - 2 && !Character.isLetter(str.charAt(i + 2))))) {
                    sb.append("is not");
                    i++;
                    continue;
                }
            }
            sb.append(str.charAt(i));
        }

        return sb.toString();
    }
}
