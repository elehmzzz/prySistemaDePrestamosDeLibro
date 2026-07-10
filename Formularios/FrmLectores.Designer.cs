namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmLectores
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
            btnMultas = new Button();
            btnAgregarLectores = new Button();
            btnAgregarLibros = new Button();
            btnHacerPrestamo = new Button();
            btnLectores = new Button();
            btnLibros = new Button();
            btnCerrarSesion = new Button();
            btnEmpleado = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewLinkColumn();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtBuscador = new TextBox();
            rbAlfabetico = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 41, 64);
            panel1.Controls.Add(btnMultas);
            panel1.Controls.Add(btnAgregarLectores);
            panel1.Controls.Add(btnAgregarLibros);
            panel1.Controls.Add(btnHacerPrestamo);
            panel1.Controls.Add(btnLectores);
            panel1.Controls.Add(btnLibros);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnEmpleado);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 493);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnMultas
            // 
            btnMultas.Font = new Font("Segoe UI", 12F);
            btnMultas.Location = new Point(12, 446);
            btnMultas.Name = "btnMultas";
            btnMultas.Size = new Size(189, 35);
            btnMultas.TabIndex = 7;
            btnMultas.Text = "Multas";
            btnMultas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLectores
            // 
            btnAgregarLectores.Font = new Font("Segoe UI", 12F);
            btnAgregarLectores.Location = new Point(12, 394);
            btnAgregarLectores.Name = "btnAgregarLectores";
            btnAgregarLectores.Size = new Size(189, 35);
            btnAgregarLectores.TabIndex = 6;
            btnAgregarLectores.Text = "Agregar Lectores";
            btnAgregarLectores.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLibros
            // 
            btnAgregarLibros.Font = new Font("Segoe UI", 12F);
            btnAgregarLibros.Location = new Point(12, 336);
            btnAgregarLibros.Name = "btnAgregarLibros";
            btnAgregarLibros.Size = new Size(189, 35);
            btnAgregarLibros.TabIndex = 5;
            btnAgregarLibros.Text = "Agregar Libros";
            btnAgregarLibros.UseVisualStyleBackColor = true;
            // 
            // btnHacerPrestamo
            // 
            btnHacerPrestamo.Font = new Font("Segoe UI", 12F);
            btnHacerPrestamo.Location = new Point(12, 277);
            btnHacerPrestamo.Name = "btnHacerPrestamo";
            btnHacerPrestamo.Size = new Size(189, 35);
            btnHacerPrestamo.TabIndex = 4;
            btnHacerPrestamo.Text = "Hacer Prestamo";
            btnHacerPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnLectores
            // 
            btnLectores.Font = new Font("Segoe UI", 12F);
            btnLectores.Location = new Point(12, 217);
            btnLectores.Name = "btnLectores";
            btnLectores.Size = new Size(189, 35);
            btnLectores.TabIndex = 3;
            btnLectores.Text = "Lectores";
            btnLectores.UseVisualStyleBackColor = true;
            // 
            // btnLibros
            // 
            btnLibros.Font = new Font("Segoe UI", 12F);
            btnLibros.Location = new Point(12, 155);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(189, 35);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += button3_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI", 12F);
            btnCerrarSesion.Location = new Point(12, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(189, 35);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += button1_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Font = new Font("Segoe UI", 12F);
            btnEmpleado.Location = new Point(12, 92);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(189, 35);
            btnEmpleado.TabIndex = 1;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(231, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 317);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Lector";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Prestamos Actuales";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Multas";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ver más..";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(670, 89);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 3;
            label1.Text = "Organizado por:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 41, 64);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(222, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 65);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(586, 54);
            label2.TabIndex = 0;
            label2.Text = "Lista de Lectores Rregistrados";
            label2.Click += label2_Click;
            // 
            // txtBuscador
            // 
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(248, 106);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(360, 27);
            txtBuscador.TabIndex = 1;
            txtBuscador.Text = "Busar...";
            // 
            // rbAlfabetico
            // 
            rbAlfabetico.AutoSize = true;
            rbAlfabetico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAlfabetico.Location = new Point(670, 120);
            rbAlfabetico.Name = "rbAlfabetico";
            rbAlfabetico.Size = new Size(149, 32);
            rbAlfabetico.TabIndex = 6;
            rbAlfabetico.TabStop = true;
            rbAlfabetico.Text = "radioButton1";
            rbAlfabetico.UseVisualStyleBackColor = true;
            // 
            // FrmLectores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(942, 493);
            Controls.Add(rbAlfabetico);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtBuscador);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLectores";
            Text = "FrmLectores";
            Load += FrmLectores_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCerrarSesion;
        private Button btnHacerPrestamo;
        private Button btnLectores;
        private Button btnLibros;
        private Button btnEmpleado;
        private Button btnAgregarLibros;
        private Button btnMultas;
        private Button btnAgregarLectores;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewLinkColumn Column5;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txtBuscador;
        private RadioButton rbAlfabetico;
    }
}