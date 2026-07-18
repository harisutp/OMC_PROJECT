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
    public partial class formreceipt : Form
    {
        public formreceipt()
        {
            InitializeComponent();
        }

        private void lblReceipt_Click(object sender, EventArgs e)
        {
            lblReceipt.Text =
                "=========================================\n" +
                "            OFFICIAL RECEIPT             \n" +
                "=========================================\n\n" +
                $"Date : {DateTime.Now.ToString("MM/dd/yyyy HH:mm")}\n\n" +
                $"Driver Name : {lblNameD.Text}\n" +
                $"Car Model : {lblCarD.Text}\n" +
                $"Plate No:  {lblPlateD.Text}\n" +
                "=========================================\n" +
                $"TOTAL FEES : {lblFees.Text}\n\n" +
                "=========================================\n" +
                "      Thank You for riding MoveAble!" +
                "=========================================\n";



                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbalance form2 = new formbalance();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide form2 = new formLetsRide();
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
