using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System
{
    public partial class Employee_register : Form
    {
        private string connectionString = @"Data Source=ISHAN_SELLAHEWA;Initial Catalog='Grifindo Toys Payroll System';Integrated Security=True;";
        public Employee_register()
        {
            InitializeComponent();
            LoadEmployeeIDs();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to update data in the "Employee Details" table
                    string updateQuery = @"UPDATE [Employee_Details]
                                   SET [Full Name] = @FullName,
                                       [Contact Number] = @ContactNumber,
                                       [Email Address] = @EmailAddress,
                                       [Address] = @Address,
                                       [Monthly Salary ($)] = @MonthlySalary,
                                       [Overtime Rate (hour)] = @OvertimeRate,
                                       [Allowances ($)] = @Allowances
                                   WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Set parameter values from your text boxes
                        command.Parameters.AddWithValue("@ID", int.Parse(txtid.Text));
                        command.Parameters.AddWithValue("@FullName", txtfn.Text);
                        command.Parameters.AddWithValue("@ContactNumber", int.Parse(txtcn.Text));
                        command.Parameters.AddWithValue("@EmailAddress", txtea.Text);
                        command.Parameters.AddWithValue("@Address", txtadd.Text);
                        command.Parameters.AddWithValue("@MonthlySalary", int.Parse(txtms.Text));
                        command.Parameters.AddWithValue("@OvertimeRate", int.Parse(txtor.Text));
                        command.Parameters.AddWithValue("@Allowances", int.Parse(txtall.Text));

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                            txtid.Clear();
                            txtfn.Clear();
                            txtcn.Clear();
                            txtea.Clear();
                            txtadd.Clear();
                            txtms.Clear();
                            txtor.Clear();
                            txtall.Clear();
                            comboBoxID.Text = "";
                            txtid.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. The specified employee ID was not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Grieindo_Toys_Login form = new Grieindo_Toys_Login();
            form.Show();
            this.Close();
        }

        private void LoadEmployeeIDs()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = @"SELECT [ID] FROM [dbo].[Employee_Details]";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            comboBoxID.Items.Add(reader["ID"]);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            {
                txtid.Clear();
                txtfn.Clear();
                txtcn.Clear();
                txtea.Clear();
                txtadd.Clear();
                txtms.Clear();
                txtor.Clear();
                txtall.Clear();
                comboBoxID.Text = "";
                txtid.Focus();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnmainmenu_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
            form.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtfn.Clear();
            txtcn.Clear();
            txtea.Clear();
            txtadd.Clear();
            txtms.Clear();
            txtor.Clear();
            txtall.Clear();
            comboBoxID.Text = "";
            txtid.Focus();
        }

        private void Employee_register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_Toys_Payroll_SystemDataSet2.Employee_Details' table. You can move, or remove it, as needed.
          //  this.employee_DetailsTableAdapter.Fill(this.grifindo_Toys_Payroll_SystemDataSet2.Employee_Details);
           // txtid.Focus();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = @"INSERT INTO [dbo].[Employee_Details] ([ID], [Full Name], [Contact Number], [Email Address], [Address], [Monthly Salary ($)],[Overtime Rate (hour)], [Allowances ($)])
                                       VALUES (@ID, @FullName, @ContactNumber, @EmailAddress, @Address, @MonthlySalary, @OvertimeRate, @Allowances)";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        // Set parameters with values from TextBox controls
                        command.Parameters.AddWithValue("@ID", int.Parse(txtid.Text));
                        command.Parameters.AddWithValue("@FullName", txtfn.Text);
                        command.Parameters.AddWithValue("@ContactNumber", int.Parse(txtcn.Text));
                        command.Parameters.AddWithValue("@EmailAddress", txtea.Text);
                        command.Parameters.AddWithValue("@Address", txtadd.Text);
                        command.Parameters.AddWithValue("@MonthlySalary", int.Parse(txtms.Text));
                        command.Parameters.AddWithValue("@OvertimeRate", int.Parse(txtor.Text));
                        command.Parameters.AddWithValue("@Allowances", int.Parse(txtall.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful.");
                            txtid.Clear();
                            txtfn.Clear();
                            txtcn.Clear();
                            txtea.Clear();
                            txtadd.Clear();
                            txtms.Clear();
                            txtor.Clear();
                            txtall.Clear();
                            comboBoxID.Text = "";
                            txtid.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedEmployeeID = Convert.ToInt32(comboBoxID.SelectedItem);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = @"SELECT [ID], [Full Name], [Contact Number], [Email Address], [Address], [Monthly Salary ($)], [Overtime Rate (hour)], [Allowances ($)] FROM [dbo].[Employee_Details] WHERE ID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtid.Text = reader["ID"].ToString();
                            txtfn.Text = reader["Full Name"].ToString();
                            txtcn.Text = reader["Contact Number"].ToString();
                            txtea.Text = reader["Email Address"].ToString();
                            txtadd.Text = reader["Address"].ToString();
                            txtms.Text = reader["Monthly Salary ($)"].ToString();
                            txtor.Text = reader["Overtime Rate (hour)"].ToString();
                            txtall.Text = reader["Allowances ($)"].ToString();
                        }
                        else
                        {
                            txtid.Clear();
                            txtfn.Clear();
                            txtcn.Clear();
                            txtea.Clear();
                            txtadd.Clear();
                            txtms.Clear();
                            txtor.Clear();
                            txtall.Clear();
                            comboBoxID.Text = "";
                            txtid.Focus();
                            MessageBox.Show("Employee not found.");
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Get the employee ID from the txtid TextBox
            int employeeID;

            if (int.TryParse(txtid.Text, out employeeID))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a SQL query to delete data from the "Employee Details" table
                        string deleteQuery = "DELETE FROM [Employee_Details] WHERE ID = @ID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Set the parameter value for the employee ID
                            command.Parameters.AddWithValue("@ID", employeeID);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Deletion successful!");
                                txtid.Clear();
                                txtfn.Clear();
                                txtcn.Clear();
                                txtea.Clear();
                                txtadd.Clear();
                                txtms.Clear();
                                txtor.Clear();
                                txtall.Clear();
                                comboBoxID.Text = "";
                                txtid.Focus(); // Optionally clear the TextBoxes after deletion
                            }
                            else
                            {
                                MessageBox.Show("Deletion failed. The specified employee ID was not found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid employee ID.");
            }
            {
                LoadEmployeeIDs();
            }
        }
    }
}
