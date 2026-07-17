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
    using System.Windows.Forms;
    public partial class formLetsRide : Form
    {
      
            public formLetsRide()
            {
                InitializeComponent();
                // Show current user's name (if any) in the sidebar label
                try
                {
                    lblName2.Text = Session.CurrentUser?.Name ?? string.Empty;
                }
                catch
                {
                    // ignore if label not available at design time
                }
            }

        private void btnRide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Budu");
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            formbalance form2 = new formbalance();
            form2.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            formPay formpay = new formPay();
            formpay.Show();
            this.Hide();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            MapForm map = new MapForm();

            if (map.ShowDialog() == DialogResult.OK)
            {
                txtPickup.Text = map.SelectedAddress;
            }
        }

        private void btnMap_MouseEnter(object sender, EventArgs e)
        {
            btnMap.BackColor = Color.LightBlue;
        }   

        private void btnProfile_Click(object sender, EventArgs e)
        {
            formprofile formprofile = new formprofile();
            formprofile.Show();
            this.Hide();
        }

        private void txtPickup_TextChanged(object sender, EventArgs e)
        {

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
