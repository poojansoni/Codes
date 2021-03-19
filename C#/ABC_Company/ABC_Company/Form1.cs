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

namespace ABC_Company
{
    public partial class Form1 : Form
    {
        private string cnct = @"Data Source=DESKTOP-0LC4GSM;Initial Catalog=ABC_Company;Integrated Security=True";
        static int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExecScalar();
        }

        private void ExecScalar()
        {
            int count = 0;

            using (SqlConnection connection = new SqlConnection(cnct))
            {
                string cmd = "Select count(*) from Employee_attendance where p_date = convert(date,getdate())";
                string cmd2 = "Select count(*) from Employee";

                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    count = Convert.ToInt32(command.ExecuteScalar());
                }

                using (SqlCommand comm2 = new SqlCommand(cmd2, connection))
                {
                    comm2.CommandType = CommandType.Text;

                    id = Convert.ToInt32(comm2.ExecuteScalar());

                }
                connection.Close();
            }
            total_count.Text = Convert.ToString(count);
        }

        private void ConnectByDataReader()
        {

            List<string> result = new List<string>();
            if (empID.Text.Equals(""))
            {
                result.Add("Please enter ID first!");
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(cnct))
                {
                    int empid = Convert.ToInt32(empID.Text);
                    string cmd = "SELECT * FROM Employee where EmployeeId = " + empid;

                    using (SqlCommand command = new SqlCommand(cmd, sqlConnection))
                    {
                        command.CommandType = CommandType.Text;

                        sqlConnection.Open();

                        SqlDataReader dataReader = command.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                result.Add("______________________________________________");
                                result.Add("EmployeeId: " + dataReader["EmployeeId"].ToString());
                                result.Add("Name: " + dataReader["FirstName"].ToString() + " " + dataReader["LastName"].ToString());
                                result.Add("Phone No: " + dataReader["Phone"].ToString());
                                result.Add("EmailId: " + dataReader["MailId"].ToString());
                                result.Add("DepartmentId: " + dataReader["DepartmentId"].ToString());
                                result.Add("______________________________________________");
                                result.Add("");
                            }
                        }

                        sqlConnection.Close();


                    }
                }
            }

            outputBox.Items.Clear();
            foreach (string val in result)
            {
                outputBox.Items.Add(val);
            }
        }

        private List<string> ExecNonQuery(string Fname, string Lname, int Phone, string District, string Departid)
        {
            List<string> res = new List<string>();
            using (SqlConnection connection = new SqlConnection(cnct))
            {
                string cmd = "INSERT INTO Employee(EmployeeId,FirstName,LastName,Phone,District,DepartmentId)values (@e_id,@Fname,@Lname,@phn,@Dist,@Depid)";
                using (SqlCommand command = new SqlCommand(cmd, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@e_id", ++id);
                    command.Parameters.AddWithValue("@Fname", Fname);
                    command.Parameters.AddWithValue("@Lname", Lname);
                    command.Parameters.AddWithValue("@phn", Phone);
                    command.Parameters.AddWithValue("@Dist", District);
                    command.Parameters.AddWithValue("@Depid", Departid);

                    connection.Open();

                    int check = command.ExecuteNonQuery();

                    if (check > 0)
                    {
                        res.Add("Sucessfully Inserted Employee");
                        res.Add("Employee Id: " + (id));
                        res.Add("Name: " + Fname + " " + Lname);
                        res.Add("Phone: " + Phone);
                        res.Add("District: " + District);
                        res.Add("Department Id: " + Departid);
                    }
                    else
                    {
                        res.Add("Error Occured");
                    }
                }
            }

            return res;
        }

        private void InsertRec_Click(object sender, EventArgs e)
        {
            outputBox.Items.Clear();
            if (Lname.Text.Equals("") || Fname.Text.Equals("") || Phone.Text.Equals("") || district.Text.Equals("") || depid.Text.Equals(""))
            {
                outputBox.Items.Add("Enter the Inputs!");
            }
            else
            {
                List<string> res = ExecNonQuery(Fname.Text, Lname.Text, Convert.ToInt32(Phone.Text), district.Text, depid.Text);
                foreach (string str in res)
                { outputBox.Items.Add(str); }
            }
        }

        private void updt_Click(object sender, EventArgs e)
        {

            if (Lname.Text.Equals("") || Fname.Text.Equals("") || Phone.Text.Equals("") || district.Text.Equals("") || depid.Text.Equals(""))
            {
                outputBox.Items.Clear();
                outputBox.Items.Add("Enter the Inputs to update!");
            }
            else
            {

                SqlConnection connection = new SqlConnection(cnct);
                SqlCommand command = new SqlCommand();


                command.Connection = connection;
                command.CommandText = "UPDATE Employee SET FirstName=@Fname, " +
                "LastName=@Lname, Phone=@phn, District=@Dist, DepartmentId=@Depid " +
                "WHERE EmployeeId in (SELECT EmployeeId from Employee where FirstName = @Fname and LastName = @Lname)";

                command.Parameters.Clear();

                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Fname", Fname.Text);
                command.Parameters.AddWithValue("@Lname", Lname.Text);
                command.Parameters.AddWithValue("@phn", Convert.ToInt32(Phone.Text));
                command.Parameters.AddWithValue("@Dist", district.Text);
                command.Parameters.AddWithValue("@Depid", depid.Text);


                try
                {


                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    outputBox.Items.Clear();
                    if (result > 0)
                    {
                        /*MessageBox.Show("Update Successful!");*/

                        outputBox.Items.Add("Sucessfully Updated Employee");
                        outputBox.Items.Add("Name: " + Fname.Text + " " + Lname.Text);
                        outputBox.Items.Add("Phone: " + Phone.Text);
                        outputBox.Items.Add("District: " + district.Text);
                        outputBox.Items.Add("Department Id: " + depid.Text);
                    }
                    else
                        outputBox.Items.Add("Updated Failed");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occured.");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ShowDet_Click(object sender, EventArgs e)
        {
            ConnectByDataReader();
        }

        private void getDEmp_Click(object sender, EventArgs e)
        {
            if (getDistrict.Text.Equals(""))
            {
                outputBox.Items.Clear();
                outputBox.Items.Add("Enter the City!");
            }
            else
            {
                outputBox.Items.Clear();
                List<string> result = getSortedEmCity(getDistrict.Text);
                foreach (string val in result)
                {
                    outputBox.Items.Add(val);
                }
            }

        }

        private List<string> getSortedEmCity(string district)
        {
            List<string> res = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(cnct))
            {
                string cmd = "SELECT * FROM Employee";

                using (SqlCommand command = new SqlCommand(cmd, sqlConnection))
                {
                    command.CommandType = CommandType.Text;

                    sqlConnection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet("ABC_Company");
                        dataAdapter.Fill(dataSet,"Employee");
                     
                        DataView view = new DataView(dataSet.Tables["Employee"]);
                        view.RowFilter = "District = "+"'"+district+"'";
                        view.Sort = "FirstName ASC";

                        res.Add("Employee Names, living in: " + district);
                        res.Add("_____________________________________________");
                        for (int i = 0; i < view.Count; i++)
                        {
                            res.Add(view[i]["FirstName"] + " " + view[i]["LastName"]);
                        }
                    }
                }
            }
            return res;
        }

        private void SalDet_Click(object sender, EventArgs e)
        {
            if (empID.Text.Equals(""))
            {
                outputBox.Items.Clear();
                outputBox.Items.Add("Enter the ID first!");
            }
            else
            {
                outputBox.Items.Clear();
                List<string> result = getSalaryDet(Convert.ToInt32(empID.Text));
                foreach (string val in result)
                {
                    outputBox.Items.Add(val);
                }
            }
        }

        private List<string> getSalaryDet(int emp_id)
        {
            List<string> res = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(cnct))
            {
                SqlConnection sqlConnection2 = new SqlConnection(cnct);
                string cmd = "SELECT * FROM Salary where EID = " + emp_id;
                string cmd2 = "SELECT FirstName,LastName FROM Employee where EmployeeId = " + emp_id;

                using (SqlCommand command = new SqlCommand(cmd, sqlConnection))
                {
                    command.CommandType = CommandType.Text;
                    SqlCommand command2 = new SqlCommand(cmd2, sqlConnection2);
                    sqlConnection.Open();
                    sqlConnection2.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    SqlDataReader dataReader2 = command2.ExecuteReader();
                    if (dataReader2.HasRows)
                    {
                        while (dataReader2.Read())
                        {
                            res.Add("______________________________________________");
                            res.Add("Name: " + dataReader2["FirstName"].ToString() + " " + dataReader2["LastName"].ToString());
                        }

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                res.Add("BasicAmount: " + dataReader["BasicAmount"].ToString());
                                res.Add("DAAmount: " + dataReader["DAAmount"].ToString());
                                res.Add("HRAAmount: " + dataReader["HRAAmount"].ToString());
                                res.Add("PFAmount: " + dataReader["PFAmount"].ToString());
                                res.Add("TotalSalary: " + dataReader["TotalSalary"].ToString());
                                res.Add("Bonus: " + dataReader["Bonus"].ToString());
                                res.Add("********");
                                res.Add("Gross: " + dataReader["Gross"].ToString());
                                res.Add("********");
                                res.Add("______________________________________________");
                            }
                        }
                        else
                        {
                            res.Add("Error in getting Salary details");
                        }
                    }
                    else
                    {
                        res.Add("Error in getting Name");
                    }

                    sqlConnection.Close();
                }
            }

                    return res;
        }

        private void getAttendance_Click(object sender, EventArgs e)
        {
            if (empID.Text.Equals("") || start_date.Text.Equals("") || end_date.Text.Equals(""))
            {
                outputBox.Items.Clear();
                outputBox.Items.Add("Enter the ID/start date/end date first!");
            }
            else
            {
                outputBox.Items.Clear();
                List<string> result = CallStoreprocWithParama(Convert.ToInt32(empID.Text), start_date.Text, end_date.Text);
                foreach (string val in result)
                {
                    outputBox.Items.Add(val);
                }
            }
            
        }

        private List<string> CallStoreprocWithParama(int emp, string start, string end)
        {
            List<string> res = new List<string>();
           
            using (SqlConnection connection = new SqlConnection(cnct))
            {
                using (SqlCommand cmd = new SqlCommand("GetAttendance", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empid", emp);
                    cmd.Parameters.AddWithValue("@start_date", start);
                    cmd.Parameters.AddWithValue("@end_dtae", end);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    res.Add("Total Attendance is: ");
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            res.Add(reader[0].ToString());
                        }
                    }
                }
            }
            return res;
        }
    }
}