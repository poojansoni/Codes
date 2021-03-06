using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Visual Studio!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String billNumber = billno.Text;
            String prodDetails = prod.Text;
            String quantity = qnt.Text;

            decimal totAmnt = 20000 * Convert.ToInt32(quantity);

            //appending text in textbox amnt
            amnt.AppendText(Convert.ToString(totAmnt));

            //MessageBox.Show("Bill No: " + billNumber + "\n" + "Product Details: " + prodDetails + "\n" + "Quantity: " + quantity + "\n" );
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
