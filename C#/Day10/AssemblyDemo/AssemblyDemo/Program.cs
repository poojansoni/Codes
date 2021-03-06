using System;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"D:\Capgemini\CodeC#\Poojan Soni\Day10\AssemblyDemo\ProductLibrary\bin\Debug\netstandard2.0\ProductLibrary.dll");

            foreach (Type a in assembly.GetTypes())
            {

                if (a.Name == "Products")
                {
                    object obj = assembly.CreateInstance("ProductLibrary.Products");

                    PropertyInfo[] property = a.GetProperties();

                    MethodInfo methodInfo = a.GetMethod("CalculatePrice");
                    
                    string result = (string)methodInfo.Invoke(obj,null);
                    Console.WriteLine(result);

                }
            }
        }
    }
}
