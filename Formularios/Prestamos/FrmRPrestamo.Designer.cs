namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmRPrestamo
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btRegresarPrHechos = new Button();
            btnFinalizarprestamo = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtEjemplar = new TextBox();
            lblEjemplar = new Label();
            txtNombre = new TextBox();
            label15 = new Label();
            label9 = new Label();
            txtTelefono = new TextBox();
            label11 = new Label();
            txtMunicipio = new TextBox();
            label12 = new Label();
            txtColonia = new TextBox();
            label10 = new Label();
            txtCp = new TextBox();
            label16 = new Label();
            txtLibro = new TextBox();
            label17 = new Label();
            txtISBN = new TextBox();
            label22 = new Label();
            label21 = new Label();
            txtMulta = new TextBox();
            txtDiasretraso = new TextBox();
            label19 = new Label();
            label5 = new Label();
            dtpFechprestamo = new DateTimePicker();
            dtpFechdevolucion = new DateTimePicker();
            txtAutor = new TextBox();
            label18 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtprestatario = new TextBox();
            label24 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelRegistrodePrestamos = new Label();
            textBox1 = new TextBox();
            Buscador = new ListBox();
            dateTimePicker2 = new DateTimePicker();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(-19, -4);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 542);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.Controls.Add(btRegresarPrHechos, 1, 1);
            tableLayoutPanel1.Controls.Add(btnFinalizarprestamo, 0, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(578, 364);
            tableLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(307, 32);
            tableLayoutPanel1.TabIndex = 64;
            // 
            // btRegresarPrHechos
            // 
            btRegresarPrHechos.AutoSize = true;
            btRegresarPrHechos.BackColor = Color.FromArgb(32, 41, 64);
            btRegresarPrHechos.BackgroundImageLayout = ImageLayout.None;
            btRegresarPrHechos.ForeColor = SystemColors.Control;
            btRegresarPrHechos.Location = new Point(223, 2);
            btRegresarPrHechos.Margin = new Padding(3, 2, 3, 2);
            btRegresarPrHechos.Name = "btRegresarPrHechos";
            btRegresarPrHechos.Size = new Size(81, 31);
            btRegresarPrHechos.TabIndex = 63;
            btRegresarPrHechos.Text = "regresar";
            btRegresarPrHechos.UseVisualStyleBackColor = false;
            btRegresarPrHechos.Click += btRegresarPrHechos_Click;
            // 
            // btnFinalizarprestamo
            // 
            btnFinalizarprestamo.AutoSize = true;
            btnFinalizarprestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnFinalizarprestamo.BackgroundImageLayout = ImageLayout.None;
            btnFinalizarprestamo.ForeColor = SystemColors.Control;
            btnFinalizarprestamo.Location = new Point(3, 2);
            btnFinalizarprestamo.Margin = new Padding(3, 2, 3, 2);
            btnFinalizarprestamo.Name = "btnFinalizarprestamo";
            btnFinalizarprestamo.Size = new Size(158, 31);
            btnFinalizarprestamo.TabIndex = 65;
            btnFinalizarprestamo.Text = "Finalizar Prestamo";
            btnFinalizarprestamo.UseVisualStyleBackColor = false;
            btnFinalizarprestamo.Click += btn_finalizar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.9064474F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9279385F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.463768F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.347826F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2503166F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel3.Controls.Add(txtEjemplar, 3, 3);
            tableLayoutPanel3.Controls.Add(lblEjemplar, 2, 3);
            tableLayoutPanel3.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanel3.Controls.Add(label15, 0, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 1);
            tableLayoutPanel3.Controls.Add(txtTelefono, 1, 1);
            tableLayoutPanel3.Controls.Add(label11, 0, 2);
            tableLayoutPanel3.Controls.Add(txtMunicipio, 1, 2);
            tableLayoutPanel3.Controls.Add(label12, 0, 3);
            tableLayoutPanel3.Controls.Add(txtColonia, 1, 3);
            tableLayoutPanel3.Controls.Add(label10, 0, 4);
            tableLayoutPanel3.Controls.Add(txtCp, 1, 4);
            tableLayoutPanel3.Controls.Add(label16, 2, 0);
            tableLayoutPanel3.Controls.Add(txtLibro, 3, 0);
            tableLayoutPanel3.Controls.Add(label17, 2, 1);
            tableLayoutPanel3.Controls.Add(txtISBN, 3, 1);
            tableLayoutPanel3.Controls.Add(label22, 4, 3);
            tableLayoutPanel3.Controls.Add(label21, 4, 2);
            tableLayoutPanel3.Controls.Add(txtMulta, 5, 3);
            tableLayoutPanel3.Controls.Add(txtDiasretraso, 5, 2);
            tableLayoutPanel3.Controls.Add(label19, 4, 1);
            tableLayoutPanel3.Controls.Add(label5, 4, 0);
            tableLayoutPanel3.Controls.Add(dtpFechprestamo, 5, 0);
            tableLayoutPanel3.Controls.Add(dtpFechdevolucion, 5, 1);
            tableLayoutPanel3.Controls.Add(txtAutor, 3, 2);
            tableLayoutPanel3.Controls.Add(label18, 2, 2);
            tableLayoutPanel3.Location = new Point(30, 80);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4915237F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.36158F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 17.79661F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5367222F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9717512F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8418074F));
            tableLayoutPanel3.Size = new Size(884, 266);
            tableLayoutPanel3.TabIndex = 43;
            // 
            // txtEjemplar
            // 
            txtEjemplar.Enabled = false;
            txtEjemplar.Location = new Point(371, 148);
            txtEjemplar.Margin = new Padding(3, 2, 3, 2);
            txtEjemplar.Name = "txtEjemplar";
            txtEjemplar.ReadOnly = true;
            txtEjemplar.Size = new Size(162, 29);
            txtEjemplar.TabIndex = 67;
            // 
            // lblEjemplar
            // 
            lblEjemplar.AutoSize = true;
            lblEjemplar.Location = new Point(285, 146);
            lblEjemplar.Name = "lblEjemplar";
            lblEjemplar.Size = new Size(74, 21);
            lblEjemplar.TabIndex = 66;
            lblEjemplar.Text = "Ejemplar:";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(99, 2);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(180, 29);
            txtNombre.TabIndex = 58;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(71, 21);
            label15.TabIndex = 5;
            label15.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 51);
            label9.Name = "label9";
            label9.Size = new Size(71, 21);
            label9.TabIndex = 25;
            label9.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(99, 53);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(180, 29);
            txtTelefono.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 99);
            label11.Name = "label11";
            label11.Size = new Size(82, 21);
            label11.TabIndex = 21;
            label11.Text = "Municipio:";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Enabled = false;
            txtMunicipio.Location = new Point(99, 101);
            txtMunicipio.Margin = new Padding(3, 2, 3, 2);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.ReadOnly = true;
            txtMunicipio.Size = new Size(180, 29);
            txtMunicipio.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 146);
            label12.Name = "label12";
            label12.Size = new Size(63, 21);
            label12.TabIndex = 20;
            label12.Text = "colonia:";
            // 
            // txtColonia
            // 
            txtColonia.Enabled = false;
            txtColonia.Location = new Point(99, 148);
            txtColonia.Margin = new Padding(3, 2, 3, 2);
            txtColonia.Name = "txtColonia";
            txtColonia.ReadOnly = true;
            txtColonia.Size = new Size(180, 29);
            txtColonia.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 187);
            label10.Name = "label10";
            label10.Size = new Size(32, 21);
            label10.TabIndex = 23;
            label10.Text = "CP:";
            // 
            // txtCp
            // 
            txtCp.Enabled = false;
            txtCp.Location = new Point(99, 189);
            txtCp.Margin = new Padding(3, 2, 3, 2);
            txtCp.Name = "txtCp";
            txtCp.ReadOnly = true;
            txtCp.Size = new Size(180, 29);
            txtCp.TabIndex = 41;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(285, 0);
            label16.Name = "label16";
            label16.Size = new Size(49, 21);
            label16.TabIndex = 28;
            label16.Text = "Libro:";
            // 
            // txtLibro
            // 
            txtLibro.Enabled = false;
            txtLibro.Location = new Point(371, 2);
            txtLibro.Margin = new Padding(3, 2, 3, 2);
            txtLibro.Name = "txtLibro";
            txtLibro.ReadOnly = true;
            txtLibro.Size = new Size(162, 29);
            txtLibro.TabIndex = 46;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(285, 51);
            label17.Name = "label17";
            label17.Size = new Size(47, 21);
            label17.TabIndex = 43;
            label17.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Enabled = false;
            txtISBN.Location = new Point(371, 53);
            txtISBN.Margin = new Padding(3, 2, 3, 2);
            txtISBN.Name = "txtISBN";
            txtISBN.ReadOnly = true;
            txtISBN.Size = new Size(162, 29);
            txtISBN.TabIndex = 49;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(539, 146);
            label22.Name = "label22";
            label22.Size = new Size(135, 21);
            label22.TabIndex = 53;
            label22.Text = "Multa generada: $";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(539, 99);
            label21.Name = "label21";
            label21.Size = new Size(117, 21);
            label21.TabIndex = 52;
            label21.Text = "Dias de retraso:";
            // 
            // txtMulta
            // 
            txtMulta.Enabled = false;
            txtMulta.Location = new Point(693, 148);
            txtMulta.Margin = new Padding(3, 2, 3, 2);
            txtMulta.Name = "txtMulta";
            txtMulta.ReadOnly = true;
            txtMulta.Size = new Size(98, 29);
            txtMulta.TabIndex = 56;
            // 
            // txtDiasretraso
            // 
            txtDiasretraso.Enabled = false;
            txtDiasretraso.Location = new Point(693, 101);
            txtDiasretraso.Margin = new Padding(3, 2, 3, 2);
            txtDiasretraso.Name = "txtDiasretraso";
            txtDiasretraso.ReadOnly = true;
            txtDiasretraso.Size = new Size(77, 29);
            txtDiasretraso.TabIndex = 55;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(539, 51);
            label19.Name = "label19";
            label19.Size = new Size(133, 21);
            label19.TabIndex = 48;
            label19.Text = "Fecha devolucion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 47;
            label5.Text = "Fecha prestamo:";
            // 
            // dtpFechprestamo
            // 
            dtpFechprestamo.Enabled = false;
            dtpFechprestamo.Format = DateTimePickerFormat.Short;
            dtpFechprestamo.Location = new Point(693, 2);
            dtpFechprestamo.Margin = new Padding(3, 2, 3, 2);
            dtpFechprestamo.Name = "dtpFechprestamo";
            dtpFechprestamo.Size = new Size(187, 29);
            dtpFechprestamo.TabIndex = 64;
            // 
            // dtpFechdevolucion
            // 
            dtpFechdevolucion.Enabled = false;
            dtpFechdevolucion.Format = DateTimePickerFormat.Short;
            dtpFechdevolucion.Location = new Point(693, 53);
            dtpFechdevolucion.Margin = new Padding(3, 2, 3, 2);
            dtpFechdevolucion.Name = "dtpFechdevolucion";
            dtpFechdevolucion.Size = new Size(187, 29);
            dtpFechdevolucion.TabIndex = 65;
            // 
            // txtAutor
            // 
            txtAutor.Enabled = false;
            txtAutor.Location = new Point(371, 101);
            txtAutor.Margin = new Padding(3, 2, 3, 2);
            txtAutor.Name = "txtAutor";
            txtAutor.ReadOnly = true;
            txtAutor.Size = new Size(162, 29);
            txtAutor.TabIndex = 60;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(285, 99);
            label18.Name = "label18";
            label18.Size = new Size(52, 21);
            label18.TabIndex = 45;
            label18.Text = "Autor:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableLayoutPanel4.Controls.Add(txtprestatario, 1, 1);
            tableLayoutPanel4.Controls.Add(label24, 0, 1);
            tableLayoutPanel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel4.Location = new Point(463, 26);
            tableLayoutPanel4.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(405, 30);
            tableLayoutPanel4.TabIndex = 66;
            // 
            // txtprestatario
            // 
            txtprestatario.Enabled = false;
            txtprestatario.Location = new Point(214, 2);
            txtprestatario.Margin = new Padding(3, 2, 3, 2);
            txtprestatario.Name = "txtprestatario";
            txtprestatario.ReadOnly = true;
            txtprestatario.Size = new Size(188, 29);
            txtprestatario.TabIndex = 67;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(3, 0);
            label24.Name = "label24";
            label24.Size = new Size(182, 21);
            label24.TabIndex = 67;
            label24.Text = "prestamo registrado por:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelRegistrodePrestamos, 0, 1);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(30, 22);
            tableLayoutPanel2.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(251, 36);
            tableLayoutPanel2.TabIndex = 42;
            // 
            // labelRegistrodePrestamos
            // 
            labelRegistrodePrestamos.AutoSize = true;
            labelRegistrodePrestamos.BackColor = Color.FromArgb(236, 223, 204);
            labelRegistrodePrestamos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistrodePrestamos.ForeColor = Color.Black;
            labelRegistrodePrestamos.Location = new Point(3, 0);
            labelRegistrodePrestamos.Name = "labelRegistrodePrestamos";
            labelRegistrodePrestamos.Size = new Size(220, 37);
            labelRegistrodePrestamos.TabIndex = 3;
            labelRegistrodePrestamos.Text = "Detalle prestamo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 39;
            // 
            // Buscador
            // 
            Buscador.FormattingEnabled = true;
            Buscador.ItemHeight = 28;
            Buscador.Location = new Point(380, 186);
            Buscador.Name = "Buscador";
            Buscador.Size = new Size(385, 200);
            Buscador.TabIndex = 38;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(207, 241);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(215, 23);
            dateTimePicker2.TabIndex = 36;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(878, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(75, 32);
            radioButton3.TabIndex = 35;
            radioButton3.TabStop = true;
            radioButton3.Text = "ISBN";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(699, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(83, 32);
            radioButton2.TabIndex = 34;
            radioButton2.TabStop = true;
            radioButton2.Text = "Autor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(596, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 32);
            radioButton1.TabIndex = 33;
            radioButton1.TabStop = true;
            radioButton1.Text = "Titulo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(207, 288);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 23);
            dateTimePicker1.TabIndex = 44;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Value = new DateTime(2026, 7, 10, 7, 49, 49, 0);
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(32, 41, 64);
            button2.ForeColor = Color.White;
            button2.Location = new Point(878, 335);
            button2.Name = "button2";
            button2.Size = new Size(108, 38);
            button2.TabIndex = 30;
            button2.Text = "Finalizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(32, 41, 64);
            button1.ForeColor = Color.White;
            button1.Location = new Point(699, 335);
            button1.Name = "button1";
            button1.Size = new Size(108, 38);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 332);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 25;
            label8.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 285);
            label7.Name = "label7";
            label7.Size = new Size(189, 28);
            label7.TabIndex = 23;
            label7.Text = "Devolucion Maxima:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 238);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 21;
            label4.Text = "Prestamo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 190);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 20;
            label3.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 142);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 16;
            label2.Text = "Autor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 5;
            label6.Text = "Libro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 94);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 10;
            label1.Text = "Nombre del Libro:";
            // 
            // FrmRPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 402);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmRPrestamo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRPrestamo";
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelRegistrodePrestamos;
        private Panel panel2;
        private TextBox textBox14;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAutor;
        private ListBox Buscador;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtNombre;
        private TextBox txtDiasrestantes;
        private TextBox txtISBN;
        private Label label5;
        private TextBox txtCp;
        private TextBox txtTelefono;
        private Label label9;
        private Label label10;
        private TextBox txtMunicipio;
        private Label label11;
        private TextBox txtColonia;
        private Label label12;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtLibro;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox txtDiasretraso;
        private TextBox txtMulta;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btRegresarPrHechos;
        private Button btnFinalizarprestamo;
        private DateTimePicker dtpFechprestamo;
        private DateTimePicker dtpFechdevolucion;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtprestatario;
        private Label label24;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtEjemplar;
        private Label lblEjemplar;
    }
}