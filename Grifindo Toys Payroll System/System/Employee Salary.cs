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
    public partial class Employee_Salary : Form
    {
        private string connectionString = @"Data Source=ISHAN_SELLAHEWA;Initial Catalog='Grifindo Toys Payroll System';Integrated Security=True;";
        public Employee_Salary()
        {
            InitializeComponent();
            LoadEmployeeIDs();
            LoadComboBoxData();
            LoadsalarID();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Salary_Report form = new Salary_Report();
            form.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                            comboBoxEID.Items.Add(reader["ID"]);
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
                comboBoxEID.Text = "";
                txtFN.Clear();
                txtMS.Clear();
                txtOR.Clear();
                txtALL.Clear();
                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
                DateTime thisDay = DateTime.Today;
                dateTimePickerStart.Text = thisDay.ToString();
                dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
                dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
                dateTimePickerEnd.Text = thisDay.ToString();
                comboBoxsn.Text = "";
                txtLT.Clear();
                txtH.Clear();
                txtOH.Clear();
                txtNPV.Clear();
                txtBPV.Clear();
                txtGPV.Clear();
                txtSC.Clear();
                txtGtax.Clear();
                comboBoxEIDS.Text = "";
                comboBoxEID.Focus();
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT [Number] FROM [dbo].[Setting]";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxsn.Items.Add(reader["Number"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

     

        private void btnMM_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
            form.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            comboBoxEID.Text = "";
            txtFN.Clear();
            txtMS.Clear();
            txtOR.Clear();
            txtALL.Clear();
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dateTimePickerStart.Text = thisDay.ToString();
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
            dateTimePickerEnd.Text = thisDay.ToString();
            comboBoxsn.Text = "";
            txtLT.Clear();
            txtH.Clear();
            txtOH.Clear();
            txtNPV.Clear();
            txtBPV.Clear();
            txtGPV.Clear();
            txtSC.Clear();
            txtGtax.Clear();
            comboBoxEIDS.Text = "";
            comboBoxEID.Focus();
        }

        private void comboBoxEID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedEmployeeID = Convert.ToInt32(comboBoxEID.SelectedItem);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = @"SELECT [Full Name], [Monthly Salary ($)], [Overtime Rate (hour)], [Allowances ($)] FROM [dbo].[Employee_Details] WHERE ID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtFN.Text = reader["Full Name"].ToString();
                            txtMS.Text = reader["Monthly Salary ($)"].ToString();
                            txtOR.Text = reader["Overtime Rate (hour)"].ToString();
                            txtALL.Text = reader["Allowances ($)"].ToString();
                        }
                        else
                        {
                            comboBoxEID.Text = "";
                            txtFN.Clear();
                            txtMS.Clear();
                            txtOR.Clear();
                            txtALL.Clear();
                            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                            dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
                            DateTime thisDay = DateTime.Today;
                            dateTimePickerStart.Text = thisDay.ToString();
                            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
                            dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
                            dateTimePickerEnd.Text = thisDay.ToString();
                            comboBoxsn.Text = "";
                            txtLT.Clear();
                            txtH.Clear();
                            txtOH.Clear();
                            txtNPV.Clear();
                            txtBPV.Clear();
                            txtGPV.Clear();
                            txtSC.Clear();
                            txtGtax.Clear();
                            comboBoxEIDS.Text = "";
                            comboBoxEID.Focus();
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


        private void Employee_Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grifindo_Toys_Payroll_SystemDataSet1.Employee_Details' table. You can move, or remove it, as needed.
          //  this.employee_DetailsTableAdapter.Fill(this.grifindo_Toys_Payroll_SystemDataSet1.Employee_Details);

        }

        private void comboBoxsn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the ComboBox selected index changed event
            string selectedNumber = comboBoxsn.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT [Number], [Date Range for Salary Cycle], [Salary Cycle Start Date], [Salary Cycle End Date], [Leaves for Employee for Year] FROM [dbo].[Setting] WHERE [Number] = @SelectedNumber";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SelectedNumber", selectedNumber);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtSC.Text = reader["Date Range for Salary Cycle"].ToString();
                        dateTimePickerStart.Value = Convert.ToDateTime(reader["Salary Cycle Start Date"]);
                        dateTimePickerEnd.Value = Convert.ToDateTime(reader["Salary Cycle End Date"]);
                        txtH.Text = reader["Leaves for Employee for Year"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCS_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve input values
                decimal monthlySalary = decimal.Parse(txtMS.Text);
                decimal allowances = decimal.Parse(txtALL.Text);
                decimal overtimeRate = decimal.Parse(txtOH.Text);
                int noOfOvertimeHours = int.Parse(txtOR.Text);
                int noOfAbsentDays = int.Parse(txtLT.Text);
                decimal governmentTaxRate = decimal.Parse(txtGtax.Text);
                decimal salaryCycleDateRange = decimal.Parse(txtSC.Text);

                // Calculate No-pay Value
                decimal noPayValue = (monthlySalary / salaryCycleDateRange) * noOfAbsentDays;

                // Calculate Base Pay Value
                decimal basePayValue = monthlySalary + allowances + (overtimeRate * noOfOvertimeHours);

                // Calculate Gross Pay
                decimal grossPay = basePayValue - (noPayValue + (basePayValue * governmentTaxRate / 100));

                // Display the calculated values
                txtNPV.Text = noPayValue.ToString("0.00");
                txtBPV.Text = basePayValue.ToString("0.00");
                txtGPV.Text = grossPay.ToString("0.00");

                // Display the calculated values in message boxes
                string message = $"Base Pay Value: {basePayValue:C}\nNo-pay Value: {noPayValue:C}\nGross Pay: {grossPay:C}";
                MessageBox.Show(message, "Calculated Values", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes and date pickers
            string ID = comboBoxEID.Text;
            string FullName = txtFN.Text;
            DateTime StartDate = dateTimePickerStart.Value; // Use Value to get the selected date
            DateTime EndDate = dateTimePickerEnd.Value;     // Use Value to get the selected date
            string leavesTaken = txtLT.Text;
            string overtimeHours = txtOH.Text;
            string basePayValue = txtBPV.Text;
            string noPayValue = txtNPV.Text;
            string grossPayValue = txtGPV.Text;

            try
            {
                // Perform the registration logic here, insert data into the "Salary" table

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Salary ([ID], [Start Date], [End Date], [Full Name], [Leaves taken], [Overtime Hours], [Base Pay Value], [No-Pay Value], [Gross Pay Value]) " +
                                         "VALUES (@ID, @StartDate, @EndDate, @FullName, @LeavesTaken, @OvertimeHours, @BasePayValue, @NoPayValue, @GrossPayValue)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@LeavesTaken", leavesTaken);
                    command.Parameters.AddWithValue("@OvertimeHours", overtimeHours);
                    command.Parameters.AddWithValue("@BasePayValue", basePayValue);
                    command.Parameters.AddWithValue("@NoPayValue", noPayValue);
                    command.Parameters.AddWithValue("@GrossPayValue", grossPayValue);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!");
                // Clear input fields
                comboBoxEID.Text = "";
                txtFN.Clear();
                txtMS.Clear();
                txtOR.Clear();
                txtALL.Clear();
                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
                DateTime thisDay = DateTime.Today;
                dateTimePickerStart.Text = thisDay.ToString();
                dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
                dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
                dateTimePickerEnd.Text = thisDay.ToString();
                comboBoxsn.Text = "";
                txtLT.Clear();
                txtH.Clear();
                txtOH.Clear();
                txtNPV.Clear();
                txtBPV.Clear();
                txtGPV.Clear();
                txtSC.Clear();
                txtGtax.Clear();
                comboBoxEIDS.Text = "";
                comboBoxEID.Focus();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void comboBoxEIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected employee ID from the ComboBox
            string selectedEmployeeID = comboBoxEIDS.SelectedItem.ToString();

            try
            {
                // Query the database to fetch the corresponding data for the selected employee
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT [ID], [Full Name], [Leaves taken], [Overtime Hours], [Base Pay Value], [No-Pay Value], [Gross Pay Value] " +
                                         "FROM [Salary] WHERE [ID] = @EmployeeID";
                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the textboxes with the fetched data
                        comboBoxEID.Text = reader["ID"].ToString();
                        txtFN.Text = reader["Full Name"].ToString();
                        txtLT.Text = reader["Leaves taken"].ToString();
                        txtOH.Text = reader["Overtime Hours"].ToString();
                        txtBPV.Text = reader["Base Pay Value"].ToString();
                        txtNPV.Text = reader["No-Pay Value"].ToString();
                        txtGPV.Text = reader["Gross Pay Value"].ToString();
                    }
                    else
                    {
                        // Handle the case where the employee ID is not found
                        MessageBox.Show("Employee ID not found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadsalarID()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT [ID] FROM [Salary]";
                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Assuming you have a ComboBox control named comboBoxSalary
                        comboBoxEIDS.Items.Add(reader["ID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Get the selected ID from the ComboBox
            if (comboBoxEIDS.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee ID from the ComboBox.");
                return;
            }

            int selectedID = Convert.ToInt32(comboBoxEIDS.SelectedItem.ToString());

            // Retrieve data from textboxes for updating
            string leavesTaken = txtLT.Text;
            string overtimeHours = txtOH.Text;
            string basePayValue = txtBPV.Text;
            string noPayValue = txtNPV.Text;
            string grossPayValue = txtGPV.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE [Salary] SET [Leaves taken] = @LeavesTaken, [Overtime Hours] = @OvertimeHours, " +
                                         "[Base Pay Value] = @BasePayValue, [No-Pay Value] = @NoPayValue, " +
                                         "[Gross Pay Value] = @GrossPayValue WHERE [ID] = @SelectedID";
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@LeavesTaken", leavesTaken);
                    command.Parameters.AddWithValue("@OvertimeHours", overtimeHours);
                    command.Parameters.AddWithValue("@BasePayValue", basePayValue);
                    command.Parameters.AddWithValue("@NoPayValue", noPayValue);
                    command.Parameters.AddWithValue("@GrossPayValue", grossPayValue);
                    command.Parameters.AddWithValue("@SelectedID", selectedID);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Update successful!");
                comboBoxEID.Text = "";
                txtFN.Clear();
                txtMS.Clear();
                txtOR.Clear();
                txtALL.Clear();
                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
                DateTime thisDay = DateTime.Today;
                dateTimePickerStart.Text = thisDay.ToString();
                dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
                dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
                dateTimePickerEnd.Text = thisDay.ToString();
                comboBoxsn.Text = "";
                txtLT.Clear();
                txtH.Clear();
                txtOH.Clear();
                txtNPV.Clear();
                txtBPV.Clear();
                txtGPV.Clear();
                txtSC.Clear();
                txtGtax.Clear();
                comboBoxEIDS.Text = "";
                comboBoxEID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Get the selected ID from the ComboBox
            if (comboBoxEIDS.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee ID from the ComboBox.");
                return;
            }

            int selectedID = Convert.ToInt32(comboBoxEIDS.SelectedItem.ToString());

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM [Salary] WHERE [ID] = @SelectedID";
                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@SelectedID", selectedID);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Delete successful!");
                comboBoxEID.Text = "";
                txtFN.Clear();
                txtMS.Clear();
                txtOR.Clear();
                txtALL.Clear();
                dateTimePickerStart.Format = DateTimePickerFormat.Custom;
                dateTimePickerStart.CustomFormat = "yyyy/MM/dd";
                DateTime thisDay = DateTime.Today;
                dateTimePickerStart.Text = thisDay.ToString();
                dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
                dateTimePickerEnd.CustomFormat = "yyyy/MM/dd";
                dateTimePickerEnd.Text = thisDay.ToString();
                comboBoxsn.Text = "";
                txtLT.Clear();
                txtH.Clear();
                txtOH.Clear();
                txtNPV.Clear();
                txtBPV.Clear();
                txtGPV.Clear();
                txtSC.Clear();
                txtGtax.Clear();
                comboBoxEIDS.Text = "";
                comboBoxEID.Focus();
                LoadsalarID(); // Reload data after deletion to refresh the ComboBox

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}