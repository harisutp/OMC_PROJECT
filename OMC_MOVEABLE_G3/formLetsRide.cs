using System;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formLetsRide : Form
    {
        // Coordinates returned by the map forms.
        private double pickupLat, pickupLng;
        private double dropoffLat, dropoffLng;
        private bool pickupChosen = false;
        private bool dropoffChosen = false;

        public formLetsRide()
        {
            InitializeComponent();

        }

        private void btnPickup_Click(object sender, EventArgs e)
        {
            using (MapForm map = new MapForm())
            {
                if (map.ShowDialog() == DialogResult.OK)
                {
                    lblPickup.Text = map.SelectedAddress;
                    pickupLat = map.SelectedLatitude;
                    pickupLng = map.SelectedLongitude;
                    pickupChosen = true;
                }
            }
        }

        private void btndropoff_Click(object sender, EventArgs e)
        {
            using (Form7 map = new Form7())
            {
                if (map.ShowDialog() == DialogResult.OK)
                {
                    lblDropOff.Text = map.SelectedAddress;
                    dropoffLat = map.SelectedLatitude;
                    dropoffLng = map.SelectedLongitude;
                    dropoffChosen = true;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Both locations must be selected before continuing.
            if (!pickupChosen)
            {
                MessageBox.Show("Please choose a pick up location first.",
                    "Missing pick up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dropoffChosen)
            {
                MessageBox.Show("Please choose a drop off location first.",
                    "Missing drop off", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pickup = lblPickup.Text;
            string destination = lblDropOff.Text;

            // Fee: fixed price for the three known OKU destinations,
            // otherwise a simple distance-based fare (minimum RM 2.00).
            double distanceKm = CalculateDistance(pickupLat, pickupLng, dropoffLat, dropoffLng);
            decimal distanceFare = Math.Max(2.00m, Math.Round((decimal)distanceKm * 1.50m, 2));

            // Save the trip details for the receipt and the tracking map.
            BookingData.Pickup = pickup;
            BookingData.Destination = destination;
            BookingData.PickupLat = pickupLat;
            BookingData.PickupLng = pickupLng;
            BookingData.DropLat = dropoffLat;
            BookingData.DropLng = dropoffLng;

            // A new trip starts now - clear any state from a previous trip.
            BookingData.ResetTripState();

            formPay payForm = new formPay(destination, distanceFare);
            payForm.FormClosed += (s2, e2) => this.Close();
            this.Hide();
            payForm.Show();
        }

        // Straight-line distance between two coordinates in km (Haversine formula).
        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // Earth radius in km

            double dLat = (lat2 - lat1) * Math.PI / 180;
            double dLon = (lon2 - lon1) * Math.PI / 180;

            double a =
                Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(lat1 * Math.PI / 180) *
                Math.Cos(lat2 * Math.PI / 180) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c;
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

        // Empty handlers kept because the Designer wires them.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRide_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formaboutus profileForm = new formaboutus();
          
            profileForm.Show();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
