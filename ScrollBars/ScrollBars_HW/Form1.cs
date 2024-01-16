using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBars_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox_Horizont.Multiline = true;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

            private void TextBox_Scroll_Scroll(object sender, ScrollEventArgs e)
        {
            textBox_Horizont.Location = new Point(TextBox_Scroll.Value, textBox_Horizont.Location.Y);
            int x_Left_Coordinate = textBox_Horizont.Location.X;
            int y_Left_Coordinate = textBox_Horizont.Location.Y;
            int x_Right_Coordinate = textBox_Horizont.Location.X + textBox_Horizont.Width;
            int y_Right_Coordinate = textBox_Horizont.Location.Y - textBox_Horizont.Height;
            textBox_Horizont.Text = $"LEFT:: ({x_Left_Coordinate}, {y_Left_Coordinate}) and RIGHT: {x_Right_Coordinate}, {y_Right_Coordinate}";
        }

        private void Picture_Scroll(object sender, ScrollEventArgs e)
        {
            float scale = (float)Picture_ScrollBar.Value / 1000;
            pictureBox1.Width = (int)(pictureBox1.Image.Width * scale);
            pictureBox1.Height = (int)(pictureBox1.Image.Height * scale);

        }
    }
}