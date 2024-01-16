using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RectangleLabs
{
    public partial class Rectangles : Form
    {
        int x, y;
        bool IsLeftKeyPressed = false;
        List<RectangleF> rectangles;
        RectangleF selection;
        bool selected = false;
        
        public Rectangles()
        {
            InitializeComponent();
            rectangles = new List<RectangleF>();
            this.DoubleBuffered = true;
        }
        private void refreashForm()
        {
            //this.Refresh();

            if (rectangles.Count > 0)
            {
                Graphics g = this.CreateGraphics();
                g.Clear(BackColor);
                Brush brush = Brushes.DarkBlue;
                g.FillRectangles(brush, rectangles.ToArray());
            }
            
        }
        private void addNewRectangle(RectangleF rectangle)
        {
            bool IsIntersect = false;
            foreach (var item in rectangles)
            {
                if (item.IntersectsWith(rectangle))
                {
                    IsIntersect = true;
                }
            }
            if (!IsIntersect)
            {
                rectangles.Add(rectangle);
                addRectangle(rectangle);
            }
        }
        private void Rectangles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var rectangle = new RectangleF(e.X-25, e.Y-25, 50, 50);
                addNewRectangle(rectangle);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    IsLeftKeyPressed = true;
                    this.x = e.X;
                    this.y = e.Y;
                    foreach (var item in rectangles)
                    {
                        if (item.Contains(new PointF(x, y)))
                        {
                            selected = true;
                        }
                    }
                }
            }
        }

        private void Rectangles_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsLeftKeyPressed)
            {
                refreashForm();
                int x1,y1,x2,y2;
                x1 = (x > e.X) ? e.X : x;
                y1 = (y > e.Y) ? e.Y : y;
                x2 = (x <= e.X) ? e.X : x;
                y2 = (y <= e.Y) ? e.Y : y;
                if (!selected)
                {
                    var rectangle = new RectangleF(x1,y1, x2-x1, y2-y1);
                    var pen_foreColor = new Pen(Color.DarkRed, 2);
                    addMovingRectangle(pen_foreColor, rectangle);
                }
                else
                {
                    var rectangle = new RectangleF(e.X - 25, e.Y - 25, 50, 50);
                    foreach (var item in rectangles)
                    {
                        if (item.IntersectsWith(rectangle))
                     
                        {
                            rectangles.Remove(item);
                            break; 
                        }
                    }
                    addNewRectangle(rectangle);
                }
            }
            
        }
        
        private void Rectangles_MouseUp(object sender, MouseEventArgs e)
        {
            IsLeftKeyPressed=false;
            selected = false;

            for (int i = 0; i < rectangles.Count; i++)
            {
                if (selection.IntersectsWith(rectangles[i]))
                {
                    rectangles.Remove(rectangles[i]);
                    i--;
                }
            }
            selection = RectangleF.Empty; 
            refreashForm();
        }
        private void addRectangle(RectangleF rectangle)
        {
            Brush brush = Brushes.DarkBlue;
            refreashForm();
        
        }

        

        private void addMovingRectangle(Pen pen, RectangleF rectangle)
        {
            refreashForm();
            Graphics g = this.CreateGraphics();
            g.DrawRectangle(pen, 
                rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
            selection = rectangle;
        }
    }
}
