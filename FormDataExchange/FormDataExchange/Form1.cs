﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDataExchange
{
    public partial class Form1 : Form
    {
        Form2 form2;
        TextBox textBox2;
        public Form1()
        {
            InitializeComponent();
            Form2 form = new Form2();
            form2 = form;
            textBox2 = form.GetTextBox();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
