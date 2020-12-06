import java.util.HashMap;
import java.util.Map;

public class MapBully {
    public static void main(String[] args) {
        /*
         * Modify and return the given map as follows: if the key "a" has a value, set the key "b" to have that value,
         * and set the key "a" to have the value "". Basically "b" is a bully, taking the value and replacing it with
         * the empty string.
         *
         * mapBully({"a": "candy", "b": "dirt"}) → {"a": "", "b": "candy"}
         * mapBully({"a": "candy"}) → {"a": "", "b": "candy"}
         * mapBully({"a": "candy", "b": "carrot", "c": "meh"}) → {"a": "", "b": "candy", "c": "meh"}
         */
        System.out.println(mapBully(new HashMap<>(Map.of("a", "candy", "b", "dirt"))));
        System.out.println(mapBully(new HashMap<>(Map.of("a", "candy"))));
        System.out.println(mapBully(new HashMap<>(Map.of("a", "candy", "b", "carrot", "c", "meh"))));
    }

    public static Map<String, String> mapBully(Map<String, String> map) {
        if (map.containsKey("a")) {
            map.put("b", map.get("a"));
            map.put("a", "");
        }
        return map;
    }
}
