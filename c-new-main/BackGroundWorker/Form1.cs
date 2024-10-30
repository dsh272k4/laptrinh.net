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

namespace BackGroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int lastNumber;

        private void txtTong_TextChanged(object sender, EventArgs e)
        {
            string input=txtTong.Text;
            if (int.TryParse(input, out int tong) )
            {
                lastNumber = int.Parse(input);
            }
            else if(input=="")
            {
                lastNumber=0;
            }
            else
            {
                MessageBox.Show("nhập 1 số nguyên hợp lệ");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= lastNumber; i++)
            {
                Thread.Sleep(100);
                sum += i;
                int progressPercentage = (int)((i / (double)lastNumber) * 100);
                backgroundWorker1.ReportProgress(progressPercentage);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel= true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }

            }
            e.Result = sum;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text=e.ProgressPercentage.ToString()+"%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                lblMessage.Text = "Tiến trình bị hủy";
            }
            else if(e.Error != null) 
            {
                lblMessage.Text=e.Error.Message;
            }
            else
            {
                lblMessage.Text="Kết quả : " + e.Result.ToString(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if(backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                lblMessage.Text = "Đang xử lý";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                lblMessage.Text = "Đã chạy xong chương trình";
            }

        }
    }
}
