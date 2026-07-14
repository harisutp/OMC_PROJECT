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
                $"Driver Name : {lblNameD}\n" +
                $"Car Model : {lblCarD}\n" +
                $"Plate No:  {lblPlateD}\n" +
                "=========================================\n" +
                $"TOTAL FEES : {lblFees}\n\n" +
                "=========================================\n" +
                "      Thank You for riding MoveAble!" +
                "=========================================\n";



                
        }
    }
}
