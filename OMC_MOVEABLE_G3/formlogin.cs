using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formlogin : Form
    {
        // Same connection string as formsignup.
        private static readonly string connString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + AppDomain.CurrentDomain.BaseDirectory + "OMC.accdb";

        // Special admin login. Typing these into the normal email/password
        // fields opens the admin page instead of a customer account.
        // Change these to whatever you want the real admin credentials to be.
        private const string AdminName = "admin";
        private const string AdminPassword = "admin123";

        public formlogin()
        {
            InitializeComponent();
        }

        private void formlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both your email and password.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for the admin login first. Comparison is case-insensitive
            // so "Admin" / "ADMIN" also work.
            if (email.Equals(AdminName, StringComparison.OrdinalIgnoreCase) && password == AdminPassword)
            {
                var adminForm = new formadmin();
                adminForm.FormClosed += (s2, e2) => this.Show();
                this.Hide();
                adminForm.Show();
                return;
            }

            User user = null;

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    string sql = @"SELECT [CustomerID], [Customer Name], [Email], [Password], [Disabilities]
                                   FROM [customer Sign in]
                                   WHERE [Email] = ? AND [Password] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", email);
                        cmd.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    CustomerID = Convert.ToInt32(reader["CustomerID"]),
                                    Name = reader["Customer Name"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Disabilities = reader["Disabilities"] == DBNull.Value
                                        ? "" : reader["Disabilities"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not check your login.\n\n" + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user == null)
            {
                MessageBox.Show("Wrong email or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            Session.CurrentUser = user;

            // Open the main page. When the whole navigation chain closes
            // (for example after Logout), the login form is shown again.
            var mainForm = new formLetsRide();
            mainForm.FormClosed += (s2, e2) => this.Show();
            this.Hide();
            mainForm.Show();
        }

        private void btnSignup2_Click(object sender, EventArgs e)
        {
            var signup = new formsignup();
            signup.FormClosed += (s2, e2) => this.Show();
            this.Hide();
            signup.Show();
        }

        // Empty handlers kept because the Designer wires these labels.
        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            // 50% transparent blue
            guna2CustomGradientPanel1.FillColor = Color.FromArgb(128, 0, 120, 255);
        }

        private void lnklblHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true; //show password
                lnklblHide.BringToFront();
                lnklblHide.Text = "Show";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false; //hide password
                lnklblHide.BringToFront();
                lnklblHide.Text = "Hide";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // Ensure the password is hidden by default
        }
    }
}