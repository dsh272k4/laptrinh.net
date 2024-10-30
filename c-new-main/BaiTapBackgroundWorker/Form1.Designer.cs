namespace BaiTapBackgroundWorker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblComplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(240, 140);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(127, 28);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Có";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(240, 193);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(127, 28);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Không";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCauHoi.Location = new System.Drawing.Point(236, 75);
            this.lblCauHoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(604, 37);
            this.lblCauHoi.TabIndex = 2;
            this.lblCauHoi.Text = "BackgroundWorker có thể chạy nhiều tác vụ đồng thời không? Giải Thích?";
            this.lblCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCauHoi.Click += new System.EventHandler(this.lblCauHoi_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(240, 140);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 28);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(240, 193);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(133, 28);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblComplain
            // 
            this.lblComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblComplain.Location = new System.Drawing.Point(240, 249);
            this.lblComplain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplain.Name = "lblComplain";
            this.lblComplain.Size = new System.Drawing.Size(600, 100);
            this.lblComplain.TabIndex = 5;
            this.lblComplain.Text = "Giải Thích:\r\nMỗi đối tượng BackgroundWorker được thiết kế để thực hiện một tác vụ" +
    " duy nhất tại một thời điểm\r\nBackgroundWorker sử dụng một luồng duy nhất để thực" +
    " hiện tác vụ nền";
            this.lblComplain.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblComplain);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblCauHoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblComplain;
    }
}

