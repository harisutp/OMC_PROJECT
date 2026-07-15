using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class formSplash : Form
    {
        public formSplash()
        {
            InitializeComponent();
        }

        private void formSplash_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;

            string videoPath = Path.Combine(Application.StartupPath, "C:\\Users\\anata\\source\\repos\\OMC_PROJECT\\OMCCCC\\OMC_PROJECT\\moveablesplash.mp4");

            if (File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else
            {
                MessageBox.Show("Video file not found: " + videoPath);
            }
            timersplash.Start();
        }

        private void timersplash_Tick(object sender, EventArgs e)
        {
            timersplash.Stop();

            formlogin form2 = new formlogin();
            form2.Show();
            this.Hide();
        }
    }
    
}

