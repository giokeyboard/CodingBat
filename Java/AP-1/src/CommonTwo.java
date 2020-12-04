public class CommonTwo {
    public static void main(String[] args) {
        /*
         * Start with two arrays of strings, a and b, each in alphabetical order, possibly with duplicates.
         * Return the count of the number of strings which appear in both arrays.
         * The best "linear" solution makes a single pass over both arrays, taking advantage of the fact that
         * they are in alphabetical order.
         *
         * commonTwo(["a", "c", "x"], ["b", "c", "d", "x"]) → 2
         * commonTwo(["a", "c", "x"], ["a", "b", "c", "x", "z"]) → 3
         * commonTwo(["a", "b", "c"], ["a", "b", "c"]) → 3
         */
        System.out.println(commonTwo(new String[]{"a", "c", "x"}, new String[]{"b", "c", "d", "x"}));
        System.out.println(commonTwo(new String[]{"a", "c", "x"}, new String[]{"a", "b", "c", "x", "z"}));
        System.out.println(commonTwo(new String[]{"a", "b", "c"}, new String[]{"a", "b", "c"}));
    }

    public static int commonTwo(String[] a, String[] b) {
        int count = 0;
        int i = 0;
        int j = 0;

        while (i < a.length && j < b.length) {
            if (i < a.length - 1 && a[i].equals(a[i + 1])) {
                i++;
                continue;
            }
            if (j < b.length - 1 && b[j].equals(b[j + 1])) {
                j++;
                continue;
            }

            if (a[i].equals(b[j])) {
                count++;
                i++;
                j++;
            } else if (a[i].compareTo(b[j]) < 0) i++;
            else if (a[i].compareTo(b[j]) > 0) j++;
        }

        return count;
    }
}
