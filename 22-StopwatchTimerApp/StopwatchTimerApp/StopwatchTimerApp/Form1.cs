using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopwatchTimerApp
{
    public partial class Form1 : Form
    {
        private int milliseconds = 0;
        private int seconds = 0;
        private int minutes = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milliseconds += 10;

            if (milliseconds >= 1000)
            {
                milliseconds = 0;
                seconds++;
            }

            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;      
            }

            lblTime.Text = $"{minutes:00}:{seconds:00}:{milliseconds / 10:00}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            minutes = 0;
            seconds = 0;
            milliseconds = 0;
            lblTime.Text = "00:00:00";
        }
    }
}
