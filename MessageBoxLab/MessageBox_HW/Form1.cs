using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_HW
{
    public partial class Form1 : Form
    {
        MessageBoxButtons button;
        MessageBoxIcon buttonIcon;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedButtonsComboBox(comboBox1.SelectedItem.ToString());
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedButtonsListBox(listBox2.SelectedItem.ToString());
        }


        private void SelectedButtonsComboBox(string buttons)
        {
            if (buttons == "OK") { button = MessageBoxButtons.OK; }
            else if (buttons == "YesNo") { button = MessageBoxButtons.YesNo; }
            else if (buttons == "RetryCance") { button = MessageBoxButtons.RetryCancel; }
            else if (buttons == "AbortRetryIgnore") { button = MessageBoxButtons.AbortRetryIgnore; }
            else if (buttons == "OKCancel") { button = MessageBoxButtons.OKCancel; }
            else if (buttons == "YesNoCancel") { button = MessageBoxButtons.YesNoCancel; }
        }
        private void SelectedButtonsListBox(string buttons)
        {
            if (buttons == "Asterisk") { buttonIcon = MessageBoxIcon.Asterisk; }
            else if (buttons == "Error") { buttonIcon = MessageBoxIcon.Error; }
            else if (buttons == "Exclamation") { buttonIcon = MessageBoxIcon.Exclamation; }
            else if (buttons == "Hand") { buttonIcon = MessageBoxIcon.Hand; }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text, "Title", button, buttonIcon);
        }
    }
}
