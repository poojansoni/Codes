using System;
using System.Text;
namespace StringModifierscmd
{
    public class StringModifier
    {
        public static void AppendString(ref StringBuilder sb)
        {
            Console.WriteLine("Enter a string to append: ");
            sb.AppendLine(Console.ReadLine());
        }

        public static void RemoveString(ref StringBuilder sb)
        {
            Console.WriteLine("Enter the position from where it should be removed ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Length that should be removed ");
            int len = Convert.ToInt32(Console.ReadLine());
            sb.Remove(pos, len);
        }

        public static void InsertString(ref StringBuilder sb)
        {
            Console.WriteLine("Enter the position for the Insertion: ");
            int lineno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the String to be Inserted: ");
            sb.Insert(lineno, Console.ReadLine());
        }

        public static void ReplaceString(ref StringBuilder sb)
        {
            Console.WriteLine("Enter the String to be Replaced: ");
            string replace = Console.ReadLine();
            Console.WriteLine("Enter the String that should be added: ");
            sb.Replace(replace, Console.ReadLine());
        }
    }
}
