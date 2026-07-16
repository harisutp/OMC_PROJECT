using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OMC_PROJECT
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both your email/phone number and password.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (!UserStore.TryLogin(email, password, out var user, out string error))
            {
                MessageBox.Show(error, "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            Session.CurrentUser = user;

            var balanceForm = new formLetsRide();
            balanceForm.FormClosed += (s2, e2) => Close();
            Hide();
            balanceForm.Show();

        }

        private void btnSignup2_Click(object sender, EventArgs e)
        {
            var signup = new formsignup();
            signup.FormClosed += (s2, e2) => Show();
            Hide();
            signup.Show();

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
