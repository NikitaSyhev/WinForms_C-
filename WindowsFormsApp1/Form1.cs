using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public double n1;
        public double n2;
        public double result = 0;
        public string mathSign;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathSign = button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathSign = button.Text;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                n2 = Convert.ToDouble(textBox1.Text);
                
            
           
           
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
                n1 = Convert.ToDouble(textBox2.Text);
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathSign = button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathSign = button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mathSign = button.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
                
                if (mathSign == "+")
                {
                    result = n1 + n2;
                }
                else if (mathSign == "-")
                {
                    result = n1 - n2;
                }
                else if (mathSign == "*")
                {
                    result = n1 * n2;
                }
                else if (mathSign == "/")
                {

                
                    if (n2 == 0)
                    {
                        RESULT.Text = MessageBox.Show("На 0 делить нельзя.").ToString();
                    }
                    else
                    {
                        result = n1 / n2;
                    }
                
                }

                RESULT.Text = result.ToString();
            
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Отображает диалоговое окно, позволяющее пользователю
                                                                  // открыть файл. Этот класс не наследуется.

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Текстовые (шаблон*.txt)|*.txt|Исходник (шаблон *.cs)|*.cs|*Все (шаблон*.*|*.*";
            var result = openFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                   Viewer.Text = sr.ReadToEnd();
                }

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string path = "Calculator.txt";
            using (StreamWriter sr = new StreamWriter(path, true))
            {
                sr.WriteLine($"{n1} {mathSign} {n2} = {result}");
            }
        }

        private void Viewer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
