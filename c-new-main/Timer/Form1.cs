using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text ="Thời Gian Hiện Tại  " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.ForeColor=Color.Red;
            lblTime.BackColor=Color.White;
            timer3.Enabled = true;
            timer2.Enabled =false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblTime.ForeColor = Color.Black;
            lblTime.BackColor = Color.Cyan;
            timer2.Enabled = true;
            timer3.Enabled=false;  
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            timer2.Enabled=true;
            timer3.Enabled=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            timer2.Enabled=false;
            timer3.Enabled=false;
        }
    }
}
