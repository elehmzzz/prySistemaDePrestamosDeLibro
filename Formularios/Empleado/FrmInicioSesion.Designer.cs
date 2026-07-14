namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioSesion));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            llbRegistrar = new LinkLabel();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnIniciarSesion = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 41, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 648);
            panel1.TabIndex = 0;
            panel1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 273);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F);
            label3.Location = new Point(18, 148);
            label3.Name = "label3";
            label3.Size = new Size(247, 62);
            label3.TabIndex = 2;
            label3.Text = "DE LIBROS";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F);
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(551, 62);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA DE PRÉSTAMOS";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F);
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(360, 62);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO AL";
            label1.UseWaitCursor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(llbRegistrar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnIniciarSesion);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Right;
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(714, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 648);
            panel2.TabIndex = 1;
            panel2.UseWaitCursor = true;
            // 
            // llbRegistrar
            // 
            llbRegistrar.AutoSize = true;
            llbRegistrar.LinkColor = Color.FromArgb(32, 41, 64);
            llbRegistrar.Location = new Point(53, 564);
            llbRegistrar.Name = "llbRegistrar";
            llbRegistrar.Size = new Size(105, 28);
            llbRegistrar.TabIndex = 10;
            llbRegistrar.TabStop = true;
            llbRegistrar.Text = "Registrate!";
            llbRegistrar.UseWaitCursor = true;
            llbRegistrar.LinkClicked += llbRegistrar_LinkClicked;
            // 
            // label7
            // 
            label7.Location = new Point(53, 109);
            label7.Name = "label7";
            label7.Size = new Size(410, 65);
            label7.TabIndex = 9;
            label7.Text = "Bienvenido al Sistema de Préstamo de Libros. Inicia sesión con tu usuario y contraseña.";
            label7.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(53, 350);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(289, 34);
            textBox2.TabIndex = 8;
            textBox2.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 34);
            textBox1.TabIndex = 7;
            textBox1.UseWaitCursor = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.AutoSize = true;
            btnIniciarSesion.BackColor = Color.FromArgb(32, 41, 64);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(53, 404);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(184, 38);
            btnIniciarSesion.TabIndex = 6;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.UseWaitCursor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 319);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 5;
            label6.Text = "Contraseña:";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 230);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 4;
            label5.Text = "Usuario:";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 33);
            label4.Name = "label4";
            label4.Size = new Size(249, 46);
            label4.TabIndex = 3;
            label4.Text = "Inicio de sesión";
            label4.UseWaitCursor = true;
            // 
            // FrmInicioSesion
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1274, 648);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            UseWaitCursor = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button btnIniciarSesion;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private PictureBox pictureBox1;
        private LinkLabel llbRegistrar;
    }
}