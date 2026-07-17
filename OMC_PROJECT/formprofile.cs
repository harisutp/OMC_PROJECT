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
    public partial class formprofile : Form
    {
        public formprofile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide formLetsRide = new formLetsRide();
            formLetsRide.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbalance formbalance = new formbalance();
            formbalance.Show();
            this.Hide();
        }
    }
}
