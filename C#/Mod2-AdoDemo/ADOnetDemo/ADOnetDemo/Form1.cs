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
            List<string> result = ConnectByDataReader();
            outputBox.Items.Clear();
            outputBox.Items.Add("DataReader Output:\n");
            foreach (string val in result)
            {
                outputBox.Items.Add(val);
            }
        }

        private List<string> ConnectByDataReader()
        {
            List<string> res = new List<string>();
            //1> Setup connection string:
            // 1.Data Server(sql) = Data Source //"Server Name"
            //2. DataBase Name = Initial Catalog=Northwind
            //3. UserName      = Sa user
            //4. Password      = sa Password
            //5. Security Mode = Integrated Security=True             

            string connectionString = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";

            //Step 2 : Create SqlConnection object and assign connection string
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                //Step 3 : create a SqlCommand Object
                string cmd = "SELECT FirstName, City FROM Employees where City ='Seattle'";

                using (SqlCommand command = new SqlCommand(cmd, sqlConnection))
                {

                    //Step 4: Set Command Type
                    command.CommandType = CommandType.Text;

                    sqlConnection.Open();

                    //Step 5 : 2 options - 1. DataReader , 2. Data Adapter
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            res.Add("First Name: " + dataReader["FirstName"].ToString() + ", City: " + dataReader["City"].ToString());
                        }
                    }

                    sqlConnection.Close();
                }
            }
            return res;
        }

        private void DataAdapter_Click(object sender, EventArgs e)
        {
            List<string> result = GetByDataAdapter();
            outputBox.Items.Clear();
            outputBox.Items.Add("DataAdapter Output:\n");
            foreach (string val in result)
            {
                outputBox.Items.Add(val);
            }
        }

        private List<string> GetByDataAdapter()
        {
            List<string> res = new List<string>();
            string cnct = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cnct))
            {
                string cmd = "Select FirstName,City from Employees where City='Seattle'";
                using (SqlCommand command = new SqlCommand(cmd, connection))
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
                            res.Add("First Name: " + row["FirstName"].ToString() + ", City: " + row["City"].ToString());
                        }
                    }
                }
            }
            return res;
        }

        private void ExecScalar_Click(object sender, EventArgs e)
        {
            int result = ExecuteScalar();
            outputBox.Items.Clear();
            outputBox.Items.Add("Executed Scalar Output:");
            outputBox.Items.Add("Total Cities(count) : " + result);
        }

        private int ExecuteScalar()
        {
            int count = 0;
            string cnct = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cnct))
            {
                string cmd = "Select count(city) from Employees";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
                connection.Close();
            }
            return count;
        }

        private void InsertQuery_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
            if (Esal.Text.Equals("") || Ename.Text.Equals(""))
            {
                outputBox.Items.Add("Enter the Inputs!");
            }
            else
            {
                int sal = Convert.ToInt32(Esal.Text);
                string name = Ename.Text;
                List<string> res = ExecNonQuery(name, sal);
                foreach (string str in res)
                { outputBox.Items.Add(str); }
            }
        }

        private List<string> ExecNonQuery(string name, int sal)
        {
            List<string> res = new List<string>();

            string cnct = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cnct))
            { 
                string cmd = "INSERT INTO Employee_Test values ('" + name + "'," + sal + ")";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    int check = command.ExecuteNonQuery();

                    if (check > 0)
                    {
                        res.Add("Sucessfully Inserted Employee");
                        res.Add("Name: " + name);
                        res.Add("Salary: " + sal);
                    }
                    else
                    {
                        res.Add("Error Occured");
                    }
                }
            }

            return res;
        }

        private void InsertWParam_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
            if (Esal.Text.Equals("") || Ename.Text.Equals(""))
            {
                outputBox.Items.Add("Enter the Inputs!");
            }
            else
            {
                int sal = Convert.ToInt32(Esal.Text);
                string name = Ename.Text;
                List<string> res = ExecInsertParam(name, sal);
                foreach (string str in res)
                { outputBox.Items.Add(str); }
            }
        }

        private List<string> ExecInsertParam(string ename, int esal)
        {
            List<string> res = new List<string>();

            string cnct = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cnct))
            {

                string cmd = "INSERT INTO Employee_Test values (@empName,@empSal)";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@empName", ename);
                    command.Parameters.AddWithValue("@empSal", esal);
                    connection.Open();

                    int check = command.ExecuteNonQuery();

                    if (check > 0)
                    {
                        res.Add("Sucessfully Inserted Employee");
                        res.Add("Name: " + ename);
                        res.Add("Salary: " + esal);
                    }
                    else
                    {
                        res.Add("Error Occured");
                    }
                    
                }
            }
            return res;
        }

        private List<string> CallStoreprocWithParama(int orderId)
        {
            List<string> res = new List<string>();
            string cnct = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=Northwind;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(cnct))
            { 
                using (SqlCommand cmd = new SqlCommand("CustOrdersDetail", connection))
                {
                   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            res.Add(reader["ProductName"].ToString());
                        }
                    }
                }
            }
            return res;
        }

        private void custOrderdet_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
            if (orderId.Text.Equals(""))
            {
                outputBox.Items.Add("Enter the Order ID!");
            }
            else
            {
                int orderid = Convert.ToInt32(orderId.Text);
                List<string> res = CallStoreprocWithParama(orderid);
                if (res.Count == 0)
                {
                    outputBox.Items.Add("No Products for " + orderid + " Order ID!");
                }
                else
                {
                    outputBox.Items.Add("Product Names for " + orderid + " Order ID:");
                    foreach (string str in res)
                    { outputBox.Items.Add(str); }
                }
            }
        }
    }
}


