public class SumNumbers {
    public static void main(String[] args) {
        /*
         * Given a string, return the sum of the numbers appearing in the string, ignoring all other characters.
         * A number is a series of 1 or more digit chars in a row.
         * (Note: Character.isDigit(char) tests if a char is one of the chars '0', '1', .. '9'.
         * Integer.parseInt(string) converts a string to an int.)
         *
         * sumNumbers("abc123xyz") → 123
         * sumNumbers("aa11b33") → 44
         * sumNumbers("7 11") → 18
         */
        System.out.println(sumNumbers("abc123xyz"));
        System.out.println(sumNumbers("aa11b33"));
        System.out.println(sumNumbers("7 11"));
    }

    public static int sumNumbers(String str) {
        int sum = 0;
        int len = 0;
        for (int i = 0; i < str.length(); i++) {
            if (Character.isDigit(str.charAt(i))) {
                len++;
                if (i == str.length() - 1 || !Character.isDigit(str.charAt(i + 1))) {
                    sum += Integer.parseInt(str.substring(i - len + 1, i + 1));
                    len = 0;
                }
            }
        }
        return sum;
    }
}
