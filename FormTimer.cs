using System;
using System.Windows.Forms;

namespace MDI_StopwatchTimerApp
{
    public partial class FormTimer : Form
    {
        private int totalDetik = 300; // Default: 5 menit (5*60 detik)
        private bool isRunning = false;

        public FormTimer()
        {
            InitializeComponent();
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            UpdateLabelWaktu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalDetik > 0)
            {
                totalDetik--;
                UpdateLabelWaktu();
            }
            else
            {
                timer1.Stop();
                isRunning = false;
                buttonMulaiPause.Text = "Mulai";
            }
        }

        private void buttonMulaiPause_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                buttonMulaiPause.Text = "Mulai";
            }
            else
            {
                timer1.Start();
                buttonMulaiPause.Text = "Pause";
            }
            isRunning = !isRunning;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
            totalDetik = 300;
            UpdateLabelWaktu();
            buttonMulaiPause.Text = "Mulai";
        }

        private void button5menit_Click(object sender, EventArgs e)
        {
            totalDetik += 300;
            UpdateLabelWaktu();
        }

        private void button10menit_Click(object sender, EventArgs e)
        {
            totalDetik += 600;
            UpdateLabelWaktu();
        }

        private void button30menit_Click(object sender, EventArgs e)
        {
            totalDetik += 1800;
            UpdateLabelWaktu();
        }

        private void UpdateLabelWaktu()
        {
            int menit = totalDetik / 60;
            int detik = totalDetik % 60;
            labelMenit.Text = menit.ToString();
            labelDetik.Text = detik.ToString("D2");
        }
    }
}
