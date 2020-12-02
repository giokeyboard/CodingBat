public class ParenBit {
    public static void main(String[] args) {
        /*
         * Given a string that contains a single pair of parenthesis,
         * compute recursively a new string made of only of the parenthesis and their contents,
         * so "xyz(abc)123" yields "(abc)".
         *
         * parenBit("xyz(abc)123") → "(abc)"
         * parenBit("x(hello)") → "(hello)"
         * parenBit("(xy)1") → "(xy)"
         */
        System.out.println(parenBit("xyz(abc)123"));
        System.out.println(parenBit("x(hello)"));
        System.out.println(parenBit("(xy)1"));
    }

    public static String parenBit(String str) {
        if (str.length() < 2) return "";
        if (str.charAt(0) == '(' && str.indexOf(')') > 0)
            return str.substring(0, str.indexOf(')') + 1) + parenBit(str.substring(str.indexOf(')') + 1));
        return parenBit(str.substring(1));
    }
}
