using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RectangleLabs
{
    public partial class Ellipses : Form
    {
        int x, y; 
        bool IsLeftKeyPressed = false;
        bool selected = false;
        List<RectangleF> ellipses_lst;
        RectangleF workPlace;

        public Ellipses()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ellipses_lst = new List<RectangleF>();
            workPlace = new RectangleF(25, 25, this.Width - 75, this.Height - 75);
        }
        private void refreashForm()
        {
            if (ellipses_lst.Count > 0)
            {
                Graphics g = this.CreateGraphics();
                g.Clear(BackColor);
                Brush brush = Brushes.Green;
                foreach (var item in ellipses_lst)
                {
                    g.FillEllipse(brush, item);
                }
            }

        }
        private void Ellipses_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var rectangle = new RectangleF(e.X - 25, e.Y - 25, 50, 50);
                addEllipse(rectangle);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    IsLeftKeyPressed = true;
                    this.x = e.X;
                    this.y = e.Y;
                    foreach (var item in ellipses_lst)
                    {
                        if (item.Contains(new PointF(x, y)))
                        {
                            selected = true;
                        }
                    }
                }
            }

        }
        private void addEllipse(RectangleF ellipse)
        {
            foreach (var item in ellipses_lst)
            {
                if (item.IntersectsWith(ellipse))
                {
                    return;
                }
            }
            if (!workPlace.Contains(new PointF(ellipse.X + 25, ellipse.Y + 25)))
            {
                return;
            }
            ellipses_lst.Add(ellipse);
            Graphics g = this.CreateGraphics();
            g.Clear(BackColor);
            Brush brush = Brushes.Green;
            foreach (var item in ellipses_lst)
            {
                g.FillEllipse(brush, item);
            }

        }

        private void Ellipses_MouseUp(object sender, MouseEventArgs e)
        {
            IsLeftKeyPressed = false;
            selected = false;
        }
        private void addMovingEllips(Pen pen, RectangleF rectangle)
        {
            refreashForm();
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(pen, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            workPlace = rectangle;
        }

        private void Ellipses_Resize(object sender, EventArgs e)
        {
            workPlace = new RectangleF(25, 25, this.Width - 75, this.Height - 75);
            Graphics g = this.CreateGraphics();
            Brush brush = Brushes.DarkOrange;
            g.FillRectangle(brush, workPlace);
        }

        private void Ellipses_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsLeftKeyPressed)
            {
                refreashForm();
                int x1, y1, x2, y2;
                x1 = (x > e.X) ? e.X : x;
                y1 = (y > e.Y) ? e.Y : y;
                x2 = (x <= e.X) ? e.X : x;
                y2 = (y <= e.Y) ? e.Y : y;
                if (!selected)
                {
                    var ellipse = new RectangleF(x1, y1, x2 - x1, y2 - y1);
                    var pen_foreColor = new Pen(Color.DarkRed, 2);
                    addMovingEllips(pen_foreColor, ellipse);
                }
                else
                {
                    var ellipse = new RectangleF(e.X - 25, e.Y - 25, 50, 50);
                    foreach (var item in ellipses_lst)
                    {
                        if (item.IntersectsWith(ellipse))
                        {
                            ellipses_lst.Remove(item);
                            break; 
                        }
                    }
                    addEllipse(ellipse);
                }
            }
        }

       

    }
}
