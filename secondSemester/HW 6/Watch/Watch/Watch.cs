using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch
{
    public partial class Watch : Form
    {
        public Watch()
        {
            InitializeComponent();
            label.Font = new Font("Arial", 25);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label.Text = dt.Hour + ":" + dt.Minute + ":" + dt.Second;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
