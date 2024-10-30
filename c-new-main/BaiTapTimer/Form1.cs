using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            backgroundWorker3.RunWorkerAsync(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backgroundWorker4.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {   
            
            for (int i=1; i < 100;i++)
            {
                Thread.Sleep(25);
                backgroundWorker1.ReportProgress(i);
            }
        
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnA.Visible = false;
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.Visible = true;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                progressBar1.Visible = false;
                btnA.Visible = true;
                timer1.Enabled = true;
            }
        }
        bool trigger = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(trigger)
            {
                btnA.BackColor = Color.Green;
                trigger=false;
            }
            else
            {
                btnA.BackColor = Color.Cyan;
                trigger=true;  
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=1;i<100;i++)
            {
                Thread.Sleep(25);
                backgroundWorker2.ReportProgress(i);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnB.Visible = false;
            progressBar2.Value = e.ProgressPercentage;
            progressBar2.Visible = true;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                progressBar2.Visible = false;
                btnB.Visible = true;
                btnB.BackColor = Color.Red;
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                Thread.Sleep(25);
                backgroundWorker3.ReportProgress(i);
            }
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnC.Visible = false;
            progressBar3.Value = e.ProgressPercentage;
            progressBar3.Visible = true;
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                progressBar3.Visible = false;
                btnC.Visible = true;
                btnC.BackColor = Color.Red;
            }
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                Thread.Sleep(25);
                backgroundWorker4.ReportProgress(i);
            }
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btnD.Visible = false;
            progressBar4.Value = e.ProgressPercentage;
            progressBar4.Visible = true;
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                progressBar4.Visible = false;
                btnD.Visible = true;
                btnD.BackColor = Color.Red;
            }
        }
    }
}
