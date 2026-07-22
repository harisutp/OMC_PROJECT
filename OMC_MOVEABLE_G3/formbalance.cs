using System;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formbalance : Form
    {
        public formbalance()
        {
            InitializeComponent();

            

            UpdateBalanceDisplay();

            // Refresh whenever the form becomes active again.
            this.Activated += (s, e) => UpdateBalanceDisplay();
        }

        private void formbalance_Load(object sender, EventArgs e)
        {
            UpdateBalanceDisplay();
        }

        // One single place that writes the balance to the screen.
        private void UpdateBalanceDisplay()
        {
            lblReload.Text = "RM " + AppData.Balance.ToString("0.00");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            using (formbank bankForm = new formbank())
            {
                DialogResult result = bankForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Only formbalance adds the money, so it is never added twice.
                    AppData.Balance += bankForm.ReloadAmount;
                    UpdateBalanceDisplay();

                    MessageBox.Show(
                        "Your new balance is RM " + AppData.Balance.ToString("0.00"),
                        "Balance Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Sidebar navigation (button1 = PROFILE, button2 = BALANCE, button3 = LET'S RIDE).
        private void button1_Click(object sender, EventArgs e)
        {
            formprofile profileForm = new formprofile();
            profileForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            profileForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Already on the balance page - just refresh the display.
            UpdateBalanceDisplay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide rideForm = new formLetsRide();
            rideForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            rideForm.Show();
        }

        // Kept because the Designer wires it. The balance is NOT updated here
        // because Paint can run many times.
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formaboutus profileForm = new formaboutus();

            profileForm.Show();
        }
    }
}
