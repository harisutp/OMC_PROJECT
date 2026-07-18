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
        private decimal currentBalance = 1.00m; // Variable to store the current balance
        public formbalance()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //formbank secondForm = new formbank();

            
           // secondForm.Show();

            
           // this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formprofile formprofile = new formprofile();
            formprofile.Show();
            this.Hide();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formbank secondForm = new formbank();

            DialogResult result = secondForm.ShowDialog();

           
            if (result == DialogResult.OK)
            {
               
                currentBalance += 19.00m;
                UpdateBalanceDisplay();
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            UpdateBalanceDisplay();
        }


        private void UpdateBalanceDisplay()
        {
            lblBalance.Text = "RM " + currentBalance.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide formLetsRide = new formLetsRide();
            formLetsRide.Show();
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
