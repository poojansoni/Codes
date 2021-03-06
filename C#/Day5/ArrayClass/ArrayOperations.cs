using System;

namespace ArrayClass
{
    public class ArrayOperations
    {
        //Initializing the size
        public static string[] InitializeArrayString(int len)
        {
            string[] arr = new string[len];
            return arr;
        }

        public static int[] InitializeArrayInt(int len)
        {
            int[] arr = new int[len];
            return arr;
        }

        //Adding the elements
        public static void AddElementsStr(ref string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\nEnter " + (i + 1) + "th value: ");
                arr[i] = Console.ReadLine();
            }
        }

        public static void AddElementsInt(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\nEnter " + (i + 1) + "th value: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //Printing the array
        public static void PrintArray(int[] arr)
        {
            int len = arr.Length;
            Console.Write("\nThe Array created is: ");
            Console.Write("{");
            for (int i = 0; i < len - 1; i++)
            {
                Console.Write(" " + arr[i] + ",");
            }
            Console.Write(" " + arr[len - 1] + " }\n\n");
        }

        //Sum of the array
        public static int SumArray(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        //average of the array
        public static double AverageArray(int[] arr)
        {
            int len = arr.Length;
            int avg = SumArray(arr) / len;
            return avg;
        }

        //Percentage array
        public static double PercentageArray(int[] arr)
        {
            Console.Write("\nEnter the Max Marks for a subject: ");
            int fullmk = Convert.ToInt32(Console.ReadLine());
            double percent = (AverageArray(arr)*100)/fullmk;
            return percent;
        }
    }
}
