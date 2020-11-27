public class MaxBlock {
    public static void main(String[] args) {
        /*
         * Given a string, return the length of the largest "block" in the string.
         * A block is a run of adjacent chars that are the same.
         *
         * maxBlock("hoopla") → 2
         * maxBlock("abbCCCddBBBxx") → 3
         * maxBlock("") → 0
         */
        System.out.println(maxBlock("hoopla"));
        System.out.println(maxBlock("abbCCCddBBBxx"));
        System.out.println(maxBlock(""));
    }

    public static int maxBlock(String str) {
        if (str.length() < 1) return 0;

        int max = 0;
        int count = 1;
        for (int i = 0; i < str.length() - 1; i++) {
            if (str.charAt(i) == str.charAt(i + 1)) {
                count++;
            } else {
                count = 1;
            }
            max = Math.max(max, count);
        }
        return max;
    }
}
