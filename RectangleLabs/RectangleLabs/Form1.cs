using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RectangleLabs
{
    public partial class Form1 : Form
    {
        List<Comment> comments = new List<Comment>();
        int X1, Y1, X2, Y2;
        static string xmlFile = "comments.xml";
        bool IsMouseDown = false;
        Form rectanglesForm = null, ellipsesForm = null;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
               
                Rectangle rectangle = new Rectangle(X1,Y1, X2 - X1, Y2 - Y1);
                
                Comment comment = new Comment(textBox1.Text, rectangle);
                comments.Add(comment);
            }
            Comment.Serealize_it(comments, xmlFile);
        }
        private void fillComments()
        {
            string result = string.Empty, br = "\r\n";
            foreach (Comment comment in comments)
            {
                result += $"{comment.Text} X1:{comment.X1} Y1:{comment.Y1} X2:{comment.X2} Y2:{comment.Y2}{br}";
            }
            labelComments.Text = result;
        }
        private void buttonViewComment_Click(object sender, EventArgs e)
        {
            fillComments();
            this.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
            refreshComments();
        }
        private void refreshComments()
        {
            Comment.Deserealize_it(xmlFile, out comments);
            fillComments();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            X1 = e.Location.X;
            Y1 = e.Location.Y;
            IsMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                this.Refresh();
                Rectangle rectangle = new Rectangle(X1, Y1, e.Location.X - X1, e.Location.Y - Y1);
                Pen pen = new Pen(Color.DarkRed, 4);
                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.DrawRectangle(pen, rectangle);
            }
        }

        private void rectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rectanglesForm == null)
            {
                rectanglesForm = new Rectangles();
                rectanglesForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно Rectangles?", "Окно уже открыто", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    rectanglesForm.Close();
                    rectanglesForm = null;
                }
            }
            
             
        }

        private void ellipsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ellipsesForm
            if (ellipsesForm == null)
            {
                ellipsesForm = new Ellipses();
                ellipsesForm.Show();
            }
            else
            {
                if (MessageBox.Show(
                    "Закрыть окно Ellipses?", "Окно уже открыто",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ellipsesForm.Close();
                    ellipsesForm = null;
                }
            }
        }

        private void buttonEllips_Click(object sender, EventArgs e)
        {
            if (ellipsesForm != null)
            {
                ellipsesForm.BackColor = Color.Pink;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
            X2 = e.Location.X;
            Y2 = e.Location.Y;
            rightOrder();
            Rectangle rectangle = new Rectangle(X1, Y1, e.Location.X - X1, e.Location.Y - Y1);
            Graphics graphics = pictureBox1.CreateGraphics();
            //graphics.FillRectangle(Brushes.Coral, rectangle);
            Pen pen = new Pen(Color.DarkRed, 4);
            graphics.DrawRectangle(pen, rectangle);
        }
        private void swap(ref int first, ref int second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
        private void rightOrder()
        {
            if (X1 > X2)
            {
                swap(ref X1, ref X2);
            }
            if (Y1 > Y2)
            {
                swap(ref Y1, ref Y2);
            }
        }
    }
}
