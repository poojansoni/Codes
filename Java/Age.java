import java.lang.reflect.Array;

public class Age{
    public static void main(String[] args) {
        int age = 18;
        if(age ==18){
            System.out.println("Age is 18");
        }
        else if (age>18) {
            System.out.println("Age is over 18");
        } else {
            System.out.println("Age is below 18");
        }

        int[] ages = { 24, 56};
        if(ages[1]>ages[0]){
            System.out.println("Second is greater than one");
        }
        else if (ages[1] == ages[0]){
            System.out.println("Second is equal to one"); 
        }else{
            System.out.println("Second is less than one");
        }
    }
}