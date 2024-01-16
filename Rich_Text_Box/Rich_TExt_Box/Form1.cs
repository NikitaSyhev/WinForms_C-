using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Rich_TExt_Box
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
    }

     

        private void OpenButton_MouseClick(object sender, MouseEventArgs e)
        {
            string result = OpenFile();
            if (result != "none")
            {
                RichTextBox.LoadFile(result);
            }
        }

        private string OpenFile()
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "RTF files (*.rtf)|*.rtf";
                of.InitialDirectory = Environment.CurrentDirectory;

                if (of.ShowDialog() == DialogResult.OK)
                {
                    return of.FileName;
                }
            }
            return "none";
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBox.SaveFile("1.rtf");
        }


        private void typeFont_MouseClick(object sender, MouseEventArgs e)
             
        {
            var defaulFont = RichTextBox.Font;
            if (RichTextBox.SelectedText != null) // работает если мы выделили текст
            {
                if (((Button)sender).Text == "Жирный")
                {
                   
                    RichTextBox.SelectionFont = new Font(defaulFont.FontFamily,
                        defaulFont.Size, FontStyle.Bold);

                }
                else
                {
                    if (((Button)sender).Text == "Курсив")
                    {
                        RichTextBox.SelectionFont = new Font(defaulFont.FontFamily,
                        defaulFont.Size, FontStyle.Italic);
                    }
                    else
                    {
                        RichTextBox.SelectionFont = new Font(defaulFont.FontFamily,
                        defaulFont.Size, FontStyle.Regular);
                    }
                }

            }
        }

        private void textSize_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int SizeText = Convert.ToInt32(textBox.Text);
            var defaulFont = RichTextBox.Size;
            if (RichTextBox.SelectedText != null)
            {
                
                RichTextBox.SelectionFont = new Font(RichTextBox.SelectionFont.FontFamily, SizeText, RichTextBox.SelectionFont.Style);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            RichTextBox.SelectionColor = colorDialog.Color;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
