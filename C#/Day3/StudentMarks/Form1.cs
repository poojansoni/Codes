using System;
using StudentGrade;
using System.Windows.Forms;

namespace StudentMarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, s5;
            s1 = Convert.ToInt32(sem1.Text);
            s2 = Convert.ToInt32(sem2.Text);
            s3 = Convert.ToInt32(sem3.Text);
            s4 = Convert.ToInt32(sem4.Text);
            s5 = Convert.ToInt32(sem5.Text);

            MarksCalculations calculate = new MarksCalculations();

            double Avg = calculate.AvgMark(s1, s2, s3, s4, s5);
            avge.AppendText(Convert.ToString(Avg));

            string gradeif = calculate.CalcGradeif(Avg);
            ifcase.AppendText(gradeif);

            string gradeswitch = calculate.CalcGradeSwitch(Avg);
            switchcase.AppendText(gradeswitch);

            

        }
    }
}
