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
            tableLayoutPanel1.Controls.Add(btnLectores, 0, 1);
            tableLayoutPanel1.Controls.Add(btnPrestamos, 0, 2);
            tableLayoutPanel1.Controls.Add(btnLibros, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMultas, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEmpleado, 0, 4);
            tableLayoutPanel1.ForeColor = Color.FromArgb(32, 41, 64);
            tableLayoutPanel1.Location = new Point(27, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(183, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLectores
            // 
            btnLectores.FlatAppearance.BorderSize = 0;
            btnLectores.Font = new Font("Segoe UI", 12F);
            btnLectores.ForeColor = SystemColors.ActiveCaptionText;
            btnLectores.Location = new Point(3, 88);
            btnLectores.Name = "btnLectores";
            btnLectores.Size = new Size(177, 47);
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
            btnPrestamos.Location = new Point(3, 173);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(177, 47);
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
            btnLibros.Location = new Point(3, 3);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(177, 47);
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
            btnMultas.Location = new Point(3, 258);
            btnMultas.Name = "btnMultas";
            btnMultas.Size = new Size(177, 47);
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
            btnEmpleado.Location = new Point(3, 343);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(177, 47);
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
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 145);
            panel5.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F);
            btnCerrarSesion.ForeColor = SystemColors.ActiveCaptionText;
            btnCerrarSesion.Location = new Point(27, 33);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(177, 47);
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
            panel2.Location = new Point(222, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 65);
            panel2.TabIndex = 6;
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.AutoSize = true;
            lblTituloModulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloModulo.ForeColor = Color.White;
            lblTituloModulo.Location = new Point(15, 8);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(125, 54);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Text = "titulo";
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmMenuPrincipal";
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