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

namespace backgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //cong viec chinh mat thoi gian
            int sum = 0;
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum += i;
                backgroundWorker1.ReportProgress(i);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text=e.ProgressPercentage.ToString()+"%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label2.Text = "tien trinh bi huy";
            }
            else if (e.Error != null) {
                label2.Text=e.Error.Message;
            }
            else
            {
                label2.Text = "ket qua la "+e.Result.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else {
                label2.Text = "chuong trinh dang chay";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                label2.Text = "ko co chuong trinh chay";
            }
        }
    }
}
