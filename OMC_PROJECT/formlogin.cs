using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Collections.Specialized.BitVector32;

namespace OMC_PROJECT
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
             //Temporary: show stack trace to find who creates this form at startup
            //MessageBox.Show(new StackTrace().ToString(), "formlogin created by");
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

            var formLetsRide = new formLetsRide();
            formLetsRide.FormClosed += (s2, e2) => Close();
            Hide();
            formLetsRide.Show();

        }

        private void btnSignup2_Click(object sender, EventArgs e)
        {
            var signup = new formsignup();
            signup.FormClosed += (s2, e2) => Show();
            Hide();
            signup.Show();

        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            if (txtEmail2 == null)
            {
                MessageBox.Show("Email input control not available.", "UI error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string email = txtEmail2.Text.Trim();
            string password = txtPassword2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both your email/phone number and password.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!UserStore.TryLogin(email, password, out var user, out string error))
            {
                MessageBox.Show(error, "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword2.Clear();
                txtPassword.Focus();
                return;
            }

            Session.CurrentUser = user;

            var formLetsRide = new formLetsRide();
            formLetsRide.FormClosed += (s2, e2) => Close();
            Hide();
            formLetsRide.Show();
        }

        private void btnSignUp3_Click(object sender, EventArgs e)
        {

            var signup = new formsignup();
            signup.FormClosed += (s2, e2) => Show();
            Hide();
            signup.Show();
        }

        private void formlogin_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
