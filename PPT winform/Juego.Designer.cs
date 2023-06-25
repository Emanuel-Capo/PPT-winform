namespace PPT_winform
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            lblRondas = new Label();
            lblJug = new Label();
            lblJugador = new Label();
            imgPiedra1 = new PictureBox();
            imgPapel1 = new PictureBox();
            imgTijera1 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblMje = new Label();
            label1 = new Label();
            lblRonda = new Label();
            btSiguiente = new Button();
            imgPiedraJug = new PictureBox();
            imgPiedraBot = new PictureBox();
            imgPapelJug = new PictureBox();
            imgPapelBot = new PictureBox();
            imgTijeraJug = new PictureBox();
            imgTijeraBot = new PictureBox();
            lblResultados = new Label();
            btProxJug = new Button();
            btResult = new Button();
            btVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)imgPiedra1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPapel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgTijera1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPiedraJug).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPiedraBot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPapelJug).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPapelBot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgTijeraJug).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgTijeraBot).BeginInit();
            SuspendLayout();
            // 
            // lblRondas
            // 
            lblRondas.AutoSize = true;
            lblRondas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRondas.ForeColor = Color.Cyan;
            lblRondas.Location = new Point(616, 56);
            lblRondas.Name = "lblRondas";
            lblRondas.Size = new Size(80, 25);
            lblRondas.TabIndex = 2;
            lblRondas.Text = "Rondas: ";
            // 
            // lblJug
            // 
            lblJug.AutoSize = true;
            lblJug.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblJug.ForeColor = Color.Cyan;
            lblJug.Location = new Point(616, 21);
            lblJug.Name = "lblJug";
            lblJug.Size = new Size(97, 25);
            lblJug.TabIndex = 3;
            lblJug.Text = "Jugadores:";
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugador.ForeColor = Color.Cyan;
            lblJugador.Location = new Point(51, 21);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(131, 32);
            lblJugador.TabIndex = 14;
            lblJugador.Text = "JUGADOR";
            // 
            // imgPiedra1
            // 
            imgPiedra1.Cursor = Cursors.Hand;
            imgPiedra1.Image = Properties.Resources.piedra;
            imgPiedra1.Location = new Point(46, 92);
            imgPiedra1.Name = "imgPiedra1";
            imgPiedra1.Size = new Size(113, 103);
            imgPiedra1.SizeMode = PictureBoxSizeMode.Zoom;
            imgPiedra1.TabIndex = 15;
            imgPiedra1.TabStop = false;
            imgPiedra1.Click += imgPiedra1_Click;
            // 
            // imgPapel1
            // 
            imgPapel1.Cursor = Cursors.Hand;
            imgPapel1.Image = Properties.Resources.papel;
            imgPapel1.Location = new Point(46, 213);
            imgPapel1.Name = "imgPapel1";
            imgPapel1.Size = new Size(113, 103);
            imgPapel1.SizeMode = PictureBoxSizeMode.Zoom;
            imgPapel1.TabIndex = 16;
            imgPapel1.TabStop = false;
            imgPapel1.Click += imgPapel1_Click;
            // 
            // imgTijera1
            // 
            imgTijera1.Cursor = Cursors.Hand;
            imgTijera1.Image = Properties.Resources.tijera;
            imgTijera1.Location = new Point(46, 339);
            imgTijera1.Name = "imgTijera1";
            imgTijera1.Size = new Size(113, 103);
            imgTijera1.SizeMode = PictureBoxSizeMode.Zoom;
            imgTijera1.TabIndex = 17;
            imgTijera1.TabStop = false;
            imgTijera1.Click += imgTijera1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.robot_face;
            pictureBox4.Location = new Point(616, 185);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(120, 98);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // lblMje
            // 
            lblMje.AutoSize = true;
            lblMje.BackColor = Color.White;
            lblMje.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMje.ForeColor = Color.Black;
            lblMje.Location = new Point(552, 313);
            lblMje.MaximumSize = new Size(250, 0);
            lblMje.Name = "lblMje";
            lblMje.Size = new Size(236, 27);
            lblMje.TabIndex = 19;
            lblMje.Text = "Elije una opción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(311, 213);
            label1.Name = "label1";
            label1.Size = new Size(81, 60);
            label1.TabIndex = 20;
            label1.Text = "VS";
            // 
            // lblRonda
            // 
            lblRonda.AutoSize = true;
            lblRonda.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRonda.ForeColor = Color.Cyan;
            lblRonda.Location = new Point(270, 92);
            lblRonda.Name = "lblRonda";
            lblRonda.Size = new Size(103, 32);
            lblRonda.TabIndex = 21;
            lblRonda.Text = "RONDA";
            // 
            // btSiguiente
            // 
            btSiguiente.BackColor = Color.FromArgb(128, 255, 255);
            btSiguiente.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btSiguiente.ForeColor = Color.Black;
            btSiguiente.Location = new Point(242, 339);
            btSiguiente.Margin = new Padding(0);
            btSiguiente.Name = "btSiguiente";
            btSiguiente.Size = new Size(223, 39);
            btSiguiente.TabIndex = 22;
            btSiguiente.Text = "SIGUIENTE RONDA";
            btSiguiente.UseVisualStyleBackColor = false;
            btSiguiente.Click += btSiguiente_Click;
            // 
            // imgPiedraJug
            // 
            imgPiedraJug.Image = Properties.Resources.piedra;
            imgPiedraJug.Location = new Point(138, 145);
            imgPiedraJug.Name = "imgPiedraJug";
            imgPiedraJug.Size = new Size(151, 150);
            imgPiedraJug.SizeMode = PictureBoxSizeMode.AutoSize;
            imgPiedraJug.TabIndex = 23;
            imgPiedraJug.TabStop = false;
            // 
            // imgPiedraBot
            // 
            imgPiedraBot.Image = Properties.Resources.piedra;
            imgPiedraBot.Location = new Point(418, 145);
            imgPiedraBot.Name = "imgPiedraBot";
            imgPiedraBot.Size = new Size(151, 150);
            imgPiedraBot.SizeMode = PictureBoxSizeMode.AutoSize;
            imgPiedraBot.TabIndex = 24;
            imgPiedraBot.TabStop = false;
            // 
            // imgPapelJug
            // 
            imgPapelJug.Image = Properties.Resources.papel;
            imgPapelJug.Location = new Point(138, 145);
            imgPapelJug.Name = "imgPapelJug";
            imgPapelJug.Size = new Size(151, 150);
            imgPapelJug.SizeMode = PictureBoxSizeMode.AutoSize;
            imgPapelJug.TabIndex = 25;
            imgPapelJug.TabStop = false;
            // 
            // imgPapelBot
            // 
            imgPapelBot.Image = Properties.Resources.papel;
            imgPapelBot.Location = new Point(418, 145);
            imgPapelBot.Name = "imgPapelBot";
            imgPapelBot.Size = new Size(151, 150);
            imgPapelBot.SizeMode = PictureBoxSizeMode.AutoSize;
            imgPapelBot.TabIndex = 26;
            imgPapelBot.TabStop = false;
            // 
            // imgTijeraJug
            // 
            imgTijeraJug.Image = Properties.Resources.tijera;
            imgTijeraJug.Location = new Point(138, 145);
            imgTijeraJug.Name = "imgTijeraJug";
            imgTijeraJug.Size = new Size(153, 150);
            imgTijeraJug.SizeMode = PictureBoxSizeMode.AutoSize;
            imgTijeraJug.TabIndex = 27;
            imgTijeraJug.TabStop = false;
            // 
            // imgTijeraBot
            // 
            imgTijeraBot.Image = Properties.Resources.tijera;
            imgTijeraBot.Location = new Point(418, 145);
            imgTijeraBot.Name = "imgTijeraBot";
            imgTijeraBot.Size = new Size(153, 150);
            imgTijeraBot.SizeMode = PictureBoxSizeMode.AutoSize;
            imgTijeraBot.TabIndex = 28;
            imgTijeraBot.TabStop = false;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultados.ForeColor = Color.Cyan;
            lblResultados.Location = new Point(46, 453);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(382, 25);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Ganados:     Empatados:    Perdidos:     Puntos:";
            // 
            // btProxJug
            // 
            btProxJug.BackColor = Color.FromArgb(128, 255, 255);
            btProxJug.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btProxJug.ForeColor = Color.Black;
            btProxJug.Location = new Point(242, 365);
            btProxJug.Margin = new Padding(0);
            btProxJug.Name = "btProxJug";
            btProxJug.Size = new Size(223, 39);
            btProxJug.TabIndex = 30;
            btProxJug.Text = "PRÓXIMO JUGADOR";
            btProxJug.UseVisualStyleBackColor = false;
            btProxJug.Click += btProxJug_Click;
            // 
            // btResult
            // 
            btResult.BackColor = Color.FromArgb(128, 255, 255);
            btResult.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btResult.ForeColor = Color.Black;
            btResult.Location = new Point(242, 388);
            btResult.Margin = new Padding(0);
            btResult.Name = "btResult";
            btResult.Size = new Size(223, 39);
            btResult.TabIndex = 31;
            btResult.Text = "RESULTADOS FINALES";
            btResult.UseVisualStyleBackColor = false;
            btResult.Click += btResult_Click;
            // 
            // btVolver
            // 
            btVolver.BackColor = Color.FromArgb(128, 255, 255);
            btVolver.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btVolver.ForeColor = Color.Black;
            btVolver.Location = new Point(584, 437);
            btVolver.Margin = new Padding(0);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(204, 41);
            btVolver.TabIndex = 32;
            btVolver.Text = "VOLVER";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 487);
            Controls.Add(btVolver);
            Controls.Add(btResult);
            Controls.Add(btProxJug);
            Controls.Add(lblResultados);
            Controls.Add(imgTijeraBot);
            Controls.Add(imgTijeraJug);
            Controls.Add(imgPapelBot);
            Controls.Add(imgPapelJug);
            Controls.Add(imgPiedraBot);
            Controls.Add(imgPiedraJug);
            Controls.Add(btSiguiente);
            Controls.Add(lblRonda);
            Controls.Add(label1);
            Controls.Add(lblMje);
            Controls.Add(pictureBox4);
            Controls.Add(imgTijera1);
            Controls.Add(imgPapel1);
            Controls.Add(imgPiedra1);
            Controls.Add(lblJugador);
            Controls.Add(lblJug);
            Controls.Add(lblRondas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Juego";
            Text = "Juego";
            Load += Juego_Load;
            ((System.ComponentModel.ISupportInitialize)imgPiedra1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPapel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgTijera1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPiedraJug).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPiedraBot).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPapelJug).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPapelBot).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgTijeraJug).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgTijeraBot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRondas;
        private Label lblJug;
        private Label lblJugador;
        private PictureBox imgPiedra1;
        private PictureBox imgPapel1;
        private PictureBox imgTijera1;
        private PictureBox pictureBox4;
        private Label lblMje;
        private Label label1;
        private Label lblRonda;
        private Button btSiguiente;
        private PictureBox imgPiedraJug;
        private PictureBox imgPiedraBot;
        private PictureBox imgPapelJug;
        private PictureBox imgPapelBot;
        private PictureBox imgTijeraJug;
        private PictureBox imgTijeraBot;
        private Label lblResultados;
        private Button btProxJug;
        private Button btResult;
        private Button btVolver;
    }
}