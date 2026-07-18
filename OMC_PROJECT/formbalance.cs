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

            lblBalance.Text = "RM " + AppData.Balance.ToString("0.00");
        }

        

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            UpdateBalanceDisplay();
        }


        private void UpdateBalanceDisplay()
        {
            lblBalance.Text = "RM " + currentBalance.ToString("0.00");
        }

        
        
            private void btnReload_Click(object sender, EventArgs e)
        {
            using (formbank secondForm = new formbank())
            {
                DialogResult result = secondForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    AppData.Balance += secondForm.ReloadAmount;

                    UpdateBalanceDisplay();

                    MessageBox.Show(
                        "Your new balance is RM" +
                        AppData.Balance.ToString("0.00"),
                        "Balance Updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
    }
    }
    }


}
