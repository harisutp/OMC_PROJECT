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
    public partial class formbank : Form
    {
        // Amount entered by the user to reload; exposed to caller form
        public decimal ReloadAmount { get; private set; }

        public formbank()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void formbank_Load(object sender, EventArgs e)
        {
            //hii
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCardNum.Text) ||
                string.IsNullOrWhiteSpace(txtCCV.Text) ||
                string.IsNullOrWhiteSpace(txtNameOnCard.Text))
            {
                MessageBox.Show(
                    "Please complete all card details.",
                    "Incomplete Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            decimal amount;

            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid reload amount.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtAmount.Focus();
                return;
            }

            ReloadAmount = amount;

            MessageBox.Show(
                "Reload of RM" + ReloadAmount.ToString("0.00") +
                " was successful.",
                "Reload Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
        
           private void btnClear_Click(object sender, EventArgs e)
        {
            txtCardNum.Clear();
            txtCCV.Clear();
            txtNameOnCard.Clear();
            txtAmount.Clear();

            dtpExpiryDate.Value = DateTime.Now;

            txtCardNum.Focus();
        }
    }
    
}
