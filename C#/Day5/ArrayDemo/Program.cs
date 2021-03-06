using System;
using ArrayClass;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of subjects: ");
            int len = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n..... Initializing the Marks Array ......");
            int[] arr = ArrayOperations.InitializeArrayInt(len);

            Console.WriteLine("..... Add Marks ......");
            ArrayOperations.AddElementsInt(ref arr);

            ArrayOperations.PrintArray(arr);

            Console.Write("Total Marks: " + ArrayOperations.SumArray(arr)+"\n");

            Console.Write("\nAverage Marks: " + ArrayOperations.AverageArray(arr)+"\n");

            Console.Write("\nPercentage Achieved: " + ArrayOperations.PercentageArray(arr) + "\n\n");

        }
    }
}