using System;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formPay : Form
    {
        private decimal currentFee = 0.00m;

        public formPay()
        {
            InitializeComponent();
        }

        public formPay(string destination) : this()
        {
            SetDestinationFee(destination);
        }

        private void SetDestinationFee(string destination)
        {
            switch (destination.Trim().ToUpper())
            {
                case "SERI ISKANDAR HOSPITAL":
                    currentFee = 20.00m;
                    break;

                case "ECONSAVE SERI ISKANDAR":
                    currentFee = 15.00m;
                    break;

                case "FARMASI SERI ISKANDAR":
                    currentFee = 10.00m;
                    break;

                default:
                    currentFee = 0.00m;
                    break;
            }

            lblFees.Text = "RM" + currentFee.ToString("0.00");
        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            if (currentFee <= 0)
            {
                MessageBox.Show(
                    "Invalid payment amount.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            if (AppData.Balance < currentFee)
            {
                MessageBox.Show(
                    "Insufficient balance.\n\n" +
                    $"Current Balance: RM{AppData.Balance:0.00}\n" +
                    $"Required Fees: RM{currentFee:0.00}",
                    "Payment Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            AppData.Balance -= currentFee;

            MessageBox.Show(
                "Booking and payment successful!\n\n" +
                $"Payment: RM{currentFee:0.00}\n" +
                $"Remaining Balance: RM{AppData.Balance:0.00}",
                "Payment Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Buka receipt
            formreceipt receiptForm = new formreceipt();
            receiptForm.Show();

            this.Hide();
        }
    }
}