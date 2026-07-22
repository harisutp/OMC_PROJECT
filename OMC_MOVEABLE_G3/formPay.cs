using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formPay : Form
    {
        private decimal currentFee = 0.00m;
        private bool hasBooked = false; // prevents double charging

        // One shared Random object so drivers do not repeat the same value
        // when forms are created quickly one after another.
        private static readonly Random random = new Random();

        // The DriverID of the randomly picked driver (matches [Driver sign in]).
        private int selectedDriverId = 0;

        // Same connection string as the other forms.
        private static readonly string connString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + AppDomain.CurrentDomain.BaseDirectory + "OMC.accdb";

        public formPay()
        {
            InitializeComponent();

        }

        // Used when only the destination is known (fixed-fee destinations).
        public formPay(string destination) : this()
        {
            SetDestinationFee(destination, 0.00m);
            SetRandomDriver();
        }

        // Used by formLetsRide: fixed fee for known destinations,
        // otherwise fall back to the distance-based fare.
        public formPay(string destination, decimal distanceFare) : this()
        {
            SetDestinationFee(destination, distanceFare);
            SetRandomDriver();
        }

        private void SetDestinationFee(string destination, decimal fallbackFare)
        {
            string dest = (destination ?? "").Trim().ToUpper();

            if (dest.Contains("SERI ISKANDAR HOSPITAL"))
            {
                currentFee = 20.00m;
            }
            else if (dest.Contains("ECONSAVE"))
            {
                currentFee = 15.00m;
            }
            else if (dest.Contains("FARMASI"))
            {
                currentFee = 10.00m;
            }
            else
            {
                currentFee = fallbackFare;
            }

            lblFees.Text = "RM " + currentFee.ToString("0.00");
        }

        private void SetRandomDriver()
        {
            // One complete profile is picked so name, car and plate stay matched.
            // IMPORTANT: this list is in the same order as [Driver sign in] in
            // the database, so row 0 = DriverID 1, row 1 = DriverID 2, and so on.
            string[,] drivers =
            {
                { "Mahmud",        "Toyota",      "CCY6556" },
                { "Lee Kai Wen",   "Myvi",        "WSD3425" },
                { "Wong Yi Xuan",  "Proton Saga", "GTT0956" },
                { "Hafiz Zulkifli","Axia",        "KDH4679" },
                { "Naveen Kumar",  "Myvi",        "NEC0435" }
            };

            int randomIndex = random.Next(0, drivers.GetLength(0));

            lblNameD.Text = drivers[randomIndex, 0];
            lblCarD.Text = drivers[randomIndex, 1];
            lblPlateD.Text = drivers[randomIndex, 2];

            // Remember which driver was picked so the order can store it.
            selectedDriverId = randomIndex + 1;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (hasBooked)
            {
                MessageBox.Show("This ride has already been booked.",
                    "Already Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentFee <= 0)
            {
                MessageBox.Show("Invalid payment amount.",
                    "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AppData.Balance < currentFee)
            {
                MessageBox.Show(
                    "Insufficient balance.\n\n" +
                    $"Current Balance: RM {AppData.Balance:0.00}\n" +
                    $"Required Fee: RM {currentFee:0.00}\n\n" +
                    "Please reload your balance first.",
                    "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the order to the database BEFORE charging, so the
            // customer is not charged if saving fails.
            int newOrderId;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    string insertSql = @"INSERT INTO [Order]
                                         ([CustomerID], [Price], [Pick up], [Destination], [DriverID])
                                         VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", Session.CurrentUser.CustomerID);
                        cmd.Parameters.AddWithValue("?", currentFee);
                        cmd.Parameters.AddWithValue("?", BookingData.Pickup);
                        cmd.Parameters.AddWithValue("?", BookingData.Destination);
                        cmd.Parameters.AddWithValue("?", selectedDriverId);
                        cmd.ExecuteNonQuery();
                    }

                    // Get the OrderID that Access just generated for this order.
                    using (OleDbCommand idCmd = new OleDbCommand("SELECT @@IDENTITY", conn))
                    {
                        newOrderId = Convert.ToInt32(idCmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your order.\n\n" + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Deduct once and lock the button.
            AppData.Balance -= currentFee;
            hasBooked = true;
            btnBook.Enabled = false;

            // Save the booking so the receipt can show it.
            BookingData.DriverID = selectedDriverId;
            BookingData.OrderID = newOrderId;
            BookingData.DriverName = lblNameD.Text;
            BookingData.Car = lblCarD.Text;
            BookingData.PlateNumber = lblPlateD.Text;
            BookingData.Fee = currentFee;
            BookingData.RemainingBalance = AppData.Balance;
            BookingData.BookingTime = DateTime.Now;
            BookingData.BookingId = "BK" + DateTime.Now.ToString("yyyyMMddHHmmss");
            BookingData.PaymentCompleted = true;

            MessageBox.Show(
                "Booking and payment successful!\n\n" +
                $"Payment: RM {currentFee:0.00}\n" +
                $"Remaining Balance: RM {AppData.Balance:0.00}",
                "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            formreceipt receiptForm = new formreceipt();
            receiptForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            receiptForm.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            formbalance balanceForm = new formbalance();
            balanceForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            balanceForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            formprofile profileForm = new formprofile();
            profileForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            profileForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formaboutus profileForm = new formaboutus();

            profileForm.Show();
        }

        private void btnRide_Click(object sender, EventArgs e)
        {
            formLetsRide rideForm = new formLetsRide();
            rideForm.Show();
            this.Hide();
        }
    }
}
