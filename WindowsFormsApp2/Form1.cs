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
        public int PrestigeCof = 1;
        public Random rnd = new Random();
        public int clicks = 0;
        public int shopPoint = 0;
        public int timer = 10;
        public int upg = 1;
        public int price2X = 30;
        public int price1CLk = 10;
        public int priceGame = 250;
        public int exp = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            clicks += upg*PrestigeCof;
            exp+= 1*PrestigeCof;
            label14.Text = "ваш опыт:"+exp;
            label1.Text = "клики:" + clicks;
            label12.Text = "ваши клики за 1 нажатие:" + upg;
            if (timer1.Enabled)
            {
                clicks += upg*PrestigeCof;
            }
            if (shopPoint >= 10)
            {
                label6.Text = "10 покупок в магазе!!!";
                MessageBox.Show("ваша награда:+3 клика");
                upg += 3;

            }
            if (clicks >= 10000)
            { 
               label6.Text = "первые 10,000 кликов!!!!!";
               MessageBox.Show("ваша награда:+30 секунд 2х");
                timer = 30;
                timer1.Start();
            }
            if (clicks>= 1000000)
            {
               label6.Text = "первые 1,000,000 кликов!!!!!";
                MessageBox.Show("ваша награда:+5 клика и +30 секунд 2х");
                label10.Font = new Font(label10.Font, FontStyle.Strikeout);
                upg += 5;
                timer = 30;
                timer1.Start();
            }
            if (exp >= 999)
            {
                button6.Visible = false;
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicks >= price2X)
            {
                clicks -= price2X;
                shopPoint += 1*PrestigeCof;
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
                upg += 1 * PrestigeCof;
                shopPoint++;
                price1CLk *= 2;
                label3.Text = price1CLk + " кликов";
                label1.Text = "клики:" + clicks;
                if (shopPoint>=15)
                {
                    label11.Font = new Font(label11.Font, FontStyle.Strikeout);
                    MessageBox.Show("ваша награда:+20 секунд 2х");
                    timer = 20;
                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("не хватает кликов");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (exp>=5000 && clicks >= 100000 && shopPoint >= 20)
            {
                clicks = 0;
                upg = 1;
                shopPoint = 0;
                price2X = 30;
                price1CLk = 10;
                exp = 0;
                PrestigeCof++;
                button4.Visible = false;
                label13.Visible = false;
            }
            else
            {
                MessageBox.Show("вам не хватает");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clicks >= priceGame)
            {
                clicks -= priceGame;
                int num = rnd.Next(1, 5);
                int btnNum = int.Parse(textBox1.Text);
                if (btnNum==num)
                {
                    MessageBox.Show("поздравляю,вы выйграли!!!");
                    MessageBox.Show("ваша награда:+10 кликов");
                    upg += 10;
                }
                priceGame += 100;
            }
            else
            {
                MessageBox.Show("вам не хватает");
            }
        }

       
    }
}
