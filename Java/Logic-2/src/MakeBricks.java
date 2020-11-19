public class MakeBricks {
    public static void main(String[] args) {
        /*
         * We want to make a row of bricks that is goal inches long.
         * We have a number of small bricks (1 inch each) and big bricks (5 inches each).
         * Return true if it is possible to make the goal by choosing from the given bricks.
         * This is a little harder than it looks and can be done without any loops. See also: Introduction to MakeBricks
         *
         * makeBricks(3, 1, 8) → true
         * makeBricks(3, 1, 9) → false
         * makeBricks(3, 2, 10) → true
         */
        System.out.println(makeBricks(3, 1, 8));    //true
        System.out.println(makeBricks(3, 1, 9));    //false
        System.out.println(makeBricks(3, 2, 10));   //true
        System.out.println(makeBricks(1, 4, 11));   //true
        System.out.println(makeBricks(0, 3, 10));   //true
        System.out.println(makeBricks(20, 0, 19));  //true
    }

    public static boolean makeBricks(int small, int big, int goal) {
        if (goal > big * 5 + small) {
            return false;
        }

        if (goal % 5 > small) {
            return false;
        }

        return true;
    }
}
