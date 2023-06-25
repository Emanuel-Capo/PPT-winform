namespace PPT_winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btComenzar = new Button();
            btSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.piedra_papel_tijera_1;
            pictureBox1.Location = new Point(183, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(561, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(237, 24);
            label1.Name = "label1";
            label1.Size = new Size(437, 48);
            label1.TabIndex = 1;
            label1.Text = "PIEDRA PAPEL TIJERAS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btComenzar
            // 
            btComenzar.BackColor = Color.FromArgb(128, 255, 255);
            btComenzar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btComenzar.ForeColor = Color.Black;
            btComenzar.Location = new Point(183, 424);
            btComenzar.Margin = new Padding(0);
            btComenzar.Name = "btComenzar";
            btComenzar.Size = new Size(255, 49);
            btComenzar.TabIndex = 2;
            btComenzar.Text = "COMENZAR";
            btComenzar.UseVisualStyleBackColor = false;
            btComenzar.Click += btComenzar_Click;
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.FromArgb(128, 255, 255);
            btSalir.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btSalir.ForeColor = Color.Black;
            btSalir.Location = new Point(489, 424);
            btSalir.Margin = new Padding(0);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(255, 49);
            btSalir.TabIndex = 3;
            btSalir.Text = "SALIR";
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(916, 509);
            Controls.Add(btSalir);
            Controls.Add(btComenzar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(128, 255, 255);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Piedra Papel Tijeras";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btComenzar;
        private Button btSalir;
    }
}