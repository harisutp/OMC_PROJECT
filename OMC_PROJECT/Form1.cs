using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace OMC_PROJECT
{
    public partial class MapForm : Form
    {
        public string SelectedAddress { get; private set; }
        public MapForm()
        {
            InitializeComponent();
        }

        private async void MapForm_Load(object sender, EventArgs e)
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedAddress);
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void WebView21_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            MessageBox.Show(e.WebMessageAsJson);
            JObject obj = JObject.Parse(e.WebMessageAsJson);

            double lat = obj["lat"].Value<double>();
            double lng = obj["lng"].Value<double>();

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

                lblAddress.Text = address;
            }
        }
    }
}


    
    

