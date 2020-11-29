public class LinearIn {
    public static void main(String[] args) {
        /*
         * Given two arrays of ints sorted in increasing order, outer and inner, return true if
         * all of the numbers in inner appear in outer. The best solution makes only a single
         * "linear" pass of both arrays, taking advantage of the fact that both arrays are already in sorted order.
         *
         * linearIn([1, 2, 4, 6], [2, 4]) → true
         * linearIn([1, 2, 4, 6], [2, 3, 4]) → false
         * linearIn([1, 2, 4, 4, 6], [2, 4]) → true
         */
        System.out.println(linearIn(new int[]{1, 2, 4, 6}, new int[]{2, 4}));
        System.out.println(linearIn(new int[]{1, 2, 4, 6}, new int[]{2, 3, 4}));
        System.out.println(linearIn(new int[]{1, 2, 4, 4, 6}, new int[]{2, 4}));
        System.out.println(linearIn(new int[]{-1, 0, 3, 3, 3, 10, 12}, new int[]{-1, 10, 10}));
    }

    public static boolean linearIn(int[] outer, int[] inner) {
        if (inner.length == 0) return true;
        else if (inner[0] < outer[0] || inner[inner.length - 1] > outer[outer.length - 1]) return false;

        int left = 0;
        int right = outer.length - 1;

        while (inner[0] != outer[left]) {
            left++;
            if (left > right) return false;
        }

        while (inner[inner.length - 1] != outer[right]) {
            right--;
            if (right < left) return false;
        }

        int found = 0;

        for (int i = left; i <= right; i++) {
            if (found < inner.length && outer[i] == inner[found]) {
                found++;
            }
        }

        return found == inner.length;
    }
}
