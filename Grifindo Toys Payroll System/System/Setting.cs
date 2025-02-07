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
    public partial class Setting : Form
    {
        private string connectionString = @"Data Source=ISHAN_SELLAHEWA;Initial Catalog='Grifindo Toys Payroll System';Integrated Security=True;";
        public Setting()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Grieindo_Toys_Login form = new Grieindo_Toys_Login();
            form.Show();
            this.Close();
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
                        comboBoxSN.Items.Add(reader["Number"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnmm_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
            form.Show();
            this.Hide();
        }



        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumber.Clear();
            txtSC.Clear();
            dateTimePickerSD.Value = DateTime.Today;
            dateTimePickerED.Value = DateTime.Today;
            txtEY.Clear();
            comboBoxSN.Text = "";
            txtnumber.Focus();
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes
            string number = txtnumber.Text;
            string dateRange = txtSC.Text;
            DateTime startDate = dateTimePickerSD.Value;
            DateTime endDate = dateTimePickerED.Value;
            string leaves = txtEY.Text;

            try
            {
                // TODO: Perform your registration logic here, e.g., insert data into a database

                // Example code for inserting data into a SQL Server database
                string connectionString = @"Data Source=ISHAN_SELLAHEWA;Initial Catalog=Grifindo Toys Payroll System;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO [Grifindo Toys Payroll System].[dbo].[Setting] ([Number], [Date Range for Salary Cycle], [Salary Cycle Start Date], [Salary Cycle End Date], [Leaves for Employee for Year]) " +
                                         "VALUES (@Number, @DateRange, @StartDate, @EndDate, @Leaves)";
                    SqlCommand command = new SqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@Number", number);
                    command.Parameters.AddWithValue("@DateRange", dateRange);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.Parameters.AddWithValue("@Leaves", leaves);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Save successful!");
                txtnumber.Clear();
                txtSC.Clear();
                dateTimePickerSD.Value = DateTime.Today;
                dateTimePickerED.Value = DateTime.Today;
                txtEY.Clear();
                comboBoxSN.Text = "";
                txtnumber.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            {
                LoadComboBoxData();
            }
        }

        

        private void comboBoxSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the ComboBox selected index changed event
            string selectedNumber = comboBoxSN.SelectedItem.ToString();

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
                        txtnumber.Text = reader["Number"].ToString();
                        txtSC.Text = reader["Date Range for Salary Cycle"].ToString();
                        dateTimePickerSD.Value = Convert.ToDateTime(reader["Salary Cycle Start Date"]);
                        dateTimePickerED.Value = Convert.ToDateTime(reader["Salary Cycle End Date"]);
                        txtEY.Text = reader["Leaves for Employee for Year"].ToString();
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
            // Retrieve updated data from the textboxes and date pickers
            string number = txtnumber.Text;
            string dateRange = txtSC.Text;
            DateTime startDate = dateTimePickerSD.Value;
            DateTime endDate = dateTimePickerED.Value;
            string leaves = txtEY.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE [dbo].[Setting] SET [Date Range for Salary Cycle] = @DateRange, " +
                                        "[Salary Cycle Start Date] = @StartDate, [Salary Cycle End Date] = @EndDate, " +
                                        "[Leaves for Employee for Year] = @Leaves " +
                                        "WHERE [Number] = @Number";

                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@Number", number);
                    command.Parameters.AddWithValue("@DateRange", dateRange);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    command.Parameters.AddWithValue("@Leaves", leaves);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful!");
                    }
                    else
                    {
                        MessageBox.Show("No records updated. Make sure the Number exists in the database.");
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
            string numberToDelete = txtnumber.Text; // Get the Number to delete from a TextBox

            if (!string.IsNullOrEmpty(numberToDelete))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM [dbo].[Setting] WHERE [Number] = @NumberToDelete";
                        SqlCommand command = new SqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@NumberToDelete", numberToDelete);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                            // Optionally, clear the TextBox after successful deletion
                            txtnumber.Clear();
                            txtSC.Clear();
                            dateTimePickerSD.Value = DateTime.Today;
                            dateTimePickerED.Value = DateTime.Today;
                            txtEY.Clear();
                            comboBoxSN.Text = "";
                            txtnumber.Focus();
                        }
                        else
                        {
                            MessageBox.Show($"No records deleted for Number: {numberToDelete}. Make sure it exists in the database.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Number to delete.");
            }
            {
                LoadComboBoxData();
            }
        }
    }
}