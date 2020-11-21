public class GetSandwich {
    public static void main(String[] args) {
        /*
         * A sandwich is two pieces of bread with something in between.
         * Return the string that is between the first and last appearance of "bread" in the given string,
         * or return the empty string "" if there are not two pieces of bread.
         *
         * getSandwich("breadjambread") → "jam"
         * getSandwich("xxbreadjambreadyy") → "jam"
         * getSandwich("xxbreadyy") → ""
         */
        System.out.println(getSandwich("breadjambread"));
        System.out.println(getSandwich("xxbreadjambreadyy"));
        System.out.println(getSandwich("xxbreadyy"));
    }

    public static String getSandwich(String str) {
        StringBuilder sb = new StringBuilder();
        if (str.indexOf("bread") != -1 && str.lastIndexOf("bread") != str.indexOf("bread"))
            sb.append(str, str.indexOf("bread") + "bread".length(), str.lastIndexOf("bread"));
        return sb.toString();
    }
}
