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
    public partial class formprofile : Form
    {
        public formprofile()
        {
            InitializeComponent();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        { }
            private void btnLogOut_Click(object sender, EventArgs e)
        {
            // 1. Confirm with the user
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Clear any active user session variables if you have them
                // UserSession.Clear(); 

                // 3. Show the Login Form and hide/close this dashboard
                formlogin login = new formlogin();
                login.Show();

                this.Hide(); // Hides the current dashboard form
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide letsRideWindow = new formLetsRide();
            letsRideWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbalance balanceWindow = new formbalance();
            balanceWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        
        private bool isEditing = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                //edit
                txtName.ReadOnly = false;
                txtContact.ReadOnly = false;
                txtDisabilities.ReadOnly = false;

                btnEdit.Text = "SAVE";
                isEditing = true;
            }
            else
            {
                //save
                txtName.ReadOnly = true;
                txtContact.ReadOnly = true;
                txtDisabilities.ReadOnly = true;

                
                string updatedName = txtName.Text;
                string updatedContact = txtContact.Text;
                string updatedDisabilities = txtDisabilities.Text;

                

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnEdit.Text = "EDIT";
                isEditing = false;
            }
        }

        private void lblEmailP_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    


