using System;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formLetsRide : Form
    {
        public formLetsRide()
        {
            InitializeComponent();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            formbalance form2 = new formbalance();
            form2.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string selectedDestination = "";

            if (cboHosp.SelectedIndex != -1)
            {
                selectedDestination = cboHosp.Text;
            }
            else if (cboSuperM.SelectedIndex != -1)
            {
                selectedDestination = cboSuperM.Text;
            }
            else if (cboPhar.SelectedIndex != -1)
            {
                selectedDestination = cboPhar.Text;
            }
            else
            {
                MessageBox.Show(
                    "Please select a destination.",
                    "Destination Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            formPay payForm = new formPay(selectedDestination);
            payForm.Show();
            this.Hide();
        }

        

        private void btnProfile_Click(object sender, EventArgs e)
        {
            formprofile profileForm = new formprofile();
            profileForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

