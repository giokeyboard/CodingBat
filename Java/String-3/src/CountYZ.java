public class CountYZ {
    public static void main(String[] args) {
        /*
         * Given a string, count the number of words ending in 'y' or 'z' -- so the 'y' in "heavy" and the 'z' in "fez" count,
         * but not the 'y' in "yellow" (not case sensitive). We'll say that a y or z is at the end of a word if there is not
         * an alphabetic letter immediately following it.
         * (Note: Character.isLetter(char) tests if a char is an alphabetic letter.)
         *
         * countYZ("fez day") → 2
         * countYZ("day fez") → 2
         * countYZ("day fyyyz") → 2
         */
        System.out.println(countYZ("fez day"));
        System.out.println(countYZ("day fez"));
        System.out.println(countYZ("day fyyyz"));
    }

    public static int countYZ(String str) {
        int count = 0;
        String lower = str.toLowerCase();
        if (lower.charAt(str.length() - 1) == 'z' || lower.charAt(str.length() - 1) == 'y')
            count++;
        for (int i = 0; i < lower.length() - 1; i++) {
            if (!Character.isLetter(lower.charAt(i + 1)) && (lower.charAt(i) == 'y' || lower.charAt(i) == 'z')) {
                count++;
                i++;
            }
        }
        return count;
    }
}
