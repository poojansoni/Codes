public class numberPositive{
    public static void main(String[] args) {
        class number{
            int num;
            public boolean isPositive(){
                if (num>0){
                    return true;
                    
                }else{
                    return false;
                }
            }
        }

        number no = new number();
        no.num = 0;
        if(no.isPositive()) {
            System.out.println("The number is positive");
        }else{
            System.out.println("The number is not positive");
        }
    }
}