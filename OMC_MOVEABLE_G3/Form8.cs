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
    public partial class splashhh : Form
    {
        public splashhh()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void splashhh_Load(object sender, EventArgs e)
        {
this.StartPosition = FormStartPosition.CenterScreen;

            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = @"C:\Users\anata\source\repos\OMC_PROJECT\OMCCCC\OMC_PROJECT\moveablesplash.mp4";

            axWindowsMediaPlayer1.Left = (this.ClientSize.Width - axWindowsMediaPlayer1.Width) / 2;
            axWindowsMediaPlayer1.Top = (this.ClientSize.Height - axWindowsMediaPlayer1.Height) / 2;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            timersplash.Start();
        }

        

        private void timersplash_Tick_1(object sender, EventArgs e)
        {
            timersplash.Stop();
            formlogin frm = new formlogin();
            frm.Show();

            this.Hide();
        }
    }
}
