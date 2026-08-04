namespace prySistemaDePrestamosDeLibro.Formularios.Prestamos
{
    partial class FrmHacerprestamo
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
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbLectores = new ComboBox();
            btnAgregarCLector = new Button();
            dtpFechanac = new DateTimePicker();
            txtcp = new TextBox();
            label7 = new Label();
            txtEdad = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtColonia = new TextBox();
            txtMunicipio = new TextBox();
            btnvalidarprestamo = new Button();
            tbcprestamollenado = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            cmbLibros = new ComboBox();
            label1 = new Label();
            txtISBN = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtAutor = new TextBox();
            label13 = new Label();
            txtDisponibles = new TextBox();
            label10 = new Label();
            dtpFechaprestamo = new DateTimePicker();
            label19 = new Label();
            dtpFechadevolucion = new DateTimePicker();
            label5 = new Label();
            lblEjemplar = new Label();
            cmbEjemplar = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tbcprestamollenado.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 223, 204);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.8333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Controls.Add(cmbLectores, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarCLector, 2, 0);
            tableLayoutPanel1.Controls.Add(dtpFechanac, 1, 1);
            tableLayoutPanel1.Controls.Add(txtcp, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(txtEdad, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(txtTelefono, 1, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(txtColonia, 1, 4);
            tableLayoutPanel1.Controls.Add(txtMunicipio, 1, 3);
            tableLayoutPanel1.Location = new Point(5, 4);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7924051F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4882641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9018164F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.00694F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5408249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9543791F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3153706F));
            tableLayoutPanel1.Size = new Size(525, 256);
            tableLayoutPanel1.TabIndex = 45;
            // 
            // cmbLectores
            // 
            cmbLectores.FormattingEnabled = true;
            cmbLectores.Items.AddRange(new object[] { "Vigentes", "Vencidos" });
            cmbLectores.Location = new Point(144, 2);
            cmbLectores.Margin = new Padding(3, 2, 3, 2);
            cmbLectores.Name = "cmbLectores";
            cmbLectores.Size = new Size(188, 23);
            cmbLectores.TabIndex = 22;
            cmbLectores.SelectedIndexChanged += cmbLectores_SelectedIndexChanged;
            // 
            // btnAgregarCLector
            // 
            btnAgregarCLector.AutoSize = true;
            btnAgregarCLector.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarCLector.BackgroundImageLayout = ImageLayout.None;
            btnAgregarCLector.ForeColor = SystemColors.Control;
            btnAgregarCLector.Location = new Point(347, 2);
            btnAgregarCLector.Margin = new Padding(3, 2, 3, 2);
            btnAgregarCLector.Name = "btnAgregarCLector";
            btnAgregarCLector.Size = new Size(101, 25);
            btnAgregarCLector.TabIndex = 49;
            btnAgregarCLector.Text = "Agregar lector";
            btnAgregarCLector.UseVisualStyleBackColor = false;
            btnAgregarCLector.Click += btnAgregarCLector_Click;
            // 
            // dtpFechanac
            // 
            dtpFechanac.Enabled = false;
            dtpFechanac.Format = DateTimePickerFormat.Short;
            dtpFechanac.Location = new Point(144, 37);
            dtpFechanac.Margin = new Padding(3, 2, 3, 2);
            dtpFechanac.Name = "dtpFechanac";
            dtpFechanac.Size = new Size(188, 23);
            dtpFechanac.TabIndex = 31;
            // 
            // txtcp
            // 
            txtcp.AcceptsReturn = true;
            txtcp.Enabled = false;
            txtcp.Location = new Point(144, 186);
            txtcp.Margin = new Padding(3, 2, 3, 2);
            txtcp.Name = "txtcp";
            txtcp.Size = new Size(188, 23);
            txtcp.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 184);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 23;
            label7.Text = "CP:";
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(144, 71);
            txtEdad.Margin = new Padding(3, 2, 3, 2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(188, 23);
            txtEdad.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 10;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 69);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 16;
            label6.Text = "Edad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 5;
            label9.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 222);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 25;
            label8.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(144, 224);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(188, 23);
            txtTelefono.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 102);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 21;
            label4.Text = "Municipio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 145);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 20;
            label3.Text = "Colonia:";
            // 
            // txtColonia
            // 
            txtColonia.Enabled = false;
            txtColonia.Location = new Point(144, 147);
            txtColonia.Margin = new Padding(3, 2, 3, 2);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(188, 23);
            txtColonia.TabIndex = 22;
            // 
            // txtMunicipio
            // 
            txtMunicipio.Enabled = false;
            txtMunicipio.Location = new Point(144, 104);
            txtMunicipio.Margin = new Padding(3, 2, 3, 2);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(188, 23);
            txtMunicipio.TabIndex = 24;
            // 
            // btnvalidarprestamo
            // 
            btnvalidarprestamo.AutoSize = true;
            btnvalidarprestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnvalidarprestamo.BackgroundImageLayout = ImageLayout.None;
            btnvalidarprestamo.ForeColor = SystemColors.Control;
            btnvalidarprestamo.Location = new Point(441, 358);
            btnvalidarprestamo.Margin = new Padding(3, 2, 3, 2);
            btnvalidarprestamo.Name = "btnvalidarprestamo";
            btnvalidarprestamo.Size = new Size(115, 28);
            btnvalidarprestamo.TabIndex = 23;
            btnvalidarprestamo.Text = "validar prestamo";
            btnvalidarprestamo.UseVisualStyleBackColor = false;
            btnvalidarprestamo.Click += btnvalidarprestamo_Click;
            // 
            // tbcprestamollenado
            // 
            tbcprestamollenado.Controls.Add(tabPage1);
            tbcprestamollenado.Controls.Add(tabPage2);
            tbcprestamollenado.HotTrack = true;
            tbcprestamollenado.Location = new Point(13, 43);
            tbcprestamollenado.Margin = new Padding(3, 2, 3, 2);
            tbcprestamollenado.Name = "tbcprestamollenado";
            tbcprestamollenado.SelectedIndex = 0;
            tbcprestamollenado.Size = new Size(542, 292);
            tbcprestamollenado.TabIndex = 48;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(236, 223, 204);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(534, 264);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lector";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(236, 223, 204);
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(534, 264);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Libro";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(236, 223, 204);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.22989F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.7701149F));
            tableLayoutPanel2.Controls.Add(cmbEjemplar, 1, 1);
            tableLayoutPanel2.Controls.Add(cmbLibros, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(dtpFechadevolucion, 1, 6);
            tableLayoutPanel2.Controls.Add(label19, 0, 6);
            tableLayoutPanel2.Controls.Add(dtpFechaprestamo, 1, 5);
            tableLayoutPanel2.Controls.Add(label10, 0, 5);
            tableLayoutPanel2.Controls.Add(label13, 0, 4);
            tableLayoutPanel2.Controls.Add(txtDisponibles, 1, 4);
            tableLayoutPanel2.Controls.Add(txtAutor, 1, 3);
            tableLayoutPanel2.Controls.Add(label12, 0, 3);
            tableLayoutPanel2.Controls.Add(label11, 0, 2);
            tableLayoutPanel2.Controls.Add(txtISBN, 1, 2);
            tableLayoutPanel2.Controls.Add(lblEjemplar, 0, 1);
            tableLayoutPanel2.Location = new Point(5, 4);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8417358F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3093624F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4139051F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8094387F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5072041F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8094387F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3089094F));
            tableLayoutPanel2.Size = new Size(381, 216);
            tableLayoutPanel2.TabIndex = 49;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(156, 2);
            cmbLibros.Margin = new Padding(3, 2, 3, 2);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(188, 23);
            cmbLibros.TabIndex = 51;
            cmbLibros.SelectedIndexChanged += cmbLibros_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Libro:";
            // 
            // txtISBN
            // 
            txtISBN.Enabled = false;
            txtISBN.Location = new Point(156, 59);
            txtISBN.Margin = new Padding(3, 2, 3, 2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(188, 23);
            txtISBN.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 57);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 52;
            label11.Text = "ISBN:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 90);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 16;
            label12.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Enabled = false;
            txtAutor.Location = new Point(156, 92);
            txtAutor.Margin = new Padding(3, 2, 3, 2);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(188, 23);
            txtAutor.TabIndex = 53;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 121);
            label13.Name = "label13";
            label13.Size = new Size(71, 15);
            label13.TabIndex = 10;
            label13.Text = "Disponibles:";
            // 
            // txtDisponibles
            // 
            txtDisponibles.Enabled = false;
            txtDisponibles.Location = new Point(156, 123);
            txtDisponibles.Margin = new Padding(3, 2, 3, 2);
            txtDisponibles.Name = "txtDisponibles";
            txtDisponibles.Size = new Size(188, 23);
            txtDisponibles.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 152);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 50;
            label10.Text = "Fecha de Prestamo:";
            // 
            // dtpFechaprestamo
            // 
            dtpFechaprestamo.Enabled = false;
            dtpFechaprestamo.Format = DateTimePickerFormat.Short;
            dtpFechaprestamo.Location = new Point(156, 154);
            dtpFechaprestamo.Margin = new Padding(3, 2, 3, 2);
            dtpFechaprestamo.Name = "dtpFechaprestamo";
            dtpFechaprestamo.Size = new Size(188, 23);
            dtpFechaprestamo.TabIndex = 45;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 183);
            label19.Name = "label19";
            label19.Size = new Size(119, 15);
            label19.TabIndex = 49;
            label19.Text = "Fecha de devolucion:";
            // 
            // dtpFechadevolucion
            // 
            dtpFechadevolucion.Format = DateTimePickerFormat.Short;
            dtpFechadevolucion.Location = new Point(156, 185);
            dtpFechadevolucion.Margin = new Padding(3, 2, 3, 2);
            dtpFechadevolucion.Name = "dtpFechadevolucion";
            dtpFechadevolucion.Size = new Size(188, 23);
            dtpFechadevolucion.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 6);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(322, 37);
            label5.TabIndex = 3;
            label5.Text = "Informacion del prestamo";
            // 
            // lblEjemplar
            // 
            lblEjemplar.AutoSize = true;
            lblEjemplar.Location = new Point(3, 29);
            lblEjemplar.Name = "lblEjemplar";
            lblEjemplar.Size = new Size(56, 15);
            lblEjemplar.TabIndex = 54;
            lblEjemplar.Text = "Ejemplar:";
            // 
            // cmbEjemplar
            // 
            cmbEjemplar.FormattingEnabled = true;
            cmbEjemplar.Location = new Point(156, 31);
            cmbEjemplar.Margin = new Padding(3, 2, 3, 2);
            cmbEjemplar.Name = "cmbEjemplar";
            cmbEjemplar.Size = new Size(188, 23);
            cmbEjemplar.TabIndex = 55;
            // 
            // FrmHacerprestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(581, 396);
            Controls.Add(btnvalidarprestamo);
            Controls.Add(label5);
            Controls.Add(tbcprestamollenado);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmHacerprestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hacer prestamo";
            Load += load_FrmLector;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tbcprestamollenado.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cmbLectores;
        private Button btnAgregarCLector;
        private DateTimePicker dtpFechanac;
        private TextBox txtcp;
        private Label label7;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtMunicipio;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label9;
        private Label label8;
        private TextBox txtTelefono;
        private TextBox txtColonia;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnvalidarprestamo;
        private TabControl tbcprestamollenado;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker dtpFechadevolucion;
        private DateTimePicker dtpFechaprestamo;
        private ComboBox cmbLibros;
        private Label label1;
        private TextBox txtDisponibles;
        private Label label19;
        private Label label10;
        private TextBox txtISBN;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtAutor;
        private Label lblEjemplar;
        private ComboBox cmbEjemplar;
    }
}