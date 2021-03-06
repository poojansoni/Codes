using CommonMethods;
using System;


using System.Windows.Forms;

namespace StudentIdentification
{
    public partial class s_name : Form
    {
        public s_name()
        {
            InitializeComponent();
        }
        public class Student
        {
            //vars
            public int studentId;
            public string studentName;

            //method
            public string getStudentName(string sNo)
            {
                if (sNo == "21")
                {
                    
                    return "Poojan Soni                    ";
                }
                else if (sNo == "22")
                {
                    
                    return "Rasika Nilatkar                     ";
                }
                else if (sNo == "23")
                {
                    return "Ritik Nagpure                      ";
                }
                else if (sNo == "24")
                {
                    return "Sakshi Shukla                     ";
                }
                else if (sNo == "25")
                {
                    return "Shubh Saxena                     ";
                }
                else
                {
                    return "Not in this group!                  ";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = s_id.Text;


            //Object - Runtime Entity of a class

            Student st = new Student();

            //Calling the Class Method and Pass the Value 

             s_n.AppendText(st.getStudentName(id));

            Calculations obj = new Calculations();

            MessageBox.Show(Convert.ToString(obj.AddNumbers(23, 19)));

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}

