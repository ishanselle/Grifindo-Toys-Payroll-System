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
    public partial class Salary_Report : Form
    {
        private string connectionString = @"Data Source=ISHAN_SELLAHEWA;Initial Catalog='Grifindo Toys Payroll System';Integrated Security=True;";
        public Salary_Report()
        {
            InitializeComponent();
            LoadsalarID();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            comboBoxeid.Text = "";
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;
            dataGridViewreport.ClearSelection();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void btnMM_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
            form.Show();
            this.Hide();
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
                        comboBoxeid.Items.Add(reader["ID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btnreport_Click(object sender, EventArgs e)
        {
            int selectedEmployeeID;
            if (int.TryParse(comboBoxeid.SelectedItem.ToString(), out selectedEmployeeID))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Query to fetch salary data for the selected employee ID
                        string selectQuery = "SELECT [ID], [Full Name], [Leaves taken], [Overtime Hours], " +
                                             "[Base Pay Value], [No-Pay Value], [Gross Pay Value] " +
                                             "FROM [Salary] " +
                                             "WHERE [ID] = @EmployeeID";

                        SqlCommand command = new SqlCommand(selectQuery, connection);
                        command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the data to the DataGridView
                        dataGridViewreport.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid employee ID.");
            }
        }

        private void btnALLSR_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch all data from the "Salary" table
                    string selectQuery = "SELECT [ID], [Full Name], [Leaves taken], [Overtime Hours], " +
                                         "[Base Pay Value], [No-Pay Value], [Gross Pay Value] " +
                                         "FROM [Salary]";

                    SqlCommand command = new SqlCommand(selectQuery, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridViewreport.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblSD_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblED_Click(object sender, EventArgs e)
        {

        }

        private void btnreportm_Click(object sender, EventArgs e)
        {
            string selectedEmployeeID = comboBoxeid.SelectedItem.ToString();
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch monthly salary data based on employee ID and date range
                    string selectQuery = "SELECT [ID], [Full Name], [Leaves taken], [Overtime Hours], " +
                                         "[Base Pay Value], [No-Pay Value], [Gross Pay Value] " +
                                         "FROM [Salary] " +
                                         "WHERE [ID] = @EmployeeID " +
                                         "AND [Start Date] BETWEEN @StartDate AND @EndDate";

                    SqlCommand command = new SqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridViewreport.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxeid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Salary_Report_Load(object sender, EventArgs e)
        {

        }
    }
}