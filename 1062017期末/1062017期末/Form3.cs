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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
           // Form2 inter = new Form2();
             {
                 label1.Text = "你好~" + Form2.name + "玩家\n";
                 label1.Text += "你的電話號碼是:" + Form2.pho+"\n";
                 label1.Text+="如果你得到了大獎，我們將會立即連絡你!\n";
                 if (Form2.old == 1) label1.Text += "歡迎加入拉霸機行列，快用你的新手運大贏一把吧!\n";
                 else if (Form2.old == 2) label1.Text += "歡迎老油條再度光顧，你今天運氣一定會很好!\n";
                 label1.Text += "每日提供你的基底賭注金額為100元" + "祝你玩得愉快!";
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
