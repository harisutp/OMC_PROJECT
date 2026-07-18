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
    public partial class formbalance : Form
    {
        public formbalance()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formbank secondForm = new formbank();


            secondForm.Show();


            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide form2 = new formLetsRide();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbalance form2 = new formbalance();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formProfile form2 = new formProfile();
            form2.Show();
            this.Hide();
        }
    }
}
