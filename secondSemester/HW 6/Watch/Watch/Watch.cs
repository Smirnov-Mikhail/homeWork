namespace Watch
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Watch : Form
    {
        public Watch()
        {
            InitializeComponent();
            this.label.Font = new Font("Arial", 25);

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
