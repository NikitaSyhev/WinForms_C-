using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF_redactor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        public string TextBoxText
        {
            get { return richTextBox1.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox1.Text).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox2.Text).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox3.Text).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox4.Text).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox5.Text).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox6.Text).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox7.Text).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox8.Text).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox9.Text).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox10.Text).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox11.Text).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (textBox12.Text).ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void addToText_MouseClick(object sender, MouseEventArgs e)
        {
            
          
        }
    }
}
