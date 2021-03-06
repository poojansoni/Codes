using System;

namespace RefandOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Ref based Increament: " + Modify.Increase(ref a));
            
            Console.WriteLine("\n\n");

            Console.WriteLine("Out based Assignment: " + Modify.Assign(out a));

            Console.WriteLine();
        }
    }

    class Modify
    {
        public static int Increase(ref int a)
        {
            return ++a;
        }

        public static int Assign(out int a)
        {
            return a = 5;
        }
    }
}
