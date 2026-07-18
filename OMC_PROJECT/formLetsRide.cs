using System;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formLetsRide : Form
    {
        double pickupLat, pickupLng;
        double dropoffLat, dropoffLng;
        public formLetsRide()
        {
            InitializeComponent();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            formbalance form2 = new formbalance();
            form2.Show();
            this.Hide();
        }

        

        

        private void btnProfile_Click(object sender, EventArgs e)
        {
            formprofile profileForm = new formprofile();
            profileForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPickup_Click(object sender, EventArgs e)
        {
            Form1 map = new Form1();

            if (map.ShowDialog() == DialogResult.OK)
            {
                txtPickup.Text = map.SelectedAddress;
                pickupLat = map.SelectedLatitude;
                pickupLng = map.SelectedLongitude;
            }
        }

        private void btndropoff_Click(object sender, EventArgs e)
        {
            Form7 map = new Form7();

            if (map.ShowDialog() == DialogResult.OK)
            {
                txtDropoff.Text = map.SelectedAddress;
                dropoffLat = map.SelectedLatitude;
                dropoffLng = map.SelectedLongitude;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            double distance = CalculateDistance(
       pickupLat,
       pickupLng,
       dropoffLat,
       dropoffLng);

            MessageBox.Show($"Distance = {distance:F2} km");

            if (distance < 1)
            {
                MessageBox.Show("Fare = RM 2");
                Form7 payment = new Form7();
                payment.Fare = 2; // Set fare to RM 2 for distance less than 1 km
                payment.ShowDialog();

            }
            else
            {
                MessageBox.Show($"Distance = {distance:F2} km");
                double fare = distance * 0.25; // Assuming $1.5 per km

                MessageBox.Show($"Fare = RM{fare:F2}");

                Form7 payment = new Form7();
                payment.Fare = fare;
                payment.ShowDialog();
            }

        }

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            MessageBox.Show(
    $"Pickup:\nLat = {pickupLat}\nLng = {pickupLng}\n\n" +
    $"Dropoff:\nLat = {dropoffLat}\nLng = {dropoffLng}");
            const double R = 6371;

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
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

