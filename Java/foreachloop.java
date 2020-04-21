import java.util.ArrayList;
import java.util.List;

public class foreachloop{
    public static void main(String[] args) {
        List<String> familyMembers = new ArrayList<String>();
        familyMembers.add("P.R. Soni");
        familyMembers.add("Jyoti Soni");
        familyMembers.add("Aradhya Soni");
        familyMembers.add("Poojan Soni");

        for(String name : familyMembers){
            System.out.println(name);
        }
    }
}