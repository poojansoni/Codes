using System;
using System.Text;
using StringModifierscmd;
namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            string demo = Console.ReadLine();
            Console.WriteLine(".....Creating as a String Builder.....");
            StringBuilder sb = new StringBuilder(demo);
            Console.WriteLine("Created a String Builder Mutable string: "+ sb);

            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Enter 0: To Exit\n1: Append\n2: Insert\n3: Remove\n4: Replace\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye!");
                        condition = false;
                        break;

                    case 1:
                        StringModifier.AppendString(ref sb);
                        Console.WriteLine("\nNewly Appended string " + sb);
                        break;
                    case 2:
                        StringModifier.InsertString(ref sb);
                        Console.WriteLine("\nNewly Inserted string " + sb);
                        break;

                    case 3:
                        StringModifier.RemoveString(ref sb);
                        Console.WriteLine("\nNewly Remmoved string " + sb);
                        break;
                    case 4:
                        StringModifier.ReplaceString(ref sb);
                        Console.WriteLine("\nNewly Replaced string " + sb);
                        break;
                    

                }//end of switch
            } //end of while
        }
    }

    
}
