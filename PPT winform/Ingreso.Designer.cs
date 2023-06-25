namespace PPT_winform
{
    partial class Ingreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso));
            selJugadores = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            selRondas = new NumericUpDown();
            btAceptar = new Button();
            btVolver = new Button();
            lblNombre = new Label();
            tbNombre = new TextBox();
            btAgregar = new Button();
            listJugadores = new ListBox();
            btborrar = new Button();
            btJugar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)selJugadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selRondas).BeginInit();
            SuspendLayout();
            // 
            // selJugadores
            // 
            selJugadores.Location = new Point(393, 46);
            selJugadores.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            selJugadores.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            selJugadores.Name = "selJugadores";
            selJugadores.Size = new Size(76, 31);
            selJugadores.TabIndex = 0;
            selJugadores.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(32, 42);
            label1.Name = "label1";
            label1.Size = new Size(334, 32);
            label1.TabIndex = 1;
            label1.Text = "Elige la cantidad de jugadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(32, 100);
            label2.Name = "label2";
            label2.Size = new Size(301, 32);
            label2.TabIndex = 2;
            label2.Text = "Elige la cantidad de rondas";
            // 
            // selRondas
            // 
            selRondas.Location = new Point(393, 104);
            selRondas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            selRondas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            selRondas.Name = "selRondas";
            selRondas.Size = new Size(76, 31);
            selRondas.TabIndex = 3;
            selRondas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.FromArgb(128, 255, 255);
            btAceptar.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAceptar.ForeColor = Color.Black;
            btAceptar.Location = new Point(331, 156);
            btAceptar.Margin = new Padding(0);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(138, 39);
            btAceptar.TabIndex = 4;
            btAceptar.Text = "ACEPTAR";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btAceptar_Click;
            // 
            // btVolver
            // 
            btVolver.BackColor = Color.FromArgb(128, 255, 255);
            btVolver.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btVolver.ForeColor = Color.Black;
            btVolver.Location = new Point(21, 412);
            btVolver.Margin = new Padding(0);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(225, 49);
            btVolver.TabIndex = 5;
            btVolver.Text = "VOLVER";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Cyan;
            lblNombre.Location = new Point(32, 216);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(231, 32);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre del jugador";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(32, 262);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(364, 31);
            tbNombre.TabIndex = 8;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.FromArgb(128, 255, 255);
            btAgregar.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btAgregar.ForeColor = Color.Black;
            btAgregar.Location = new Point(32, 306);
            btAgregar.Margin = new Padding(0);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(138, 39);
            btAgregar.TabIndex = 9;
            btAgregar.Text = "AGREGAR";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // listJugadores
            // 
            listJugadores.FormattingEnabled = true;
            listJugadores.ItemHeight = 25;
            listJugadores.Location = new Point(650, 76);
            listJugadores.Name = "listJugadores";
            listJugadores.Size = new Size(225, 254);
            listJugadores.TabIndex = 10;
            // 
            // btborrar
            // 
            btborrar.BackColor = Color.FromArgb(128, 255, 255);
            btborrar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btborrar.ForeColor = Color.Black;
            btborrar.Location = new Point(650, 412);
            btborrar.Margin = new Padding(0);
            btborrar.Name = "btborrar";
            btborrar.Size = new Size(225, 49);
            btborrar.TabIndex = 11;
            btborrar.Text = "BORRAR LISTA";
            btborrar.UseVisualStyleBackColor = false;
            btborrar.Click += btborrar_Click;
            // 
            // btJugar
            // 
            btJugar.BackColor = Color.FromArgb(128, 255, 255);
            btJugar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btJugar.ForeColor = Color.Black;
            btJugar.Location = new Point(650, 347);
            btJugar.Margin = new Padding(0);
            btJugar.Name = "btJugar";
            btJugar.Size = new Size(225, 49);
            btJugar.TabIndex = 12;
            btJugar.Text = "¡¡A JUGAR!!";
            btJugar.UseVisualStyleBackColor = false;
            btJugar.Click += btJugar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(650, 28);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 13;
            label3.Text = "JUGADORES";
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(914, 470);
            Controls.Add(label3);
            Controls.Add(btJugar);
            Controls.Add(btborrar);
            Controls.Add(listJugadores);
            Controls.Add(btAgregar);
            Controls.Add(tbNombre);
            Controls.Add(lblNombre);
            Controls.Add(btVolver);
            Controls.Add(btAceptar);
            Controls.Add(selRondas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selJugadores);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ingreso";
            Text = "Ingreso";
            Load += Ingreso_Load;
            ((System.ComponentModel.ISupportInitialize)selJugadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)selRondas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown selJugadores;
        private Label label1;
        private Label label2;
        private NumericUpDown selRondas;
        private Button btAceptar;
        private Button btVolver;
        private Label lblNombre;
        private TextBox tbNombre;
        private Button btAgregar;
        private ListBox listJugadores;
        private Button btborrar;
        private Button btJugar;
        private Label label3;
    }
}