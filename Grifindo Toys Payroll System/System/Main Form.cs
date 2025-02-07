using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void linkLabelEmployeeregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee_register obj = new Employee_register();
            obj.Show();
            this.Hide();
        }

        private void linkLabelEmployeesSalary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee_Salary obj = new Employee_Salary();
            obj.Show();
            this.Hide();
        }

        private void LinkLabelSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Setting obj = new Setting();
            obj.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Grieindo_Toys_Login form = new Grieindo_Toys_Login();
            form.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Employee_register form = new Employee_register();
            form.Show();
            this.Hide();
        }

        private void linkLabelSR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Salary_Report obj = new Salary_Report();
            obj.Show();
            this.Hide();
        }
    }
}
