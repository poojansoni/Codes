using System;

namespace Operators
{
    public class Operations
    {

        //Arithmatic operators:
        public static int Add(int a = 0, int b = 0)
        {
            return a + b;
        }

        public static int Subtract(int a = 0, int b = 0)
        {
            return a - b;
        }
        public static int Multiply(int a = 0, int b = 1)
        {
            return a * b;
        }

        public static double Divide(int a = 0, int b = 1)
        {
            return a / b;
        }

        public static int Mod(int a = 0, int b = 1)
        {
            return a % b;
        }

        public static int Increase(ref int a)
        {
            return ++a;
        }

        public static int Decrease(ref int a)
        {
            return --a;
        }

        //Relational operators
        public static bool equalequal(int a, int b)
        {
            return (a == b);
        }

        public static bool NotEqual(int a, int b)
        {
            return (a != b);
        }

        public static bool IsGreater(int a, int b)
        {
            return (a > b);
        }
        public static bool IsLess(int a, int b)
        {
            return (a < b);
        }

        public static bool IsgreaterOrEqual(int a, int b)
        {
            return (a >= b);
        }
        public static bool IsLessOrEqual(int a, int b)
        {
            return (a <= b);
        }

        //Logical operators:

    }
}
