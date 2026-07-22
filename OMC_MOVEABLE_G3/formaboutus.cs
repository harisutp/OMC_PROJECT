using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formaboutus : Form
    {
        public formaboutus()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnkChatWS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://wa.me/601140307211?text=Hello%20I%20would%20like%20to%20know%20more.";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
