using System;

namespace ConsoleDemo
{
    class Manager
    {
        public string Name { get; set; }
    }

    class Employee
    {
        public int No { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();
             Console.WriteLine("welcome "+ name);*/

            //Getting input1
            Console.Write("Enter Your String value: ");
            string val1 = Console.ReadLine();

            //Getting input2
            Console.WriteLine("Enter Your String value2: ");
            string val2 = Console.ReadLine();

            Manager manager = new Manager();
            manager.Name = "12312";
            //manager.Name = "TestManager";

            Employee employee = new Employee();
            employee.No = 12312;

            //Equals operation of Object - Support Type 
            if (employee.Equals(manager))
            {
                Console.WriteLine("Enter Values are same in Equals");
            }

            //== operation - Value comparison
            if (manager.Name == employee.No.ToString())
            {
                Console.WriteLine("Enter Values are same in ==");
            }

            Console.ReadLine();
        }
    }

}
