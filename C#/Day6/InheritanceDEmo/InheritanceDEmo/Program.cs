using System;

namespace InheritanceDEmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            professor.Name = "Tesign";

            LabAttender labAttender = new LabAttender();
            labAttender.Name = "Lab";

            labAttender.getSalary(labAttender.eNo);
        }
    }
    public class Employee
    {
        public string Name;

        public int eNo;

        public int salary;

        public int getSalary(int eNo)
        {
            int sal = 0;
            //if-else code to get sal according to department
            return salary;
        }

    }
    public class Professor : Employee
    {
        public string mail;

        public string dept;
    }

    public class Watchman : Employee
    {
        public string design;

        public int Horkingshours;

        public string shift;
    }

    public class LabAttender : Employee
    {
        public string depart;

        public string LabName;
    }
}
