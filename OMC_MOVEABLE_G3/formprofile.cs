using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formprofile : Form
    {
        // Where this user's profile photo is stored.
        private string PhotoPath
        {
            get
            {
                int id = Session.CurrentUser != null ? Session.CurrentUser.CustomerID : 0;
                return AppDomain.CurrentDomain.BaseDirectory + "photo_" + id + ".jpg";
            }
        }

        // Loads the saved photo into the picture box, if one exists.
        private void LoadPhoto()
        {
            try
            {
                if (System.IO.File.Exists(PhotoPath))
                {
                    // Read into memory so the file is not locked while displayed.
                    byte[] bytes = System.IO.File.ReadAllBytes(PhotoPath);
                    using (var ms = new System.IO.MemoryStream(bytes))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception)
            {
                // A damaged image file should not crash the profile page.
            }
        }
        private bool isEditing = false;

        // Same connection string as the other forms.
        private static readonly string connString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + AppDomain.CurrentDomain.BaseDirectory + "OMC.accdb";

        public formprofile()
        {
            InitializeComponent();
            LoadProfile();
        }

        // Fills the profile fields from the logged-in user.
        private void LoadProfile()
        {
            if (Session.CurrentUser != null)
            {
                txtName.Text = Session.CurrentUser.Name;
                txtContact.Text = Session.CurrentUser.Email;
                txtDisabilities.Text = Session.CurrentUser.Disabilities;
            }
            else
            {
                txtName.Text = "";
                txtContact.Text = "";
                txtDisabilities.Text = "";
            }

            txtName.ReadOnly = true;
            txtContact.ReadOnly = true;
            txtDisabilities.ReadOnly = true;

            LoadPhoto();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Switch to edit mode.
                txtName.ReadOnly = false;
                txtContact.ReadOnly = false;
                txtDisabilities.ReadOnly = false;

                //btnEdit.Text = "SAVE";
                isEditing = true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Name cannot be empty.", "Profile",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Session.CurrentUser == null)
                {
                    MessageBox.Show("No user is logged in.", "Profile",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Save the changes to the database first, so they are
                // still there the next time the user logs in.
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(connString))
                    {
                        conn.Open();

                        string sql = @"UPDATE [customer Sign in]
                                       SET [Customer Name] = ?, [Email] = ?, [Disabilities] = ?
                                       WHERE [CustomerID] = ?";
                        using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("?", txtName.Text.Trim());
                            cmd.Parameters.AddWithValue("?", txtContact.Text.Trim());
                            cmd.Parameters.AddWithValue("?", txtDisabilities.Text.Trim());
                            cmd.Parameters.AddWithValue("?", Session.CurrentUser.CustomerID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not save your profile.\n\n" + ex.Message,
                        "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Then update the in-memory user so every form shows it.
                Session.CurrentUser.Name = txtName.Text.Trim();
                Session.CurrentUser.Email = txtContact.Text.Trim();
                Session.CurrentUser.Disabilities = txtDisabilities.Text.Trim();
                lblName.Text = "Name : " + Session.CurrentUser.Name;

                txtName.ReadOnly = true;
                txtContact.ReadOnly = true;
                txtDisabilities.ReadOnly = true;

                MessageBox.Show("Profile updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //btnEdit.Text = "EDIT";
                isEditing = false;
            }
        }

        // The Designer wires btnLogout to this handler.
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.CurrentUser = null;

                // Closing this form closes the whole navigation chain,
                // which brings the user back to the login form.
                this.Close();
            }
        }

        // Sidebar navigation (button1 = PROFILE, button2 = BALANCE, button3 = LET'S RIDE).
        private void button1_Click(object sender, EventArgs e)
        {
            // Already on the profile page.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbalance balanceForm = new formbalance();
            balanceForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            balanceForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide rideForm = new formLetsRide();
            rideForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            rideForm.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("Please log in first.", "Profile",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Choose your profile photo";
                dialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Save a copy for this user, then show it.
                        System.IO.File.Copy(dialog.FileName, PhotoPath, true);
                        LoadPhoto();

                        MessageBox.Show("Profile photo updated!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not update your photo.\n\n" + ex.Message,
                            "Photo error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formaboutus profileForm = new formaboutus();

            profileForm.Show();
        }
    }
}