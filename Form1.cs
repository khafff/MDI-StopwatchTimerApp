using System.Windows.Forms;
using System;
using System.Reflection.Emit;

namespace MDI_StopwatchTimerApp
{
    public partial class FormTimer : Form
    {
        int counter = 0;
        public FormTimer()
        {
            InitializeComponent();
        }
        private void btnMulai_Click(object sender, EventArgs e)
        {
            WaktuKu.Enabled = true;
            WaktuKu.Start();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            WaktuKu.Stop();
        }
        private void WaktuKu_Tick(object sender, EventArgs e)
        {
            counter++;
            lblWaktu.Text = counter.ToString();
        }
    }
}
