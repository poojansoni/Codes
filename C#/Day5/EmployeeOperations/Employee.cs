using System;

namespace EmployeeOperations
{
    public class Employee

    {
        public Employee()
        {
            this.EmpName = "no name";
            this.EmpBatch = "no batch";
            this.IsPresent = "no";
            this.WorkingHours = 0;
        }

        public Employee(string name, string IsPresnt, string batch, int hours)
        {
            this.EmpName = name;
            this.EmpBatch = batch;
            this.IsPresent = IsPresnt;
            this.WorkingHours = hours;
        }

        internal string date = "23-02-2021";

        public string EmpName { get; set; }
        
        public string EmpBatch { get; set; }

        public string IsPresent { get; set; }

        public double WorkingHours { get; set; }

        public double HourstoMinutes()
        {
            return (this.WorkingHours * 60);
        }
        public double HourstoSeconds()
        {
            return (this.HourstoMinutes() * 60);
        }

        /*public void AddName(ref Employee emp, string name)
        {
            emp.EmpName = name;
        }
        public void AddIsPresent(string prsnt)
        {
            this.IsPresent = prsnt;
        }
        public void Addhours(int hours)
        {
            this.WorkingHours = hours;
        }
        public void AddBatch(string batch)
        {
            this.EmpBatch = batch;
        }*/
    }
}

