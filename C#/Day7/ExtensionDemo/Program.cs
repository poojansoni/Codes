using System;
using EnumDemo;
namespace ExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any string: ");
            string str = Console.ReadLine();
            Console.WriteLine("\nThe Word count is: " + str.WordCount());

            ExtensionTest ext = new ExtensionTest();
            Console.WriteLine("\nExtension Dispaly: " );
            ext.Display();
            Console.WriteLine("\nExtension Print: ");
            ext.Print();
            Console.WriteLine("\nExtension New extended Method: ");
            ext.NewMethod();
        }
    }

    public static class Utility
    {
        //this keyword will call string class extension.. if use int ..it becomes int extension
        public static int WordCount(this string str) 
        {
            return str.Split(new char[] { ' ' }).Length;
        }
    }

    public static class UtilityCustom
    {
        public static void NewMethod(this ExtensionTest ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }
}
