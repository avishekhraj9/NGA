using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int times, timemin, timehr;
        bool isActive;
        int lapCount = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
            lstlap.Items.Clear();
            lapCount = 1;
        }

        private void ResetTime()
        {
            times = 0;
            timemin = 0;
            timehr = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();
            isActive = false;
        }

        private void btnlap_Click(object sender, EventArgs e)
        {
            string lapTime = $"timehr: {timehr:00} timemin: {timemin:00} times: {times:00}";
            lstlap.Items.Add($"Lap {lapCount}: {lapTime}");
            lapCount++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                times++;
                if (times >= 60)
                {
                    timemin++;
                    times = 0;

                    if (timemin >= 60)
                    {
                        timehr++;
                        timemin = 0;

                    }

                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            lblsec.Text = String.Format("{0:00}", times);
            lblmin.Text = String.Format("{0:00}", timemin);
            lblhr.Text = String.Format("{0:00}", timehr);
        }
    }
}
