namespace PPT_winform
{
    partial class Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            pictureBox1 = new PictureBox();
            lblFelic = new Label();
            lbNombres = new ListBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            lbPuntos = new ListBox();
            btVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.exito;
            pictureBox1.Location = new Point(150, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblFelic
            // 
            lblFelic.AutoSize = true;
            lblFelic.Font = new Font("Segoe UI Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblFelic.ForeColor = Color.Cyan;
            lblFelic.Location = new Point(32, 173);
            lblFelic.MaximumSize = new Size(400, 0);
            lblFelic.Name = "lblFelic";
            lblFelic.Size = new Size(337, 96);
            lblFelic.TabIndex = 2;
            lblFelic.Text = "¡¡FELICITACIONES CARLOS!!";
            lblFelic.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbNombres
            // 
            lbNombres.BackColor = Color.FromArgb(64, 64, 64);
            lbNombres.BorderStyle = BorderStyle.None;
            lbNombres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombres.ForeColor = Color.Lime;
            lbNombres.FormattingEnabled = true;
            lbNombres.ItemHeight = 32;
            lbNombres.Location = new Point(490, 99);
            lbNombres.Name = "lbNombres";
            lbNombres.Size = new Size(127, 352);
            lbNombres.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.exito;
            pictureBox2.Location = new Point(141, 313);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(490, 9);
            label3.Name = "label3";
            label3.Size = new Size(173, 32);
            label3.TabIndex = 14;
            label3.Text = "TABLA FINAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(490, 64);
            label1.Name = "label1";
            label1.Size = new Size(252, 32);
            label1.TabIndex = 15;
            label1.Text = "Nombre           Puntos";
            // 
            // lbPuntos
            // 
            lbPuntos.BackColor = Color.FromArgb(64, 64, 64);
            lbPuntos.BorderStyle = BorderStyle.None;
            lbPuntos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPuntos.ForeColor = Color.Lime;
            lbPuntos.FormattingEnabled = true;
            lbPuntos.ItemHeight = 32;
            lbPuntos.Location = new Point(661, 99);
            lbPuntos.Name = "lbPuntos";
            lbPuntos.Size = new Size(127, 352);
            lbPuntos.TabIndex = 16;
            // 
            // btVolver
            // 
            btVolver.BackColor = Color.FromArgb(128, 255, 255);
            btVolver.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btVolver.ForeColor = Color.Black;
            btVolver.Location = new Point(584, 462);
            btVolver.Margin = new Padding(0);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(204, 41);
            btVolver.TabIndex = 33;
            btVolver.Text = "SALIR";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // Final
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 512);
            Controls.Add(btVolver);
            Controls.Add(lbPuntos);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(lbNombres);
            Controls.Add(lblFelic);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Final";
            Text = "Final";
            Load += Final_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblFelic;
        private ListBox lbNombres;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private ListBox lbPuntos;
        private Button btVolver;
    }
}