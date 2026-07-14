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
                $"Driver Name : {driverName}\n" +
                $"Car Model : {carModel}\n" +
                $"Plate No:  {plateNumber}\n" +
                "=========================================\n" +
                $"TOTAL FEES : {fees}\n\n" +
                "=========================================\n" +
                "      Thank You for riding MoveAble!" +
                "=========================================\n";



                
        }
    }
}
