using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_understanding
{
    public class Employee
    {
        //Variable
        int empNo;
        string empName;

        //property
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        //method
        public Employee ModifyEmployee(object empNo, object empName)
        {
            var mEmpId = "10" + empNo;
            var mEmpName = "Mr/Ms. " + empName;

            Employee employee = new Employee();
            employee.EmpNo = Convert.ToInt32(mEmpId);
            employee.EmpName = mEmpName;

            //OR

            /*Employee employee = new Employee
            {
                EmpNo = Convert.ToInt32(mEmpId),
                EmpName = mEmpName
            };*/

            return employee;
        }
    }
}
