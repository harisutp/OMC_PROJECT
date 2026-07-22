using System;
using System.Linq;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formbank : Form
    {
        // Amount entered by the user; read by formbalance after ShowDialog().
        // formbank itself never touches AppData.Balance, so the money
        // can never be added twice.
        public decimal ReloadAmount { get; private set; }

        private const decimal MaxReload = 5000.00m;

        public formbank()
        {
            InitializeComponent();
        }

        private void formbank_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string cardNum = txtCardNum.Text.Trim();
            string ccv = txtCCV.Text.Trim();
            string nameOnCard = txtNameOnCard.Text.Trim();

            // --- Card number ---
            if (string.IsNullOrEmpty(cardNum))
            {
                MessageBox.Show("Please enter the card number.", "Card Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardNum.Focus();
                return;
            }

            if (!cardNum.All(char.IsDigit) || cardNum.Length != 16)
            {
                MessageBox.Show("Card number must be exactly 16 digits.", "Card Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardNum.Focus();
                return;
            }

            // --- CCV ---
            if (string.IsNullOrEmpty(ccv))
            {
                MessageBox.Show("Please enter the CCV.", "Card Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCV.Focus();
                return;
            }

            if (!ccv.All(char.IsDigit) || ccv.Length != 3)
            {
                MessageBox.Show("CCV must be exactly 3 digits.", "Card Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCCV.Focus();
                return;
            }

            // --- Name on card ---
            if (string.IsNullOrEmpty(nameOnCard))
            {
                MessageBox.Show("Please enter the name on the card.", "Card Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameOnCard.Focus();
                return;
            }

            // --- Expiry date (compare by month, not by exact day) ---
            DateTime expiry = dtpExpiryDate.Value;
            DateTime endOfExpiryMonth = new DateTime(expiry.Year, expiry.Month, 1)
                .AddMonths(1).AddDays(-1);

            if (endOfExpiryMonth < DateTime.Today)
            {
                MessageBox.Show("This card has expired. Please use a valid card.",
                    "Card Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpExpiryDate.Focus();
                return;
            }

            // --- Reload amount ---
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid reload amount greater than RM 0.00.",
                    "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            if (amount > MaxReload)
            {
                MessageBox.Show("The maximum reload amount is RM " + MaxReload.ToString("0.00") + ".",
                    "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return;
            }

            ReloadAmount = amount;

            MessageBox.Show("Reload of RM " + ReloadAmount.ToString("0.00") + " was successful.",
                "Reload Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtNameOnCard_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
