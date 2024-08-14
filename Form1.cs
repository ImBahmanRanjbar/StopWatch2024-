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
        public Form1()
        {
            InitializeComponent();
        }
        int s = 0, m = 0, h = 0, num = 1;
        DateTime dt=Convert.ToDateTime("00:00:00");
        private void timer_Tick(object sender, EventArgs e)
        {
            s++;
            LblTimer.Text = $"{h.ToString("00")}:{m.ToString("00")}:{s.ToString("00")}";
            if (s == 60)
            {
                s = 0;
                m++;
                if (m == 60)
                {
                    m = 0;
                    h++;

                }
            }
        }

        private void bahmanButtonControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (BtnPlay.Tag=="Play")
            {
                BtnPlay.Image = Properties.Resources.paussse;
                BtnPlay.Tag = "Pause";
                BtnStop.Image = Properties.Resources.flag;
                BtnStop.Tag = "Flag";
                timer.Start();
            }
            else
            {
                BtnPlay.Image = Properties.Resources.play;
                BtnPlay.Tag = "Play";
                BtnStop.Image = Properties.Resources.stop;
                BtnStop.Tag = "Stop";
                timer.Stop();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (BtnStop.Tag=="Flag")
            {
                UC_Record record = new UC_Record();
                record.LblNum.Text = (num++).ToString("00");
                record.LblRecord.Text = LblTimer.Text;
                try
                {
                    record.LblRecordD.Text = $"+{Convert.ToDateTime(LblTimer.Text) - dt}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                flowLayoutPanel1.Controls.Add(record);
                dt = Convert.ToDateTime(LblTimer.Text);
              



            }
            else
            {
                m = s = h = 0;
                num = 1;

                LblTimer.Text= $"{h.ToString("00")}:{m.ToString("00")}:{s.ToString("00")}";
                BtnPlay.Image = Properties.Resources.play;
                BtnPlay.Tag = "Play";
                BtnStop.Image = Properties.Resources.stop;
                BtnStop.Tag = "Stop";
                flowLayoutPanel1.Controls.Clear();
                dt = Convert.ToDateTime("00:00:00");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Maximized)
            {
                LblTimer.Font = new Font("Segoe UI", 50, FontStyle.Bold);
                this.WindowState = FormWindowState.Normal;
              pnlOut.Location = new Point(275, -21);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                    pnlOut.Location = new Point(1195, 0);
                LblTimer.Font = new Font("Segoe UI", 55, FontStyle.Bold);
            }
        }
    }
}
