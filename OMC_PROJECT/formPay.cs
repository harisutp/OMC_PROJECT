using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formPay : Form
    {
        public formPay()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Added stub for designer-wired click event
        private void lblNameD_Click(object sender, EventArgs e)
        {
            // Intentionally left simple: show a small info or no-op to satisfy designer wiring.
            // Keep behavior minimal to avoid changing form flow.
            // You can replace this with real handling as needed.
            // For now, do nothing.
        }

        // Added stub for designer-wired click event for Ride button
        private void btnRide_Click(object sender, EventArgs e)
        {
            // Minimal handler: optionally show or open the ride form.
            // Keep as no-op to avoid altering navigation.
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            formbalance form2 = new formbalance();
            form2.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            formprofile formprofile = new formprofile();
            formprofile.Show();
            this.Hide();

        }
    }
}
