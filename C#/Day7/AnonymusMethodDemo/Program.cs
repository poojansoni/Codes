using System;

namespace AnonymusMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //normal way of initialization
            Employee emp = new Employee();
            emp.eno = 5;
            emp.eMail = "Poojan@gmail.com";
            emp.eName = "Poojan Soni";
            emp.demo[0] = 1;
            emp.demo[1] = 1;



            //Annonymus way of Initialization
            Employee employee = new Employee
            {
                eno = 5, 
                eName = "Poojan", 
                eMail = "Poojan@gmail.com", 
                demo = new int[] { 0,1,8}
            };

            //Annonymus Array
            Employee[] e = new Employee[]
            {
                new Employee {eno = 5, eMail = "lol", eName = "lol" ,demo = new int[] { 0,2,8}},
                new Employee {eno = 5, eMail = "lol", eName = "lol" ,demo = new int[] { 0,1,9}}
            };

        }
    }

    public class Employee
    {
        
        public int[] demo { get; set; }
        
        public int eno { get; set; }
        public string eName { get; set; }
        public string eMail { get; set; }

        public Employee()
        {
            eno = 2;
            eName = "Testing";
            eMail = "Test@gmail.com";
        }
    }
}
