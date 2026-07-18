using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace OMC_PROJECT
{
    public string SelectedAddress { get; private set; }
    public double SelectedLatitude { get; private set; }
    public double SelectedLongitude { get; private set; }
    public string SelectedAddress { get; private set; }
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private async void Form7_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            webView21.CoreWebView2.WebMessageReceived += WebView21_WebMessageReceived;

            string html = @"
<!DOCTYPE html>
<html>
<head>

<link rel='stylesheet'
href='https://unpkg.com/leaflet/dist/leaflet.css'/>

<script src='https://unpkg.com/leaflet/dist/leaflet.js'></script>

</head>

<body style='margin:0;'>

<div id='map' style='width:100%;height:100vh;'></div>

<script>

var map=L.map('map').setView([4.5975,101.0901],13);

L.tileLayer(
'https://tile.openstreetmap.org/{z}/{x}/{y}.png'
).addTo(map);

var marker;

map.on('click', function(e){
    if(marker){
        map.removeLayer(marker);
    }
    marker=L.marker(e.latlng).addTo(map);
    var lat=e.latlng.lat;
    var lng=e.latlng.lng;
    window.chrome.webview.postMessage({
lat:lat,
lng:lng
}); 
});

</script>

</body>
</html>";

            webView21.NavigateToString(html);
        }

        private

        private async void WebView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            MessageBox.Show(e.WebMessageAsJson);
            JObject obj = JObject.Parse(e.WebMessageAsJson);

            double lat = obj["lat"].Value<double>();
            double lng = obj["lng"].Value<double>();

            SelectedLatitude = lat;
            SelectedLongitude = lng;
            await ReverseGeocode(lat, lng);
        }

        private async Task ReverseGeocode(double lat, double lng)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("OMCProject/1.0");

                string url =
                $"https://nominatim.openstreetmap.org/reverse?format=jsonv2&lat={lat}&lon={lng}";

                string json = await client.GetStringAsync(url);

                JObject obj = JObject.Parse(json);

                string address = obj["display_name"].ToString();

                SelectedAddress = address;
                MessageBox.Show(SelectedAddress);

                txtSearch.Text = address;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {

            string place = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(place))
            {
                MessageBox.Show("Enter a location.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("OMCProject/1.0");

                string url =
                    $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(place)}&format=jsonv2&limit=1";

                string json = await client.GetStringAsync(url);

                JArray result = JArray.Parse(json);

                if (result.Count == 0)
                {
                    MessageBox.Show("Location not found.");
                    return;
                }

                double lat = double.Parse(result[0]["lat"].ToString());
                double lon = double.Parse(result[0]["lon"].ToString());

                // Save coordinates even without map click
                SelectedLatitude = lat;
                SelectedLongitude = lon;

                await webView21.ExecuteScriptAsync($@"
            map.setView([{lat}, {lon}], 16);

            if(marker){{
                map.removeLayer(marker);
            }}

            marker = L.marker([{lat}, {lon}]).addTo(map);
        ");

                await ReverseGeocode(lat, lon);
            }
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

