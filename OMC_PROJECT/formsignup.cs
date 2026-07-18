using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OMC_PROJECT
{

    public partial class formsignup : Form
    {
        
        public formsignup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name = txtName2.Text.Trim();
            string email = txtEmail2.Text.Trim();
            string password = txtPassword2.Text;
            string disabilities = txtDisab.Text.Trim();
            

            if (name == "" || email == "" || password == "" || disabilities == "")
            {
                MessageBox.Show("Please fill in all required fields.", "Sign up failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    // Check if this email is already registered
                    string checkQuery = "SELECT COUNT(*) FROM [customer Sign in] WHERE Email = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("?", email);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This email is already registered.", "Sign up failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new customer.
                    // CustomerID is AutoNumber, so it is NOT included here — Access generates it.
                    string insertQuery = "INSERT INTO [customer Sign in] " +
                        "([Customer Name], Email, Password, [Customer Number], Disabilities) " +
                        "VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("?", name);
                        insertCmd.Parameters.AddWithValue("?", email);
                        insertCmd.Parameters.AddWithValue("?", password);

                        insertCmd.Parameters.AddWithValue("?", disabilities);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Store the newly registered user in session so other forms can read it
                Session.CurrentUser = new User
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    Disabilities = disabilities
                };

                MessageBox.Show("Account created! You can now log in.",
                    "Welcome to MoveAble", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void txtName2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void formsignup_Load(object sender, EventArgs e)
        {

        }
    }
}
