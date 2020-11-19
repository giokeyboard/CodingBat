public class FizzString {
    public static void main(String[] args) {
        /*
         * Given a string str, if the string starts with "f" return "Fizz".
         * If the string ends with "b" return "Buzz". If both the "f" and "b" conditions are true, return "FizzBuzz".
         * In all other cases, return the string unchanged. (See also: FizzBuzz Code)
         *
         * fizzString("fig") → "Fizz"
         * fizzString("dib") → "Buzz"
         * fizzString("fib") → "FizzBuzz"
         */
        System.out.println(fizzString("fig"));
        System.out.println(fizzString("dib"));
        System.out.println(fizzString("fib"));
    }

    public static String fizzString(String str) {
        if (str.startsWith("f") && str.endsWith("b")) {
            return "FizzBuzz";
        }
        return (str.startsWith("f")) ? "Fizz" : (str.endsWith("b")) ? "Buzz" : str;
    }
}
