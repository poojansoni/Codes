import java.util.*;

public class ArrayListImp {
    public static void main(String[] args) {
        //ArrayList<String> countryList = new ArrayList<String>();
        List countryList = new ArrayList();
        countryList.add("India");
        countryList.add("Japan");
        countryList.add("Britain");
        countryList.add("Africa");
        System.out.println("Before removing countries: "+countryList.toString());
        countryList.remove(2);
        countryList.remove(1);
        System.out.println("After removing countries: "+countryList.toString());
        //Maps Key and values
        Map mapFam = new HashMap();
        mapFam.put("father", "PR Soni");
        mapFam.put("Mother", "Jyoti soni");
        mapFam.put("brother", "Aradhya soni");
        System.out.println("Brother: "+mapFam.get("brother"));
        System.out.println(mapFam.toString());
        

    }
}