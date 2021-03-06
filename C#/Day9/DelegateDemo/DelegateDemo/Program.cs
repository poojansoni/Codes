using System;

namespace DelegateDemo
{
    //Step 1
    public delegate void Print(int value);
    class Program
    {
        static void Main(string[] args)
        {

            Testing testing = new Testing();

            // testing.MethodName();
            int i = 0;

            // //Step 2 - Method Imp
            // public int MethodName = delegate
            Print res = delegate (int value)
            {
                value += i;
                value = value * i;
            };

            Func<int, int, int> multiplyTwoNumbers = (a, b) => { return a * b; };
            multiplyTwoNumbers(5,3);
        }
    }

    class Testing
    {

    }
}
    
