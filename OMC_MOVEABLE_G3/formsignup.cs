using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formsignup : Form
    {
        // One connection string used by every database call in this form.
        private static readonly string connString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + AppDomain.CurrentDomain.BaseDirectory + "OMC.accdb";

        public formsignup()
        {
            InitializeComponent();
        }

        private void formsignup_Load(object sender, EventArgs e)
        {
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name = txtName2.Text.Trim();
            string email = txtEmail2.Text.Trim();
            string password = txtPassword2.Text;
            string disabilities = txtDisab.Text.Trim();

            // Basic validation before creating the account.
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.", "Sign up",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Sign up",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.", "Sign up",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword2.Focus();
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // 1) Check the email is not already registered.
                    string checkSql = "SELECT COUNT(*) FROM [customer Sign in] WHERE [Email] = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", email);
                        int existing = (int)checkCmd.ExecuteScalar();
                        if (existing > 0)
                        {
                            MessageBox.Show("This email is already registered. Please log in instead.",
                                "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail2.Focus();
                            return;
                        }
                    }

                    // 2) Insert the new customer.
                    string insertSql = @"INSERT INTO [customer Sign in]
                                         ([Customer Name], [Email], [Password], [Disabilities])
                                         VALUES (?, ?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertSql, conn))
                    {
                        insertCmd.Parameters.AddWithValue("?", name);
                        insertCmd.Parameters.AddWithValue("?", email);
                        insertCmd.Parameters.AddWithValue("?", password);
                        insertCmd.Parameters.AddWithValue("?", disabilities);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your account.\n\n" + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Account created! You can now log in.",
                "Welcome to MoveAble", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close() triggers the FormClosed handler set up by formlogin,
            // which shows the login form again.
            Close();
        }

        private void txtName2_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            // 50% transparent blue
            guna2CustomGradientPanel1.FillColor = Color.FromArgb(128, 0, 120, 255);
        }

        private void lnkHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtPassword2.UseSystemPasswordChar == false)
            {
                txtPassword2.UseSystemPasswordChar = true; //show password
                lnkHide.BringToFront();
                lnkHide.Text = "Show";
            }
            else
            {
                txtPassword2.UseSystemPasswordChar = false; //hide password
                lnkHide.BringToFront();
                lnkHide.Text = "Hide";
            }
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            txtPassword2.UseSystemPasswordChar = true; // Ensure the password is hidden by default
        }
    }
}