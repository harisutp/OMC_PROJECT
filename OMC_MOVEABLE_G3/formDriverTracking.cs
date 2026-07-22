using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    // Offline driver-tracking simulation.
    // The map is drawn by WebView2 from HTML that is embedded in this file
    // (no internet, no external files). If WebView2 cannot start, a plain
    // WinForms panel draws the same map as a fallback.
    public partial class formDriverTracking : Form
    {
        private enum TrackingStage
        {
            TravellingToPickup,
            WaitingAtPickup,
            TravellingToDestination,
            Completed,
            Cancelled
        }

        // --- Timing (milliseconds) ---
        private const int ToPickupMs = 8000;   // stage 1
        private const int WaitAtPickupMs = 2000;   // pause at pickup
        private const int ToDestinationMs = 10000;  // stage 2

        private static readonly Random random = new Random();

        // Normalized coordinates (0.0 - 1.0) used by both map renderers.
        private double pickupX, pickupY;
        private double dropX, dropY;
        private double driverStartX, driverStartY;
        private double driverX, driverY;

        private TrackingStage stage = TrackingStage.TravellingToPickup;
        private int stageElapsedMs = 0;
        private bool mapReady = false;          // WebView2 finished loading
        private bool useFallbackMap = false;    // WebView2 failed -> panel map
        private bool completionShown = false;   // completion message only once
        private bool closingConfirmed = false;  // allow programmatic close

        public formDriverTracking()
        {
            InitializeComponent();
        }

        private async void formDriverTracking_Load(object sender, EventArgs e)
        {
            // --- Safety checks before anything starts ---
            if (!BookingData.PaymentCompleted || !BookingData.HasBooking)
            {
                MessageBox.Show("No paid booking was found. Please complete a booking first.",
                    "Tracking unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                closingConfirmed = true;
                Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(BookingData.Pickup) ||
                string.IsNullOrWhiteSpace(BookingData.Destination))
            {
                MessageBox.Show("Pickup or drop-off information is missing.",
                    "Tracking unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                closingConfirmed = true;
                Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(BookingData.DriverName))
            {
                MessageBox.Show("Driver information is missing.",
                    "Tracking unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                closingConfirmed = true;
                Close();
                return;
            }

            // --- Fill the info panel ---
            lblDriverName.Text = "Driver : " + BookingData.DriverName;
            lblDriverCar.Text = "Car : " + BookingData.Car;
            lblDriverPlate.Text = "Plate : " + BookingData.PlateNumber;
            lblPickup.Text = "Pick Up : " + Shorten(BookingData.Pickup);
            lblDropOff.Text = "Drop Off : " + Shorten(BookingData.Destination);

            SetupCoordinates();

            // --- Buttons start in the correct state ---
            btnCancelRide.Enabled = true;
            btnTripCompleted.Enabled = true;
            btnBackHome.Enabled = false;

            // --- Start the map (WebView2 first, panel fallback second) ---
            try
            {
                await webViewTrackingMap.EnsureCoreWebView2Async();
                webViewTrackingMap.CoreWebView2.NavigationCompleted += (s2, e2) =>
                {
                    mapReady = true;
                    PushStaticMapState();
                };
                webViewTrackingMap.NavigateToString(BuildMapHtml());
            }
            catch (Exception)
            {
                // WebView2 runtime not available - fall back to the panel map.
                useFallbackMap = true;
                webViewTrackingMap.Visible = false;
                pnlFallbackMap.Visible = true;
                pnlFallbackMap.BringToFront();
            }

            // --- Start the simulation ---
            stage = TrackingStage.TravellingToPickup;
            stageElapsedMs = 0;
            driverX = driverStartX;
            driverY = driverStartY;
            UpdateStatus("Driver is on the way");
            trackingTimer.Start();
        }

        // Converts the real map lat/lng saved by formLetsRide into
        // normalized 0..1 positions. If the coordinates are missing or
        // identical, sensible fixed positions are used instead.
        private void SetupCoordinates()
        {
            double pLat = BookingData.PickupLat, pLng = BookingData.PickupLng;
            double dLat = BookingData.DropLat, dLng = BookingData.DropLng;

            bool invalid =
                (Math.Abs(pLat) < 0.0001 && Math.Abs(pLng) < 0.0001) ||
                (Math.Abs(dLat) < 0.0001 && Math.Abs(dLng) < 0.0001) ||
                (Math.Abs(pLat - dLat) < 0.000001 && Math.Abs(pLng - dLng) < 0.000001);

            if (invalid)
            {
                pickupX = 0.30; pickupY = 0.65;
                dropX = 0.72; dropY = 0.30;
            }
            else
            {
                // Bounding box around both points with padding so the
                // markers never sit on the map edge.
                double minLat = Math.Min(pLat, dLat), maxLat = Math.Max(pLat, dLat);
                double minLng = Math.Min(pLng, dLng), maxLng = Math.Max(pLng, dLng);
                double latSpan = Math.Max(maxLat - minLat, 0.0005);
                double lngSpan = Math.Max(maxLng - minLng, 0.0005);
                minLat -= latSpan * 0.35; maxLat += latSpan * 0.35;
                minLng -= lngSpan * 0.35; maxLng += lngSpan * 0.35;

                pickupX = (pLng - minLng) / (maxLng - minLng);
                pickupY = 1.0 - (pLat - minLat) / (maxLat - minLat);
                dropX = (dLng - minLng) / (maxLng - minLng);
                dropY = 1.0 - (dLat - minLat) / (maxLat - minLat);
            }

            // Driver starts a short random distance away from the pickup,
            // kept inside the map boundaries (never exactly on the pickup).
            double angle = random.NextDouble() * Math.PI * 2;
            double dist = 0.18 + random.NextDouble() * 0.10;
            driverStartX = Clamp01(pickupX + Math.Cos(angle) * dist, 0.05, 0.95);
            driverStartY = Clamp01(pickupY + Math.Sin(angle) * dist, 0.05, 0.95);
        }

        private static double Clamp01(double v, double min, double max)
        {
            if (v < min) return min;
            if (v > max) return max;
            return v;
        }

        // ------------------------------------------------------------------
        // Simulation
        // ------------------------------------------------------------------
        private void trackingTimer_Tick(object sender, EventArgs e)
        {
            if (stage == TrackingStage.Completed || stage == TrackingStage.Cancelled)
            {
                trackingTimer.Stop();
                return;
            }

            stageElapsedMs += trackingTimer.Interval;

            switch (stage)
            {
                case TrackingStage.TravellingToPickup:
                    {
                        double progress = Math.Min(1.0, (double)stageElapsedMs / ToPickupMs);
                        driverX = driverStartX + (pickupX - driverStartX) * progress;
                        driverY = driverStartY + (pickupY - driverStartY) * progress;

                        int secondsLeft = (int)Math.Ceiling((ToPickupMs - stageElapsedMs) / 1000.0);
                        if (secondsLeft < 0) secondsLeft = 0;

                        if (progress >= 1.0)
                        {
                            stage = TrackingStage.WaitingAtPickup;
                            stageElapsedMs = 0;
                            UpdateStatus("Driver has arrived at pickup");
                            lblEstimatedTime.Text = "Driver has arrived";
                        }
                        else if (progress >= 0.7)
                        {
                            UpdateStatus("Driver is approaching your pickup point");
                            lblEstimatedTime.Text = "Driver arriving in " + secondsLeft + " seconds";
                        }
                        else
                        {
                            UpdateStatus("Driver is on the way");
                            lblEstimatedTime.Text = "Driver arriving in " + secondsLeft + " seconds";
                        }

                        UpdateProgress((int)(progress * 40)); // first 40% of the bar
                        break;
                    }

                case TrackingStage.WaitingAtPickup:
                    {
                        if (stageElapsedMs >= WaitAtPickupMs)
                        {
                            stage = TrackingStage.TravellingToDestination;
                            stageElapsedMs = 0;

                            // The passenger is now in the car - cancellation
                            // is no longer allowed from this point on.
                            BookingData.PassengerPickedUp = true;
                            btnCancelRide.Enabled = false;

                            UpdateStatus("Passenger picked up - heading to destination");
                        }
                        UpdateProgress(45);
                        break;
                    }

                case TrackingStage.TravellingToDestination:
                    {
                        double progress = Math.Min(1.0, (double)stageElapsedMs / ToDestinationMs);
                        driverX = pickupX + (dropX - pickupX) * progress;
                        driverY = pickupY + (dropY - pickupY) * progress;

                        int secondsLeft = (int)Math.Ceiling((ToDestinationMs - stageElapsedMs) / 1000.0);
                        if (secondsLeft < 0) secondsLeft = 0;

                        if (progress >= 1.0)
                        {
                            CompleteTrip(false);
                        }
                        else if (progress >= 0.7)
                        {
                            UpdateStatus("Arriving at destination");
                            lblEstimatedTime.Text = "Arriving at destination in " + secondsLeft + " seconds";
                        }
                        else
                        {
                            UpdateStatus("Heading to destination");
                            lblEstimatedTime.Text = "Arriving at destination in " + secondsLeft + " seconds";
                        }

                        if (stage != TrackingStage.Completed)
                        {
                            UpdateProgress(45 + (int)(progress * 55)); // remaining 55%
                        }
                        break;
                    }
            }

            RedrawDriver();
        }

        // Shared completion logic for both automatic arrival and the
        // TRIP COMPLETED demo button.
        private void CompleteTrip(bool triggeredByButton)
        {
            trackingTimer.Stop();
            stage = TrackingStage.Completed;

            // Snap the driver exactly onto the drop-off marker.
            driverX = dropX;
            driverY = dropY;
            RedrawDriver();

            UpdateProgress(100);
            lblEstimatedTime.Text = "Arrived";
            UpdateStatus("Trip completed");

            BookingData.PassengerPickedUp = true;
            BookingData.TripCompleted = true;

            btnCancelRide.Enabled = false;
            btnTripCompleted.Enabled = false;
            btnBackHome.Enabled = true;

            if (!completionShown)
            {
                completionShown = true;
                MessageBox.Show(
                    "Trip Completed\nYou have safely arrived at your destination.",
                    "Trip Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ------------------------------------------------------------------
        // Buttons
        // ------------------------------------------------------------------
        private void btnCancelRide_Click(object sender, EventArgs e)
        {
            if (BookingData.PassengerPickedUp || stage == TrackingStage.TravellingToDestination
                || stage == TrackingStage.Completed)
            {
                MessageBox.Show(
                    "The passenger has already been picked up.\nThe ride can no longer be cancelled.",
                    "Cancellation not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BookingData.RideCancelled)
            {
                MessageBox.Show("This ride has already been cancelled.",
                    "Already cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Cancel this ride?\nYour full fee of RM " +
                BookingData.Fee.ToString("0.00", CultureInfo.InvariantCulture) +
                " will be refunded.",
                "Cancel Ride", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            CancelRideWithRefund();

            // Return the user to the main ride page.
            GoHome();
        }

        private void CancelRideWithRefund()
        {
            trackingTimer.Stop();
            stage = TrackingStage.Cancelled;

            // Refund exactly once, and only for a paid, unfinished trip.
            if (BookingData.PaymentCompleted &&
                !BookingData.RefundCompleted &&
                !BookingData.TripCompleted &&
                !BookingData.PassengerPickedUp)
            {
                AppData.Balance += BookingData.Fee;
                BookingData.RemainingBalance = AppData.Balance;
                BookingData.RefundCompleted = true;
            }

            BookingData.RideCancelled = true;

            btnCancelRide.Enabled = false;
            btnTripCompleted.Enabled = false;
            btnBackHome.Enabled = true;

            UpdateStatus("Ride cancelled");
            lblEstimatedTime.Text = "Cancelled";

            MessageBox.Show(
                "Your ride has been cancelled.\n\n" +
                "Refund: RM " + BookingData.Fee.ToString("0.00") + "\n" +
                "Current Balance: RM " + AppData.Balance.ToString("0.00"),
                "Ride Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTripCompleted_Click(object sender, EventArgs e)
        {
            if (stage == TrackingStage.Completed || stage == TrackingStage.Cancelled)
            {
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Mark this trip as completed now?",
                "Trip Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                CompleteTrip(true);
            }
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            GoHome();
        }

        // Opens the main ride page using the same navigation pattern as the
        // rest of the application: hide this form and close it when the new
        // form closes, so the whole chain unwinds correctly at the end.
        private void GoHome()
        {
            trackingTimer.Stop();

            formLetsRide home = new formLetsRide();
            home.FormClosed += (s2, e2) =>
            {
                closingConfirmed = true;
                Close();
            };
            Hide();
            home.Show();
        }

        // ------------------------------------------------------------------
        // Window close (X) safety
        // ------------------------------------------------------------------
        private void formDriverTracking_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closingConfirmed ||
                stage == TrackingStage.Completed ||
                stage == TrackingStage.Cancelled)
            {
                trackingTimer.Stop();
                return;
            }

            // An active, paid trip is running.
            if (!BookingData.PassengerPickedUp)
            {
                DialogResult answer = MessageBox.Show(
                    "A ride is in progress.\nClosing this window will cancel the ride and refund your fee.\n\nCancel the ride?",
                    "Ride in progress", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    CancelRideWithRefund();

                    // Keep the navigation chain intact: do not let this form
                    // close directly, return to the ride page instead.
                    e.Cancel = true;
                    GoHome();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show(
                    "The passenger has already been picked up.\nThe trip cannot be cancelled - please wait for it to finish.",
                    "Trip in progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        // ------------------------------------------------------------------
        // Map rendering - WebView2 (primary)
        // ------------------------------------------------------------------

        // The whole offline map lives in this C# string. It is a simple SVG
        // "navigation style" map: light background, simulated roads and
        // blocks, the route line, and the three markers.
        private string BuildMapHtml()
        {
            string px = Sv(pickupX * 1000), py = Sv(pickupY * 600);
            string dx = Sv(dropX * 1000), dy = Sv(dropY * 600);
            string sx = Sv(driverStartX * 1000), sy = Sv(driverStartY * 600);

            return @"<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8'>
<style>
  html,body { margin:0; padding:0; width:100%; height:100%; overflow:hidden; background:#e8eef2; }
  svg { width:100%; height:100%; display:block; }
  .lbl { font-family:'Segoe UI',Arial,sans-serif; font-size:22px; font-weight:bold; }
</style>
</head>
<body>
<svg viewBox='0 0 1000 600' preserveAspectRatio='xMidYMid meet' xmlns='http://www.w3.org/2000/svg'>
  <!-- map background -->
  <rect x='0' y='0' width='1000' height='600' fill='#e8eef2'/>

  <!-- simulated city blocks -->
  <rect x='60'  y='60'  width='180' height='120' fill='#d4dde4' rx='8'/>
  <rect x='300' y='40'  width='220' height='150' fill='#cfd9e1' rx='8'/>
  <rect x='600' y='70'  width='160' height='110' fill='#d4dde4' rx='8'/>
  <rect x='80'  y='420' width='200' height='120' fill='#cfd9e1' rx='8'/>
  <rect x='420' y='430' width='240' height='110' fill='#d4dde4' rx='8'/>
  <rect x='760' y='380' width='170' height='150' fill='#cfd9e1' rx='8'/>
  <rect x='680' y='240' width='120' height='90'  fill='#dce4ea' rx='8'/>
  <rect x='150' y='250' width='120' height='90'  fill='#dce4ea' rx='8'/>

  <!-- simulated roads -->
  <line x1='0' y1='220' x2='1000' y2='220' stroke='#ffffff' stroke-width='26'/>
  <line x1='0' y1='390' x2='1000' y2='390' stroke='#ffffff' stroke-width='26'/>
  <line x1='280' y1='0' x2='280' y2='600' stroke='#ffffff' stroke-width='24'/>
  <line x1='560' y1='0' x2='560' y2='600' stroke='#ffffff' stroke-width='24'/>
  <line x1='820' y1='0' x2='820' y2='600' stroke='#ffffff' stroke-width='20'/>
  <line x1='0' y1='220' x2='1000' y2='220' stroke='#f4c542' stroke-width='3' stroke-dasharray='18 14'/>
  <line x1='0' y1='390' x2='1000' y2='390' stroke='#f4c542' stroke-width='3' stroke-dasharray='18 14'/>

  <!-- route: driver start -> pickup (dashed), pickup -> drop-off (solid) -->
  <line id='routeToPickup' x1='" + sx + @"' y1='" + sy + @"' x2='" + px + @"' y2='" + py + @"'
        stroke='#4a90d9' stroke-width='6' stroke-dasharray='14 10' stroke-linecap='round'/>
  <line id='routeToDrop' x1='" + px + @"' y1='" + py + @"' x2='" + dx + @"' y2='" + dy + @"'
        stroke='#2d6cdf' stroke-width='7' stroke-linecap='round'/>

  <!-- pickup marker (green) -->
  <circle cx='" + px + @"' cy='" + py + @"' r='16' fill='#2ecc71' stroke='#ffffff' stroke-width='4'/>
  <text x='" + px + @"' y='" + Sv(pickupY * 600 - 26) + @"' text-anchor='middle' class='lbl' fill='#1e8449'>PICKUP</text>

  <!-- drop-off marker (red) -->
  <circle cx='" + dx + @"' cy='" + dy + @"' r='16' fill='#e74c3c' stroke='#ffffff' stroke-width='4'/>
  <text x='" + dx + @"' y='" + Sv(dropY * 600 - 26) + @"' text-anchor='middle' class='lbl' fill='#922b21'>DROP-OFF</text>

  <!-- driver marker (blue, with car symbol) -->
  <g id='driver'>
    <circle id='driverDot' cx='" + sx + @"' cy='" + sy + @"' r='18' fill='#2d6cdf' stroke='#ffffff' stroke-width='4'/>
    <text id='driverIcon' x='" + sx + @"' y='" + Sv(driverStartY * 600 + 8) + @"' text-anchor='middle' font-size='20'>&#128663;</text>
    <text id='driverLbl' x='" + sx + @"' y='" + Sv(driverStartY * 600 - 28) + @"' text-anchor='middle' class='lbl' fill='#1a4fa0'>DRIVER</text>
  </g>
</svg>
<script>
  // Called from C# every timer tick with normalized coordinates.
  function updateDriver(nx, ny) {
    var x = nx * 1000, y = ny * 600;
    var dot = document.getElementById('driverDot');
    var icon = document.getElementById('driverIcon');
    var lbl = document.getElementById('driverLbl');
    if (dot)  { dot.setAttribute('cx', x); dot.setAttribute('cy', y); }
    if (icon) { icon.setAttribute('x', x); icon.setAttribute('y', y + 8); }
    if (lbl)  { lbl.setAttribute('x', x); lbl.setAttribute('y', y - 28); }
  }
</script>
</body>
</html>";
        }

        // Invariant-culture number for embedding into the HTML/JS.
        private static string Sv(double value)
        {
            return value.ToString("0.##", CultureInfo.InvariantCulture);
        }

        private void PushStaticMapState()
        {
            RedrawDriver();
        }

        // Moves the driver marker on whichever renderer is active.
        private void RedrawDriver()
        {
            if (useFallbackMap)
            {
                pnlFallbackMap.Invalidate();
                return;
            }

            if (!mapReady || webViewTrackingMap.IsDisposed || webViewTrackingMap.CoreWebView2 == null)
            {
                return;
            }

            try
            {
                string script = "updateDriver(" + Sv(driverX) + "," + Sv(driverY) + ");";
                var ignored = webViewTrackingMap.ExecuteScriptAsync(script);
            }
            catch (Exception)
            {
                // The WebView2 control was disposed while a tick was pending.
                // Switch to the fallback renderer instead of crashing.
                useFallbackMap = true;
                if (!pnlFallbackMap.IsDisposed)
                {
                    pnlFallbackMap.Visible = true;
                }
            }
        }

        // ------------------------------------------------------------------
        // Map rendering - WinForms panel (fallback when WebView2 fails)
        // ------------------------------------------------------------------
        private void pnlFallbackMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int w = pnlFallbackMap.ClientSize.Width;
            int h = pnlFallbackMap.ClientSize.Height;
            if (w < 50 || h < 50) return;

            g.Clear(Color.FromArgb(232, 238, 242));

            // simulated blocks
            using (Brush block = new SolidBrush(Color.FromArgb(212, 221, 228)))
            {
                g.FillRectangle(block, (int)(w * 0.06), (int)(h * 0.10), (int)(w * 0.18), (int)(h * 0.20));
                g.FillRectangle(block, (int)(w * 0.30), (int)(h * 0.07), (int)(w * 0.22), (int)(h * 0.25));
                g.FillRectangle(block, (int)(w * 0.60), (int)(h * 0.12), (int)(w * 0.16), (int)(h * 0.18));
                g.FillRectangle(block, (int)(w * 0.08), (int)(h * 0.70), (int)(w * 0.20), (int)(h * 0.20));
                g.FillRectangle(block, (int)(w * 0.42), (int)(h * 0.72), (int)(w * 0.24), (int)(h * 0.18));
                g.FillRectangle(block, (int)(w * 0.76), (int)(h * 0.63), (int)(w * 0.17), (int)(h * 0.25));
            }

            // simulated roads
            using (Pen road = new Pen(Color.White, Math.Max(10, h / 28)))
            {
                g.DrawLine(road, 0, (int)(h * 0.37), w, (int)(h * 0.37));
                g.DrawLine(road, 0, (int)(h * 0.65), w, (int)(h * 0.65));
                g.DrawLine(road, (int)(w * 0.28), 0, (int)(w * 0.28), h);
                g.DrawLine(road, (int)(w * 0.56), 0, (int)(w * 0.56), h);
                g.DrawLine(road, (int)(w * 0.82), 0, (int)(w * 0.82), h);
            }

            Point pickup = new Point((int)(pickupX * w), (int)(pickupY * h));
            Point drop = new Point((int)(dropX * w), (int)(dropY * h));
            Point start = new Point((int)(driverStartX * w), (int)(driverStartY * h));
            Point driver = new Point((int)(driverX * w), (int)(driverY * h));

            // route lines
            using (Pen dashed = new Pen(Color.FromArgb(74, 144, 217), 4))
            {
                dashed.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(dashed, start, pickup);
            }
            using (Pen solid = new Pen(Color.FromArgb(45, 108, 223), 5))
            {
                g.DrawLine(solid, pickup, drop);
            }

            using (Font f = new Font("Segoe UI", 10, FontStyle.Bold))
            {
                DrawMarker(g, pickup, Color.FromArgb(46, 204, 113), "PICKUP", f);
                DrawMarker(g, drop, Color.FromArgb(231, 76, 60), "DROP-OFF", f);
                DrawMarker(g, driver, Color.FromArgb(45, 108, 223), "DRIVER", f);
            }
        }

        private void DrawMarker(Graphics g, Point p, Color color, string label, Font font)
        {
            const int r = 12;
            using (Brush b = new SolidBrush(color))
            {
                g.FillEllipse(b, p.X - r, p.Y - r, r * 2, r * 2);
            }
            using (Pen white = new Pen(Color.White, 3))
            {
                g.DrawEllipse(white, p.X - r, p.Y - r, r * 2, r * 2);
            }

            SizeF size = g.MeasureString(label, font);
            using (Brush text = new SolidBrush(Color.FromArgb(40, 40, 40)))
            {
                g.DrawString(label, font, text, p.X - size.Width / 2, p.Y - r - size.Height - 2);
            }
        }

        private void pnlFallbackMap_Resize(object sender, EventArgs e)
        {
            pnlFallbackMap.Invalidate();
        }

        // ------------------------------------------------------------------
        // Helpers
        // ------------------------------------------------------------------
        private void UpdateStatus(string status)
        {
            lblTrackingStatus.Text = status;
        }

        private void UpdateProgress(int percent)
        {
            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;
            progressTrip.Value = percent;
            lblProgress.Text = "Trip progress : " + percent + "%";
        }

        private string Shorten(string text)
        {
            if (string.IsNullOrEmpty(text)) return "-";
            return text.Length <= 34 ? text : text.Substring(0, 34) + "...";
        }
    }
}
