using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snake
{
    class Bola
    {
        private int x;
        public int X { get { return x; } set { x = value; } }
        private int y;
        public int Y { get { return y; } set { y = value; } }

        public Bola()
        {
            x = 0;
            y = 0;
        }
        public Bola(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public void dibujar_Bola_P(Graphics g,int size)
        {
            g.FillEllipse(Brushes.Red, x * size, y * size, size, size);
        }
        public void dibujar_Bola_S(Graphics g, int size)
        {
            g.FillEllipse(Brushes.Red, x * size, y * size, size, size);
        }
    }
}
