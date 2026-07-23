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
            panel1 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLectores = new Button();
            btnPrestamos = new Button();
            btnLibros = new Button();
            btnMultas = new Button();
            btnEmpleado = new Button();
            panel5 = new Panel();
            btnCerrarSesion = new Button();
            panel2 = new Panel();
            lblTituloModulo = new Label();
            panel3 = new Panel();
            pnlContenido = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 486);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 437);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 49);
            panel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 109);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(194, 377);
            panel7.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnLectores, 0, 1);
            tableLayoutPanel1.Controls.Add(btnPrestamos, 0, 2);
            tableLayoutPanel1.Controls.Add(btnLibros, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMultas, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEmpleado, 0, 4);
            tableLayoutPanel1.ForeColor = Color.FromArgb(32, 41, 64);
            tableLayoutPanel1.Location = new Point(24, 4);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(160, 320);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLectores
            // 
            btnLectores.FlatAppearance.BorderSize = 0;
            btnLectores.Font = new Font("Segoe UI", 12F);
            btnLectores.ForeColor = SystemColors.ActiveCaptionText;
            btnLectores.Location = new Point(3, 66);
            btnLectores.Margin = new Padding(3, 2, 3, 2);
            btnLectores.Name = "btnLectores";
            btnLectores.Size = new Size(154, 35);
            btnLectores.TabIndex = 3;
            btnLectores.Text = "Lectores";
            btnLectores.UseVisualStyleBackColor = true;
            btnLectores.Click += btnLectores_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.Font = new Font("Segoe UI", 12F);
            btnPrestamos.ForeColor = SystemColors.ActiveCaptionText;
            btnPrestamos.Location = new Point(3, 130);
            btnPrestamos.Margin = new Padding(3, 2, 3, 2);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(154, 35);
            btnPrestamos.TabIndex = 4;
            btnPrestamos.Text = "Préstamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnLibros
            // 
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.Font = new Font("Segoe UI", 12F);
            btnLibros.ForeColor = SystemColors.ActiveCaptionText;
            btnLibros.Location = new Point(3, 2);
            btnLibros.Margin = new Padding(3, 2, 3, 2);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(154, 35);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnMultas
            // 
            btnMultas.FlatAppearance.BorderSize = 0;
            btnMultas.Font = new Font("Segoe UI", 12F);
            btnMultas.ForeColor = SystemColors.ActiveCaptionText;
            btnMultas.Location = new Point(3, 194);
            btnMultas.Margin = new Padding(3, 2, 3, 2);
            btnMultas.Name = "btnMultas";
            btnMultas.Size = new Size(154, 35);
            btnMultas.TabIndex = 7;
            btnMultas.Text = "Multas";
            btnMultas.UseVisualStyleBackColor = true;
            btnMultas.Click += btnMultas_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.Font = new Font("Segoe UI", 12F);
            btnEmpleado.ForeColor = SystemColors.ActiveCaptionText;
            btnEmpleado.Location = new Point(3, 258);
            btnEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(154, 35);
            btnEmpleado.TabIndex = 8;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnCerrarSesion);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(194, 109);
            panel5.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F);
            btnCerrarSesion.ForeColor = SystemColors.ActiveCaptionText;
            btnCerrarSesion.Location = new Point(24, 25);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(155, 35);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 41, 64);
            panel2.Controls.Add(lblTituloModulo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(194, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 49);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.AutoSize = true;
            lblTituloModulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloModulo.ForeColor = Color.White;
            lblTituloModulo.Location = new Point(13, 6);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(101, 45);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Text = "titulo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 223, 204);
            panel3.Controls.Add(pnlContenido);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(194, 49);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(921, 437);
            panel3.TabIndex = 8;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(236, 223, 204);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 0);
            pnlContenido.Margin = new Padding(3, 2, 3, 2);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(921, 437);
            pnlContenido.TabIndex = 9;
            pnlContenido.Paint += pnlContenido_Paint;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1115, 486);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Préstamos de Libros";
            Load += FrmMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMultas;
        private Button btnPrestamos;
        private Button btnLectores;
        private Button btnLibros;
        private Panel panel2;
        private Label lblTituloModulo;
        private Panel panel3;
        private Panel panel7;
        private Panel panel5;
        private Panel pnlContenido;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEmpleado;
        private Panel panel4;
        private Button btnCerrarSesion;
    }
}