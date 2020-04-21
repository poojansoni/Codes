import java.util.Scanner;

public class SquareOrTriangular{
    public static void main(String[] args) {
       class Number{
           int number;

           public boolean isSquare(){
               double sqrt = Math.sqrt(number);
               if(sqrt == Math.floor(sqrt)){
                   return true;
               }else{
                   return false;
               }
           }
           public boolean isTriangle(){
            int x =1;
        
            int triangularNo = 1;
            while(triangularNo<number)
            {
                x++;
                triangularNo = triangularNo +x;
            }
            if(triangularNo == number){
                return true;
            }else{
                return false;
            }
           }
       }
       Number myNumber = new Number();
       myNumber.number = 6;
       System.out.println(myNumber.isTriangle());
       System.out.println(myNumber.isSquare());
    }
}