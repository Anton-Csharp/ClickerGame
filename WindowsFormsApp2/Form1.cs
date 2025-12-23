using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int clicks = 0;
        public int timer = 10;
        public int upg = 1;
        public int price2X = 30;
        public int price1CLk = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            clicks+=upg;
            label1.Text = "клики:" + clicks;
            if (timer1.Enabled)
            {
                clicks += upg;
            }
            if (clicks >= 1000)
            {
                label6.Text = "первые 1000 кликов!!!!!";
                if (clicks>=10000)
                {
                    label6.Text = "первые 10,000 кликов!!!!!";
                    if (clicks>= 1000000)
                    {
                        label6.Text = "первые 1,000,000 кликов!!!!!";
                    }
                }
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicks >= price2X)
            {
                clicks -= price2X;
                timer1.Start();
                price2X *= 2;
                label4.Text = price2X + " кликов";
                label1.Text = "клики:" + clicks;
            }
            else
            {
                MessageBox.Show("не хватает кликов");
            }
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "таймер:" + timer;
            timer--;
            if (timer<=0)
            {
                timer1.Stop();
                timer = 10;
                label2.Text = "таймер:";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicks>=price1CLk)
            {
                clicks -= price1CLk;
                upg++;
                price1CLk *= 2;
                label3.Text = price1CLk + " кликов";
                label1.Text = "клики:" + clicks;
            }
            else
            {
                MessageBox.Show("не хватает кликов");
            }
        }
    }
}
