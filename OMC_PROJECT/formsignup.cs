using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

            if (!UserStore.TryRegister(name, email, password, disabilities, out string error))
            {
                MessageBox.Show(error, "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Account created! You can now log in.",
                "Welcome to MoveAble", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Store the newly registered user in the session so other forms can read it
            Session.CurrentUser = new User
            {
                Name = name,
                Email = email,
                Password = password,
                Disabilities = disabilities
            };

            // Close() triggers the FormClosed handler set up by formlogin, which re-shows it.
            Close();

        }

        private void txtName2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void formsignup_Load(object sender, EventArgs e)
        {

        }
    }
}
