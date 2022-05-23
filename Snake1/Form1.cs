using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace Snake
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private char ctecla;
        private Random rdn;
        private List<Bola> comida;
        private Bitmap bmp;
        private Graphics pagina;
        private List<Bola> Snake;
        private int size = 25;
        private Timer timer2;
        private int puntos = 0;
        private SaveFileDialog guardar;
        private OpenFileDialog abrir;
        public String jugador ="Default";


        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            iniciaComponentes();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += Timer2_Tick;
            guardar = new SaveFileDialog();
            abrir = new OpenFileDialog();

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.generaComida();
        }

        public void iniciaComponentes()
        { 
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            pagina = Graphics.FromImage(bmp);
            rdn = new Random();
            ctecla = 'z';
            Snake = new List<Bola>();
            comida = new List<Bola>();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            SnakeCome();
            moverJugador();

            choque();

            limites();

            Form1_Paint(this,null);
        }

        public void generaComida()
        {
            if (comida.Count < 3)
            {
                int Tiemp = int.Parse(Tiempo.Text);
                Tiemp -= 1;
                Tiempo.Text = "" + Tiemp;
                if (comida.Count < 3 && Tiemp == -1)
                {
                    this.Tiempo.Text = "5";
                    comida.Add(new Bola(rdn.Next(25), rdn.Next(25)));
                    fondo(pagina);
                }
            }
        }

        public void fondo(Graphics g)
        { 
            for(int i=0;i<26;i++)
            {
                for(int j=0;j<25;j++)
                {
                    g.DrawEllipse(new Pen(Color.White), i* size, j* size, size, size);
                }
            }
        }
        public void SnakeCome()
        {
            foreach (Bola b in comida)
            {
                if (Snake[0].X == b.X && Snake[0].Y == b.Y)
                {
                    comida.Remove(b);
                    Snake.Add(new Bola());
                    puntos += 10;
                    this.Puntos.Text = "Puntos:"+puntos.ToString();
                    break;
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Snake.Count != 0)
            {
                pagina.SmoothingMode = SmoothingMode.AntiAlias;
                pagina.Clear(Color.Black);

                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                        Snake[i].dibujar_Bola_P(pagina, size);
                    else
                        Snake[i].dibujar_Bola_S(pagina, size);
                }
                foreach(Bola b in comida) 
                pagina.FillEllipse(Brushes.Green, b.X * size, b.Y * size, size, size);


                g.DrawImage(bmp, 0, 0);
            }
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a' && ctecla != 'd')
            { ctecla = e.KeyChar; }
            if (e.KeyChar == 'd' && ctecla != 'a')
            { ctecla = e.KeyChar; }
            if (e.KeyChar == 's' && ctecla != 'w')
            { ctecla = e.KeyChar; }
            if (e.KeyChar == 'w' && ctecla != 's')
            { ctecla = e.KeyChar; }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void moverJugador()
        { 
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch(ctecla)
                    {
                        case 'a':
                            Snake[i].X--;
                            break;
                        case 'd':
                            Snake[i].X++;
                            break;
                        case 'w':
                            Snake[i].Y--;
                            break;
                        case 's':
                            Snake[i].Y++;
                            break;
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;

                }
            }
        
        }
        private void transporta()
        {
            if (Snake[0].X <0)
            {
                Snake[0].X = 25;
            }
            else
            if (Snake[0].X > 25)
            {
                Snake[0].X = 0;
            }

            if (Snake[0].Y < 0)
            {
                Snake[0].Y = 25;
            }
            else
                if (Snake[0].Y > 25)
                {
                    Snake[0].Y = 0;
                }
            
        }
        public void limites()
        {
            if (Snake[0].X < 0)
            {
                reiniciar_juego();
            }
            else
                if (Snake[0].X > 25)
                {
                reiniciar_juego();
            }

            if (Snake[0].Y < 0)
            {
                reiniciar_juego();
            }
            else
                if (Snake[0].Y > 25)
                {
                reiniciar_juego();
            }
        
        
        }
        public void choque()
        {
            for (int i = 4; i < Snake.Count;i++ )
            {
                if (Snake[0].X == Snake[i].X && Snake[0].Y == Snake[i].Y)
                {
                    reiniciar_juego();
                }
            }
        }
        public void reiniciar_juego() {
            timer1.Stop();
            timer2.Stop();
            iniciaComponentes();
            generaComida();
            this.Tiempo.Text = "5";
            Snake.Clear();
            Snake.Add(new Bola());
            Perdiste.Visible = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Guardar.Enabled = true;
            Abrir.Enabled = true;
            Perdiste.Visible = false;
            iniciaComponentes();
            generaComida();
            this.Tiempo.Text = "5";
            Puntos.Text = "Puntos: 0";
            puntos = 0;
            Snake.Clear();
            Snake.Add(new Bola());

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (e.X >= i * size && e.Y >= j * size && e.X <= i * size + size && e.Y <= j * size + size)
                    {
                        Snake[0].X = i;
                        Snake[0].Y = j;
                    }

                }
            }
            timer1.Start();
            timer2.Start();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClickInputBox_Click(object sender, EventArgs e)
        {
            jugador = Microsoft.VisualBasic.Interaction.InputBox(" Introduce el nombre del jugador. ", "Snake. ", "");
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            this.btnClickInputBox_Click(this, null);
            if (jugador != "")
            {
                FileStream stream = new FileStream("jugador" + ".mar", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(stream);

                writer.Write(jugador);
                writer.Write(puntos);

                stream.Close();
                writer.Close();
            }
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                Stream stream = new FileStream(abrir.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryReader reader = new BinaryReader(stream);

                jugador = reader.ReadString();
                puntos = reader.ReadInt32();
                nombreJugador.Text = "Jugador: "+jugador;
                Puntos.Text = "Puntos: "+puntos.ToString();

                timer1.Start();
                timer2.Start();
                iniciaComponentes();
                generaComida();
                this.Tiempo.Text = "5";
                Snake.Clear();
                Snake.Add(new Bola());
                Guardar.Enabled = true;

                stream.Close();
            }
        }
    }
}
