using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;

namespace OMC_PROJECT
{
    // Map dialog used to choose the PICK UP location.
    public partial class MapForm : Form
    {
        public string SelectedAddress { get; private set; }
        public double SelectedLatitude { get; private set; }
        public double SelectedLongitude { get; private set; }

        public MapForm()
        {
            InitializeComponent();

            // Pressing Enter in the search box works like clicking SEARCH.
            txtSearch.KeyDown += txtSearch_KeyDown;
        }

        private async void MapForm_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();

                webView21.CoreWebView2.WebMessageReceived += WebView21_WebMessageReceived;

                string html = @"
<!DOCTYPE html>
<html>
<head>
<link rel='stylesheet' href='https://unpkg.com/leaflet/dist/leaflet.css'/>
<script src='https://unpkg.com/leaflet/dist/leaflet.js'></script>
</head>
<body style='margin:0;'>
<div id='map' style='width:100%;height:100vh;'></div>
<script>
var map=L.map('map').setView([4.5975,101.0901],13);
L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png').addTo(map);
var marker;
map.on('click', function(e){
    if(marker){ map.removeLayer(marker); }
    marker=L.marker(e.latlng).addTo(map);
    window.chrome.webview.postMessage({ lat:e.latlng.lat, lng:e.latlng.lng });
});
</script>
</body>
</html>";

                webView21.NavigateToString(html);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The map could not be loaded.\n\n" + ex.Message,
                    "Map Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void WebView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                JObject obj = JObject.Parse(e.WebMessageAsJson);

                double lat = obj["lat"].Value<double>();
                double lng = obj["lng"].Value<double>();

                SelectedLatitude = lat;
                SelectedLongitude = lng;

                await ReverseGeocode(lat, lng);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read the selected location.\n\n" + ex.Message,
                    "Map Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Converts coordinates into a readable address.
        private async Task ReverseGeocode(double lat, double lng)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("OMCProject/1.0");

                string url =
                    $"https://nominatim.openstreetmap.org/reverse?format=jsonv2&lat={lat}&lon={lng}";

                string json = await client.GetStringAsync(url);

                JObject obj = JObject.Parse(json);

                SelectedAddress = obj["display_name"].ToString();
                txtSearch.Text = SelectedAddress;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string place = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(place))
            {
                MessageBox.Show("Enter a location to search.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("OMCProject/1.0");

                    string url =
                        $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(place)}&format=jsonv2&limit=1";

                    string json = await client.GetStringAsync(url);

                    JArray result = JArray.Parse(json);

                    if (result.Count == 0)
                    {
                        MessageBox.Show("Location not found.", "Search",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    double lat = double.Parse(result[0]["lat"].ToString());
                    double lon = double.Parse(result[0]["lon"].ToString());

                    SelectedLatitude = lat;
                    SelectedLongitude = lon;

                    await webView21.ExecuteScriptAsync($@"
                        map.setView([{lat}, {lon}], 16);
                        if(marker){{ map.removeLayer(marker); }}
                        marker = L.marker([{lat}, {lon}]).addTo(map);
                    ");

                    await ReverseGeocode(lat, lon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The search failed. Please check your internet connection.\n\n" + ex.Message,
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // A location must be chosen before this dialog can return OK.
            if (string.IsNullOrEmpty(SelectedAddress))
            {
                MessageBox.Show("Please click a point on the map or search for a location first.",
                    "No Location Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
