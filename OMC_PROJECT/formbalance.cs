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
    }


}
