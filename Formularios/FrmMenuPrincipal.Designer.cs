namespace prySistemaDePrestamosDeLibro.Formularios
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            panel1 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            btnMultas = new Button();
            btnLibros = new Button();
            btnAgregarLectores = new Button();
            btnLectores = new Button();
            btnAgregarLibros = new Button();
            btnHacerPrestamo = new Button();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            pnlContenido = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 41, 64);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 648);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 583);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 65);
            panel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 145);
            panel7.Name = "panel7";
            panel7.Size = new Size(222, 503);
            panel7.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button2, 0, 7);
            tableLayoutPanel1.Controls.Add(button1, 0, 6);
            tableLayoutPanel1.Controls.Add(btnMultas, 0, 5);
            tableLayoutPanel1.Controls.Add(btnLibros, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarLectores, 0, 4);
            tableLayoutPanel1.Controls.Add(btnLectores, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAgregarLibros, 0, 3);
            tableLayoutPanel1.Controls.Add(btnHacerPrestamo, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(222, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(3, 374);
            button2.Name = "button2";
            button2.Size = new Size(216, 47);
            button2.TabIndex = 9;
            button2.Text = "Cerrar sesión";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(3, 321);
            button1.Name = "button1";
            button1.Size = new Size(216, 47);
            button1.TabIndex = 8;
            button1.Text = "Empleado";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnMultas
            // 
            btnMultas.FlatAppearance.BorderSize = 0;
            btnMultas.FlatStyle = FlatStyle.Flat;
            btnMultas.Font = new Font("Segoe UI", 12F);
            btnMultas.ForeColor = SystemColors.Control;
            btnMultas.Location = new Point(3, 268);
            btnMultas.Name = "btnMultas";
            btnMultas.Size = new Size(216, 47);
            btnMultas.TabIndex = 7;
            btnMultas.Text = "Multas";
            btnMultas.UseVisualStyleBackColor = true;
            // 
            // btnLibros
            // 
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 12F);
            btnLibros.ForeColor = SystemColors.Control;
            btnLibros.Location = new Point(3, 3);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(216, 47);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLectores
            // 
            btnAgregarLectores.FlatAppearance.BorderSize = 0;
            btnAgregarLectores.FlatStyle = FlatStyle.Flat;
            btnAgregarLectores.Font = new Font("Segoe UI", 12F);
            btnAgregarLectores.ForeColor = SystemColors.Control;
            btnAgregarLectores.Location = new Point(3, 215);
            btnAgregarLectores.Name = "btnAgregarLectores";
            btnAgregarLectores.Size = new Size(216, 47);
            btnAgregarLectores.TabIndex = 6;
            btnAgregarLectores.Text = "Agregar Lectores";
            btnAgregarLectores.UseVisualStyleBackColor = true;
            // 
            // btnLectores
            // 
            btnLectores.FlatAppearance.BorderSize = 0;
            btnLectores.FlatStyle = FlatStyle.Flat;
            btnLectores.Font = new Font("Segoe UI", 12F);
            btnLectores.ForeColor = SystemColors.Control;
            btnLectores.Location = new Point(3, 56);
            btnLectores.Name = "btnLectores";
            btnLectores.Size = new Size(216, 47);
            btnLectores.TabIndex = 3;
            btnLectores.Text = "Lectores";
            btnLectores.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLibros
            // 
            btnAgregarLibros.FlatAppearance.BorderSize = 0;
            btnAgregarLibros.FlatStyle = FlatStyle.Flat;
            btnAgregarLibros.Font = new Font("Segoe UI", 12F);
            btnAgregarLibros.ForeColor = SystemColors.Control;
            btnAgregarLibros.Location = new Point(3, 162);
            btnAgregarLibros.Name = "btnAgregarLibros";
            btnAgregarLibros.Size = new Size(216, 47);
            btnAgregarLibros.TabIndex = 5;
            btnAgregarLibros.Text = "Agregar Libros";
            btnAgregarLibros.UseVisualStyleBackColor = true;
            // 
            // btnHacerPrestamo
            // 
            btnHacerPrestamo.FlatAppearance.BorderSize = 0;
            btnHacerPrestamo.FlatStyle = FlatStyle.Flat;
            btnHacerPrestamo.Font = new Font("Segoe UI", 12F);
            btnHacerPrestamo.ForeColor = SystemColors.Control;
            btnHacerPrestamo.Location = new Point(3, 109);
            btnHacerPrestamo.Name = "btnHacerPrestamo";
            btnHacerPrestamo.Size = new Size(216, 47);
            btnHacerPrestamo.TabIndex = 4;
            btnHacerPrestamo.Text = "Hacer Prestamo";
            btnHacerPrestamo.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 145);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 114);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 1;
            label1.Text = "_________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 41, 64);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(222, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 65);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(125, 54);
            label2.TabIndex = 0;
            label2.Text = "titulo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 223, 204);
            panel3.Controls.Add(pnlContenido);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(222, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(1052, 583);
            panel3.TabIndex = 8;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(236, 223, 204);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1052, 583);
            pnlContenido.TabIndex = 9;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 648);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMultas;
        private Button btnAgregarLectores;
        private Button btnAgregarLibros;
        private Button btnHacerPrestamo;
        private Button btnLectores;
        private Button btnLibros;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel7;
        private Panel panel5;
        private Panel pnlContenido;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel4;
        private Button button2;
    }
}