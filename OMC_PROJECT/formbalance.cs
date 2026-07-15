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
    public partial class formbalance : Form
    {
        public formbalance()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formbank secondForm = new formbank();


            secondForm.Show();


            this.Hide();
        }

        private void formbalance_Load(object sender, EventArgs e)
        {

        }
    }

    internal class formbank
    {
    }
}
