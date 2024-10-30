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

namespace BaiTapBackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=1;i<100;i++)
            {
                Thread.Sleep(25);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            btn1.Visible = false;
            progressBar1.Visible = true;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);            }
            else
            {
                progressBar1.Visible=false;
                btn1.Visible=true;
                btn1.BackColor = Color.Red;
                
            }
        }
        bool trigger = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(trigger)
            {
                btn2.BackColor = Color.Green;
                trigger=false;
            }
            else
            {
                btn2.BackColor = Color.Cyan;
                trigger = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 100; i++) {
                Thread.Sleep(25);
                backgroundWorker2.ReportProgress(i);
            }

        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value=e.ProgressPercentage;
            btn2.Visible = false;
            progressBar2.Visible=true;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error !=null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                timer1.Enabled = true;
                btn2.Visible = true;
                progressBar2.Visible = false;
                lblComplain.Visible = true;
            }
        }

        private void lblCauHoi_Click(object sender, EventArgs e)
        {

        }
    }
}
