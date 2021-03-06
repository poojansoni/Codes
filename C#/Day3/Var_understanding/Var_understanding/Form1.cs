using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Var_understanding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                EmpNo = Convert.ToInt32(empNo.Text),
                EmpName = empName.Text
            };
            
            emp.ModifyEmployee(emp.EmpNo, emp.EmpName);
            MessageBox.Show("Modified Version: " + emp.EmpNo + emp.EmpName);
        }
    }
}
