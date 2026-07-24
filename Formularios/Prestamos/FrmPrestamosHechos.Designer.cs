namespace prySistemaDePrestamosDeLibro.Formularios.FRMprestamos
{
    partial class FrmPrestamosHechos
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
            txtBuscador = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregarPrestamo = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            aPaterno = new DataGridViewTextBoxColumn();
            aMaterno = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            dateTimePicker1 = new DateTimePicker();
            textBox12 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox14 = new TextBox();
            label7 = new Label();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            label4 = new Label();
            textBox18 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox10 = new TextBox();
            textBox13 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label16 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(3, 3);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar";
            txtBuscador.Size = new Size(326, 27);
            txtBuscador.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.5014F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5294113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9691868F));
            tableLayoutPanel1.Controls.Add(btnAgregarPrestamo, 2, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(txtBuscador, 0, 0);
            tableLayoutPanel1.Location = new Point(23, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(714, 40);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.AutoSize = true;
            btnAgregarPrestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarPrestamo.BackgroundImageLayout = ImageLayout.None;
            btnAgregarPrestamo.ForeColor = SystemColors.Control;
            btnAgregarPrestamo.Location = new Point(553, 3);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(139, 34);
            btnAgregarPrestamo.TabIndex = 23;
            btnAgregarPrestamo.Text = "Agregar Prestamo";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vigentes", "Vencidos" });
            comboBox1.Location = new Point(385, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(109, 28);
            comboBox1.TabIndex = 22;
            comboBox1.Text = "Organizar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, aPaterno, aMaterno, Column1, Column2 });
            dataGridView1.Location = new Point(23, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(987, 222);
            dataGridView1.TabIndex = 31;
            // 
            // id
            // 
            id.DataPropertyName = "id_autor";
            id.HeaderText = "Id Prestamo";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombres";
            Nombre.HeaderText = "Nombre lector";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // aPaterno
            // 
            aPaterno.DataPropertyName = "apellido_paterno";
            aPaterno.HeaderText = "Apellido paterno";
            aPaterno.MinimumWidth = 6;
            aPaterno.Name = "aPaterno";
            // 
            // aMaterno
            // 
            aMaterno.DataPropertyName = "apellido_materno";
            aMaterno.HeaderText = "Libro prestado";
            aMaterno.MinimumWidth = 6;
            aMaterno.Name = "aMaterno";
            // 
            // Column1
            // 
            Column1.HeaderText = "Fecha de prestamo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha de devolución";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.97564F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.219244F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.7057362F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.0573559F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1346207F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tableLayoutPanel2.Controls.Add(textBox5, 5, 0);
            tableLayoutPanel2.Controls.Add(textBox3, 3, 5);
            tableLayoutPanel2.Controls.Add(textBox2, 3, 4);
            tableLayoutPanel2.Controls.Add(label5, 2, 4);
            tableLayoutPanel2.Controls.Add(dateTimePicker1, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox12, 1, 5);
            tableLayoutPanel2.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel2.Controls.Add(label8, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox14, 1, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 5);
            tableLayoutPanel2.Controls.Add(textBox16, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox17, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(textBox18, 1, 4);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(label10, 2, 1);
            tableLayoutPanel2.Controls.Add(label11, 2, 2);
            tableLayoutPanel2.Controls.Add(label12, 2, 3);
            tableLayoutPanel2.Controls.Add(textBox10, 3, 2);
            tableLayoutPanel2.Controls.Add(textBox13, 3, 3);
            tableLayoutPanel2.Controls.Add(label9, 2, 5);
            tableLayoutPanel2.Controls.Add(textBox1, 3, 1);
            tableLayoutPanel2.Controls.Add(label13, 4, 0);
            tableLayoutPanel2.Controls.Add(button1, 6, 6);
            tableLayoutPanel2.Controls.Add(label14, 4, 1);
            tableLayoutPanel2.Controls.Add(label15, 4, 2);
            tableLayoutPanel2.Controls.Add(textBox6, 5, 1);
            tableLayoutPanel2.Controls.Add(textBox7, 5, 2);
            tableLayoutPanel2.Controls.Add(label16, 6, 2);
            tableLayoutPanel2.Location = new Point(12, 286);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2158594F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6563873F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0969162F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6563873F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8590307F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.12605F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5462189F));
            tableLayoutPanel2.Size = new Size(1010, 238);
            tableLayoutPanel2.TabIndex = 42;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(165, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(165, 168);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(158, 27);
            textBox12.TabIndex = 41;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(472, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 27);
            textBox4.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(329, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 25;
            label8.Text = "Telefono:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(165, 3);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(158, 27);
            textBox14.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 165);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 23;
            label7.Text = "CP:";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(165, 66);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(158, 27);
            textBox16.TabIndex = 19;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(165, 99);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(158, 27);
            textBox17.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 128);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 21;
            label4.Text = "Municipio:";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(165, 131);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(158, 27);
            textBox18.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 20;
            label3.Text = "Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 10;
            label1.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 16;
            label2.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 5;
            label6.Text = "Nombre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(329, 31);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 28;
            label10.Text = "Libro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(329, 63);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 43;
            label11.Text = "ISBN:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(329, 96);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 45;
            label12.Text = "Autor:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(472, 66);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(214, 27);
            textBox10.TabIndex = 35;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(472, 99);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(214, 27);
            textBox13.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(472, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 128);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 47;
            label5.Text = "Fecha prestamo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(329, 165);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 48;
            label9.Text = "Fecha devolucion:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(472, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 49;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(472, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 27);
            textBox3.TabIndex = 50;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(32, 41, 64);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(909, 203);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 43;
            button1.Text = "Editar Plazo";
            button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(692, 0);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 51;
            label13.Text = "Dias restantes:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(692, 31);
            label14.Name = "label14";
            label14.Size = new Size(112, 20);
            label14.TabIndex = 52;
            label14.Text = "Dias de retraso:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(692, 63);
            label15.Name = "label15";
            label15.Size = new Size(117, 20);
            label15.TabIndex = 53;
            label15.Text = "Multa generada:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(815, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(88, 27);
            textBox5.TabIndex = 54;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(815, 34);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(88, 27);
            textBox6.TabIndex = 55;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(815, 66);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(88, 27);
            textBox7.TabIndex = 56;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(909, 63);
            label16.Name = "label16";
            label16.Size = new Size(36, 20);
            label16.TabIndex = 57;
            label16.Text = "dias";
            // 
            // FrmPrestamosHechos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1034, 536);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmPrestamosHechos";
            Text = "FrmPrestamosHechos";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtBuscador;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Estadi;
        private DataGridViewLinkColumn Column5;
        private Button btnAgregarPrestamo;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn aPaterno;
        private DataGridViewTextBoxColumn aMaterno;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox12;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox14;
        private Label label7;
        private TextBox textBox16;
        private TextBox textBox17;
        private Label label4;
        private TextBox textBox18;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox10;
        private TextBox textBox13;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label9;
        private Button button1;
        private Label label13;
        private Label label14;
        private TextBox textBox5;
        private Label label15;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label16;
    }
}