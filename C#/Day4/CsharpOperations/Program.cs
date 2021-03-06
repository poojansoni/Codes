using System;
using Operators;
namespace CsharpOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());

            bool condition = true;
            while(condition == true)
            {
                Console.WriteLine("Enter 0: To Exit\n1: Add\n2: Subtract\n3: Multiply\n4: Divide\n5: Modulus\n6: Increament \n7: Decreament\n");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                double val = 0;
                
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye!");
                        condition = false;
                        break;
                    
                    case 1:
                        val =  Operations.Add(a, b);
                        break;
                    case 2:
                        val = Operations.Subtract(a, b);
                        break;
                    case 3:
                        val = Operations.Multiply(a, b);
                        break;
                    case 4:
                        val = Operations.Divide(a, b);
                        break;
                    case 5:
                        val = Operations.Mod(a, b);
                        break;
                    case 6:
                        val = Operations.Increase( ref a);
                        break;
                    case 7:
                        val = Operations.Decrease(ref a);
                        break;
                    
                }//end of switch

                Console.WriteLine("\n\n");
                Console.WriteLine("Your result: "+ Convert.ToString(val));
                Console.WriteLine("\n\n");

            } //end of while
            
        } //end of Main
    }

}
