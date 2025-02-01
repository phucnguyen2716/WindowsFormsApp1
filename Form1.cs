using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "phucga1234" && txtPassword.Text == "123")
                MessageBox.Show("Do you want to access this account !", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Error account information !", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
