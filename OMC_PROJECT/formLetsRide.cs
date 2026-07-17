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

        

        private void btnProfile_Click(object sender, EventArgs e)
        {
            formprofile formprofile = new formprofile();
            formprofile.Show();
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
    }
    }
