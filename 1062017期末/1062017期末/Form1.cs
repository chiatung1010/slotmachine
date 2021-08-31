using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1062017期末
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            Form2 inter = new Form2();
            Form3 a = new Form3();
            if (inter.ShowDialog() == DialogResult.OK)//呼叫Form2
            {
                if (a.ShowDialog() == DialogResult.OK)//Form3
                { 
                   
                }
            }
        }
   
        int sum=100;//每日基本金額
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer2.Enabled = true;//判斷下注金額是不是有數次且大於零
            trackBar1.Maximum = sum;//trackBar1最大值 等於剩餘金額
            textBox2.Text = trackBar1.Value.ToString();//將trackbar上的數值顯示在本次下注金額內
            textBox1.Text = (sum-int.Parse(textBox2.Text)).ToString();//剩下金額減本次下注金額，顯示在剩下金額，隨數值增減而改變
        }
        

        private void button1_Click_1(object sender, EventArgs e)//start
        {
            timer2.Enabled = false;//關掉才不會影響start的開關
            label4.Text = "究竟會不會中獎呢......";
            label5.Text = "開始囉~下注金額無法更改!" + "抓緊時機按下stop吧!";
            pictureBox1.BackgroundImage = null;//問號圖片
            pictureBox2.BackgroundImage = null;
            pictureBox3.BackgroundImage = null;
            timer1.Enabled = true;//按下按鈕就開始
            timer1.Interval = 50;//跑圖片的速度
            button2.Enabled = true;//打開stop按鈕
            button1.Enabled = false;//關掉start按鈕
            trackBar1.Enabled = false;//開啟trackbar
            sum = int.Parse(textBox1.Text);//會將最後剩下的金額存回給sum，讓sum按下stop可以計算
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer2.Enabled = true;//判斷下注金額是不是有數次且大於零
            label5.Text = "新的一局你可以重新下注唷!";
            trackBar1.Enabled = true;//再次打開trackbar
            //button1.Enabled = false;//關掉start按鈕
            button2.Enabled = false;//關掉stop按鈕
            timer1.Enabled = false;//按下按鈕就停止

            if (a == b && a == c && b == c)
            {
                label4.Text = "恭喜你!成功拿回獎金與賭注金唷~ :'> ";//拿回賭注金，再多拿一倍獎金
                sum = sum + int.Parse(textBox2.Text) * 2;
            }
            else if (a != b && a != c && b != c)
            {
                label4.Text = "失敗了...你被扣錢了!再加油~ :( ";//失去賭注金，並扣除一倍獎金
                sum = sum - int.Parse(textBox2.Text);
            }
            else
            {
                label4.Text = "差一點點!再試試看...賭注金先幫你保管囉!ˊ__>ˋ";//失去賭注金
            }
                
            textBox2.Text = 0.ToString();
            textBox1.Text = sum.ToString();//將計算完的總數放回剩餘金額
            trackBar1.Value = 0;//歸零

            if (sum <= 0)//錢用光的時候
            {
                MessageBox.Show("歐不!你破產了! 明天再來吧...");
            }
            
        }
        int a, b, c;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random ran = new Random();//隨機跑
            a = ran.Next(0, 3);
            b = ran.Next(0, 3);
            c = ran.Next(0, 3);
            pictureBox1.Image = imageList1.Images[a];
            pictureBox2.Image = imageList1.Images[b];
            pictureBox3.Image = imageList1.Images[c];
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //判斷賭注是否為空的、是否為0
            if (string.IsNullOrEmpty(textBox2.Text.Trim()) == false && int.Parse(textBox2.Text) > 0)//有東西或大於0時，打開start按鈕
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }
       
    }
}
