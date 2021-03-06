using System;
using EmployeeOperations;
namespace EmployeeAttendance
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Employees:");
            int number_of_Employees = Convert.ToInt32(Console.ReadLine());

            Employee[] employees = new Employee[number_of_Employees];
            for(int count = 0; count < number_of_Employees; count++)
            {
                employees[count] = new Employee();
            }

            for (int count = 0; count < number_of_Employees; count++)
            {
                Console.WriteLine("\nPlease Add the Name of " + count + "th Employee: \n");
                employees[count].EmpName = Console.ReadLine();

                Console.WriteLine("\nEnter if the employee is present or absent: \n");
                employees[count].IsPresent = Console.ReadLine();

                Console.WriteLine("\nPlease give the working Hours: \n");
                employees[count].WorkingHours = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease Enter the Batch : \n");
                employees[count].EmpBatch = Console.ReadLine();

                Console.WriteLine("______________________________________________________________________________\n");
            }

            Console.WriteLine("\nOutput=>\n");
            for (int count = 0; count < number_of_Employees; count++)
            {
                Console.WriteLine("Mr./Ms. " + employees[count].EmpName + " , B.Tech - " + employees[count].EmpBatch);
               // Console.WriteLine("Date: " + employees[count].date);
                Console.WriteLine("Working Hours: " + employees[count].WorkingHours + "\nWorking Minutes: " + employees[count].HourstoMinutes() + "\nWorking Seconds: " + employees[count].HourstoSeconds() + "\n");
                Console.WriteLine("______________________________________________________________________________\n");
            }

        }


    }
}
