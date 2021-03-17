using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOnetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetByDataReader_Click(object sender, EventArgs e)
        {
            ConnectByDataReader();
        }

        private void ConnectByDataReader()
        {

            //1> Setup connection string:
            // 1.Data Server(sql) = Data Source //"Server Name"
            //2. DataBase Name = Initial Catalog=Northwind
            //3. UserName      = Sa user
            //4. Password      = sa Password
            //5. Security Mode = Integrated Security=True             

            string connectionString = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";

            //Step 2 : Create SqlConnection object and assign connection string
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                //Step 3 : create a SqlCommand Object
                string cmd = "SELECT FirstName, City FROM Employees where City ='Seattle'";

                using (SqlCommand command = new SqlCommand(cmd,sqlConnection))
                {

                    //Step 4: Set Command Type
                    command.CommandType = CommandType.Text;

                    sqlConnection.Open();

                    //Step 5 : 2 options - 1. DataReader , 2. Data Adapter
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string name = dataReader["FirstName"].ToString();

                        string city = dataReader["City"].ToString();

                        MessageBox.Show("Name: "+name+ " City: " + city);
                    }

                    sqlConnection.Close();
                }
            }
        }

        private void DataAdapter_Click(object sender, EventArgs e)
        {
            GetByDataAdapter();
        }

        private void GetByDataAdapter()
        {
            string cnct = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cnct))
            {
                string cmd = "Select FirstName,City from Employees where City='Seattle'";
                using (SqlCommand command = new SqlCommand(cmd,connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    // Step 5 : 2 options - 1.DataReader , 2.Data Adapter
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        connection.Close();
                        foreach (DataRow row in dataSet.Tables[0].Rows)
                        {
                            string name = row["FirstName"].ToString();

                            string city = row["City"].ToString();

                            MessageBox.Show("Name: " + name + " City: " + city);
                        }
                    }
                }
            }
        }
    }
}

