using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoard
{

    public partial class Form1 : Form
    {
        Graphics graph; // создали переменную для графики - для создания прямоугольника
        Pen myPen; // создали переменную для линий
        SolidBrush black, white; // переменная для заполнения фигуры белым или черными цветами

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            int width = Width / 8, heigth = Height / 8, coordinateX = 0, coordibateY = 0, counter = 1;
            for (int i = 0; i < 9; i++)
            {
                coordinateX = 1;
                for (int j = 0; j < 9; j++)
                {
                    graph.FillRectangle((counter % 2 == 0) ? black : white, coordinateX, coordibateY, width, heigth); 
                    counter++;
                    coordinateX += width;
                }
                coordibateY += width;
            }
        }

        public Form1()
        {
            InitializeComponent();
            graph = CreateGraphics();
            myPen = new Pen(Color.Black); // инициализация переменных
            black = new SolidBrush(Color.Black); // инициализация переменных
            white = new SolidBrush(Color.White);
        }

      
    }
}
