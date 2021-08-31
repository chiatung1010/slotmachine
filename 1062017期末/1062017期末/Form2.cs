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
    public partial class Form2 : Form
    {

        int count=0;
        static public string name;
        static public string pho;
        static public int old;
        public string Nam
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public string Pho
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }

        public int Oldnew
        {
            set { count= value; }
            get { return count; }
        }

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            pho = textBox2.Text;
            old = count;
            this.DialogResult = DialogResult.OK;
    
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //去掉空白仍然不是空的，就代表裡面有東西
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false && string.IsNullOrEmpty(textBox2.Text.Trim()) == false)
            {
                if (radioButton1.Checked == true|| radioButton2.Checked == true)
                {
                    button1.Enabled = true;

                    if (radioButton1.Checked == true)
                        count = 1;
                    else if (radioButton2.Checked == true)
                        count = 2;
                }
            }
            else
                button1.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

             if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false && string.IsNullOrEmpty(textBox2.Text.Trim()) == false)
             {
                 if (radioButton1.Checked == true || radioButton2.Checked == true)
                 {
                     button1.Enabled = true;

                    if (radioButton1.Checked == true)
                        count = 1;
                    else if (radioButton2.Checked == true)
                        count = 2;
                }
             }
             else
                 button1.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false && string.IsNullOrEmpty(textBox2.Text.Trim()) == false)
            {
                if (radioButton1.Checked == true || radioButton2.Checked == true)
                {
                    button1.Enabled = true;
                }
            }
            else
                button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false && string.IsNullOrEmpty(textBox2.Text.Trim()) == false)
            {
                if (radioButton1.Checked == true || radioButton2.Checked == true)
                {
                    button1.Enabled = true;
                }
            }
            else
                button1.Enabled = false;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
