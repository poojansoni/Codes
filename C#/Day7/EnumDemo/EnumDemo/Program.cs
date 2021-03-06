using System;

namespace EnumDemo
{
    class Program
    {
        enum Direction { North, South, East, West }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Direction: ");
            int dir = Convert.ToInt32(Console.ReadLine());
            switch (dir)
            {
                case 0:
                    Console.WriteLine(dir + " is " + Direction.North);
                    break;
                case 1:
                    Console.WriteLine(dir + " is " + Direction.South);
                    break;
                case 2:
                    Console.WriteLine(dir + " is " + Direction.East);
                    break;
                case 3:
                    Console.WriteLine(dir + " is " + Direction.West);
                    break;
                default:
                    Console.WriteLine("No such Direction present");
                    break;
            }
            
        }
    }

    public class ExtensionTest
    {
        public void Display()
        {
            Console.WriteLine("I m in Display");
        }

        public void Print()
        {
            Console.WriteLine("I m in Print");
        }
    }
}
