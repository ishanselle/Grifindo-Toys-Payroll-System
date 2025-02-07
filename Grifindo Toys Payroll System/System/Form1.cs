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
    public partial class Grieindo_Toys_Login : Form
    {
        public Grieindo_Toys_Login()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuname.Clear();
            txtpw.Clear();
            txtuname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Uname, Pw;
            Uname = txtuname.Text;
            Pw = txtpw.Text;
            if (Uname == "Admin" && Pw == "123")
            {
                Main_Form form = new Main_Form();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials please check your username and password and try again", "Invalid login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuname.Text = "";
                txtpw.Text = "";
                txtuname.Focus();
            }
        }
    }
}
