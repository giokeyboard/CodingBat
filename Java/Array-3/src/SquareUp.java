import java.util.Arrays;

public class SquareUp {
    public static void main(String[] args) {
        /*
         * Given n>=0, create an array length n*n with the following pattern, shown here for n=3 :
         * {0, 0, 1,    0, 2, 1,    3, 2, 1} (spaces added to show the 3 groups).
         *
         * squareUp(3) → [0, 0, 1, 0, 2, 1, 3, 2, 1]
         * squareUp(2) → [0, 1, 2, 1]
         * squareUp(4) → [0, 0, 0, 1, 0, 0, 2, 1, 0, 3, 2, 1, 4, 3, 2, 1]
         */
        System.out.println(Arrays.toString(squareUp(3)));
        System.out.println(Arrays.toString(squareUp(2)));
        System.out.println(Arrays.toString(squareUp(4)));
    }

    public static int[] squareUp(int n) {
        if (n == 0) return new int[]{};
        int[] out = new int[n * n];

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= i; j++) {
                out[i * n - j] = j;
            }
        }

        return out;
    }
}
