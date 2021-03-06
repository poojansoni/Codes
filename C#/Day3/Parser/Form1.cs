using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var val = value.Text;

            try
            {
                checkParse(val);
            }
            catch (ArgumentNullException )
            {

                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType());
            }
           
            

                int i = Convert.ToInt32(val);
              
                string s = val;
                double dob = Double.Parse(val);
                float fl = float.Parse(val);

                intr.AppendText(Convert.ToString(i) + " Type: " + Convert.ToString(i.GetType()));

               

                str.AppendText(s + " Type: " + Convert.ToString(s.GetType()));

                dobr.AppendText(dob + " Type: " + Convert.ToString(dob.GetType()));

                flot.AppendText(fl + " Type: " + Convert.ToString(((float)fl).GetType()));
           
        }

        public static void checkParse(string input)
        {

            // declaring Int32 variable 
            int val;

            // getting parsed value 
            val = Int32.Parse(input);
            Console.WriteLine("'{0}' parsed as {1}", input, val);
        }
    }

    
} 

