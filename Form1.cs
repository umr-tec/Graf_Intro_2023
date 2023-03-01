using System;
using System.Windows.Forms;
//Librearia para grafica en 2D
using System.Drawing.Drawing2D;
using System.Drawing;

namespace GrafU1_Intro_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Color color1, color2;
            color1 = Color.FromArgb(26,184,179);         
            color2 = Color.FromArgb(177, 26, 184);
            //Crear rectangulo
            Rectangle rectangle = new Rectangle(0,0,100,200);
            LinearGradientBrush linear = new LinearGradientBrush(rectangle,color1,color2,10);
            Pen pen = new Pen(linear, 19.0F);
            //Matriz de puntos
            Point[] point = new Point[] { 
                new Point(10,100),
                new Point(100,100),
                new Point(100,200),
               new Point(10,100)
            };

            using (Graphics graphics = CreateGraphics())
            {
                graphics.DrawLine(pen, new Point(10, 10), new Point(40, 40));
                graphics.DrawLines(pen, point);

                //Agregar un arco(rectagulo)
                graphics.DrawArc(pen, ClientSize.Width / 2,
                     ClientSize.Height / 2, 100, 100,20,180);

                graphics.DrawRectangle(Pens.Black, ClientSize.Width / 2,
                     ClientSize.Height / 2, 100, 100);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }
    }
}
