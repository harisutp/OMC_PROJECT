using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formreceipt : Form
    {
        // Same connection string as the other forms.
        private static readonly string connString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + AppDomain.CurrentDomain.BaseDirectory + "OMC.accdb";

        private static readonly Random random = new Random();

        // Remembers which order was already saved so the same booking
        // is never written to the database twice.
        private static int lastSavedOrderId = 0;

        public formreceipt()
        {
            InitializeComponent();

           

            ShowReceipt();
            SaveReceiptToDatabase();
        }

        // Saves one Ride row and one Receipt row for the current booking.
        private void SaveReceiptToDatabase()
        {
            // Nothing to save if no booking was made.
            if (!BookingData.HasBooking || BookingData.OrderID == 0)
            {
                return;
            }

            // Already saved this order (for example the receipt was reopened).
            if (BookingData.OrderID == lastSavedOrderId)
            {
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();

                    // 1) Generate a RideID and save the Ride row
                    //    linking the driver and the order.
                    int rideId = random.Next(100000000, int.MaxValue);

                    string rideSql = "INSERT INTO [Ride] ([RideID], [DriverID], [OrderID]) VALUES (?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(rideSql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", rideId);
                        cmd.Parameters.AddWithValue("?", BookingData.DriverID);
                        cmd.Parameters.AddWithValue("?", BookingData.OrderID);
                        cmd.ExecuteNonQuery();
                    }

                    // 2) Save the Receipt row pointing at the order and the ride.
                    string receiptSql = @"INSERT INTO [Receipt]
                                          ([OrderID], [Prices], [Payment Method], [Payment Status], [RideID])
                                          VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(receiptSql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", BookingData.OrderID);
                        cmd.Parameters.AddWithValue("?", BookingData.Fee);
                        cmd.Parameters.AddWithValue("?", "Balance");
                        cmd.Parameters.AddWithValue("?", "Complete");
                        cmd.Parameters.AddWithValue("?", rideId);
                        cmd.ExecuteNonQuery();
                    }
                }

                lastSavedOrderId = BookingData.OrderID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the receipt.\n\n" + ex.Message,
                    "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Builds the receipt text from the shared BookingData class.
        private void ShowReceipt()
        {
            if (!BookingData.HasBooking)
            {
                lblReceipt.Text = "No booking has been made yet.";
                return;
            }

            string customer = Session.CurrentUser != null ? Session.CurrentUser.Name : "-";

            lblReceipt.Text =
                "=========================\n" +
                "     OFFICIAL RECEIPT\n" +
                "=========================\n" +
                $"Booking No : {BookingData.BookingId}\n" +
                $"Date : {BookingData.BookingTime:MM/dd/yyyy HH:mm}\n\n" +
                $"Customer : {customer}\n" +
                $"Pick Up : {Shorten(BookingData.Pickup)}\n" +
                $"Drop Off : {Shorten(BookingData.Destination)}\n\n" +
                $"Driver Name : {BookingData.DriverName}\n" +
                $"Car Model : {BookingData.Car}\n" +
                $"Plate No : {BookingData.PlateNumber}\n" +
                "=========================\n" +
                $"TOTAL FEES : RM {BookingData.Fee:0.00}\n" +
                $"BALANCE : RM {BookingData.RemainingBalance:0.00}\n" +
                "=========================\n" +
                "Thank You for riding MoveAble!";
        }

        // Keeps long map addresses short so they fit on the receipt label.
        private string Shorten(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "-";
            }

            return text.Length <= 30 ? text : text.Substring(0, 30) + "...";
        }

        // The Designer wires a click on the receipt label - just refresh it.
        private void lblReceipt_Click(object sender, EventArgs e)
        {
            ShowReceipt();
        }

        // Opens the live driver-tracking simulation for the current booking.
        private void btnTrackDriver_Click(object sender, EventArgs e)
        {
            if (!BookingData.HasBooking || !BookingData.PaymentCompleted)
            {
                MessageBox.Show("No paid booking was found.\nPlease complete a booking first.",
                    "Tracking unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(BookingData.Pickup) ||
                string.IsNullOrWhiteSpace(BookingData.Destination))
            {
                MessageBox.Show("Pickup or drop-off information is missing.",
                    "Tracking unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BookingData.RideCancelled)
            {
                MessageBox.Show("This ride was cancelled and can no longer be tracked.",
                    "Ride cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (BookingData.TripCompleted)
            {
                MessageBox.Show("This trip has already been completed.",
                    "Trip completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Never open a second tracking window for the same trip.
            if (Application.OpenForms.OfType<formDriverTracking>().Any())
            {
                MessageBox.Show("Driver tracking is already open.",
                    "Already tracking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            formDriverTracking trackingForm = new formDriverTracking();
            trackingForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            trackingForm.Show();
        }

        // Sidebar navigation (button1 = PROFILE, button2 = BALANCE, button3 = LET'S RIDE).
        private void button1_Click(object sender, EventArgs e)
        {
            formprofile profileForm = new formprofile();
            profileForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            profileForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbalance balanceForm = new formbalance();
            balanceForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            balanceForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLetsRide rideForm = new formLetsRide();
            rideForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            rideForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formaboutus profileForm = new formaboutus();

            profileForm.Show();
        }
    }
}

