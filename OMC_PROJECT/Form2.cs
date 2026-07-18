using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMC_PROJECT
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timersplash.Stop();
            //Form2 form2 = new Form2();
            //form2.Show();
            this.Hide(); //hide better bcs close usually exits from the app
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void splashscreen_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL =
                @"C:\Users\anata\Downloads\moveable.vid.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timersplash.Start();
        }

        private void timersplash_Tick(object sender, EventArgs e)
        {
            timersplash.Stop();
            var frm = new formLetsRide();
            frm.Show();
            this.Hide(); //hide better bcs close usually exits from the app
        }
    }
}
