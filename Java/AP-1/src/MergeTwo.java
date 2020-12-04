import java.util.Arrays;

public class MergeTwo {
    public static void main(String[] args) {
        /*
         * Start with two arrays of strings, A and B, each with its elements in alphabetical order and
         * without duplicates. Return a new array containing the first N elements from the two arrays.
         * The result array should be in alphabetical order and without duplicates.
         * A and B will both have a length which is N or more.
         * The best "linear" solution makes a single pass over A and B, taking advantage of the fact that
         * they are in alphabetical order, copying elements directly to the new array.
         *
         * mergeTwo(["a", "c", "z"], ["b", "f", "z"], 3) → ["a", "b", "c"]
         * mergeTwo(["a", "c", "z"], ["c", "f", "z"], 3) → ["a", "c", "f"]
         * mergeTwo(["f", "g", "z"], ["c", "f", "g"], 3) → ["c", "f", "g"]
         */
        System.out.println(Arrays.toString(mergeTwo(new String[]{"a", "c", "z"}, new String[]{"b", "f", "z"}, 3)));
        System.out.println(Arrays.toString(mergeTwo(new String[]{"a", "c", "z"}, new String[]{"c", "f", "z"}, 3)));
        System.out.println(Arrays.toString(mergeTwo(new String[]{"f", "g", "z"}, new String[]{"c", "f", "g"}, 3)));
    }

    public static String[] mergeTwo(String[] a, String[] b, int n) {
        String[] out = new String[n];

        int index = 0;
        int i = 0;
        int j = 0;

        while (index < n) {
            if (a[i].compareTo(b[j]) < 0) {
                out[index++] = a[i++];
            } else if (a[i].compareTo(b[j]) > 0) {
                out[index++] = b[j++];
                continue;
            } else if (a[i] == b[j]) {
                out[index++] = a[i++];
                j++;
            }
        }

        return out;
    }
}
