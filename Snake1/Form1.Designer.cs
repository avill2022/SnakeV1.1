namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.Puntos = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Label();
            this.Perdiste = new System.Windows.Forms.Label();
            this.nombreJugador = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 627);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.toolStripSeparator2,
            this.Guardar,
            this.Abrir});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Guardar
            // 
            this.Guardar.Enabled = false;
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(152, 22);
            this.Guardar.Text = "Guardar";
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Abrir
            // 
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(152, 22);
            this.Abrir.Text = "Abrir";
            this.Abrir.Click += new System.EventHandler(this.abrir_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // AcercaDe
            // 
            this.AcercaDe.Name = "AcercaDe";
            this.AcercaDe.Size = new System.Drawing.Size(152, 22);
            this.AcercaDe.Text = "Acerca de...";
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.Location = new System.Drawing.Point(112, 633);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(40, 13);
            this.Puntos.TabIndex = 1;
            this.Puntos.Text = "Puntos";
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.Location = new System.Drawing.Point(587, 633);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(13, 13);
            this.Tiempo.TabIndex = 2;
            this.Tiempo.Text = "5";
            // 
            // Perdiste
            // 
            this.Perdiste.AutoSize = true;
            this.Perdiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perdiste.ForeColor = System.Drawing.Color.Red;
            this.Perdiste.Location = new System.Drawing.Point(180, 201);
            this.Perdiste.Name = "Perdiste";
            this.Perdiste.Size = new System.Drawing.Size(295, 73);
            this.Perdiste.TabIndex = 3;
            this.Perdiste.Text = "Perdiste!";
            this.Perdiste.Visible = false;
            // 
            // nombreJugador
            // 
            this.nombreJugador.AutoSize = true;
            this.nombreJugador.Location = new System.Drawing.Point(190, 633);
            this.nombreJugador.Name = "nombreJugador";
            this.nombreJugador.Size = new System.Drawing.Size(48, 13);
            this.nombreJugador.TabIndex = 4;
            this.nombreJugador.Text = "Jugador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 651);
            this.Controls.Add(this.nombreJugador);
            this.Controls.Add(this.Perdiste);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Guardar;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem Abrir;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Label Perdiste;
        private System.Windows.Forms.Label nombreJugador;
    }
}

