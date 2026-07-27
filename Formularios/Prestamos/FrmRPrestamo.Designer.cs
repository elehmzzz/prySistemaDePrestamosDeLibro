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
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker3 = new DateTimePicker();
            textBox12 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox17 = new TextBox();
            label11 = new Label();
            textBox18 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBox6 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label23 = new Label();
            textBox9 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            textBox13 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker5 = new DateTimePicker();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(-22, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1267, 717);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(labelRegistrodePrestamos, 0, 1);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(157, 27);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(644, 50);
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
            labelRegistrodePrestamos.Size = new Size(355, 46);
            labelRegistrodePrestamos.TabIndex = 3;
            labelRegistrodePrestamos.Text = "Registro de préstamos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 27);
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
            Buscador.SelectedIndexChanged += Buscador_SelectedIndexChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(207, 241);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(215, 27);
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
            dateTimePicker1.Size = new Size(215, 27);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9805336F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.87007F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.8932714F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4327488F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8128653F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel3.Controls.Add(textBox9, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox5, 5, 0);
            tableLayoutPanel3.Controls.Add(label5, 2, 4);
            tableLayoutPanel3.Controls.Add(label11, 0, 3);
            tableLayoutPanel3.Controls.Add(dateTimePicker3, 1, 1);
            tableLayoutPanel3.Controls.Add(textBox12, 1, 5);
            tableLayoutPanel3.Controls.Add(textBox4, 3, 0);
            tableLayoutPanel3.Controls.Add(label9, 2, 0);
            tableLayoutPanel3.Controls.Add(label10, 0, 5);
            tableLayoutPanel3.Controls.Add(textBox17, 1, 3);
            tableLayoutPanel3.Controls.Add(textBox18, 1, 4);
            tableLayoutPanel3.Controls.Add(label13, 0, 1);
            tableLayoutPanel3.Controls.Add(label14, 0, 2);
            tableLayoutPanel3.Controls.Add(label15, 0, 0);
            tableLayoutPanel3.Controls.Add(label16, 2, 1);
            tableLayoutPanel3.Controls.Add(label17, 2, 2);
            tableLayoutPanel3.Controls.Add(label18, 2, 3);
            tableLayoutPanel3.Controls.Add(label19, 2, 5);
            tableLayoutPanel3.Controls.Add(textBox6, 3, 1);
            tableLayoutPanel3.Controls.Add(label20, 4, 0);
            tableLayoutPanel3.Controls.Add(label21, 4, 1);
            tableLayoutPanel3.Controls.Add(label22, 4, 2);
            tableLayoutPanel3.Controls.Add(textBox7, 5, 1);
            tableLayoutPanel3.Controls.Add(textBox8, 5, 2);
            tableLayoutPanel3.Controls.Add(label23, 6, 2);
            tableLayoutPanel3.Controls.Add(textBox2, 3, 2);
            tableLayoutPanel3.Controls.Add(textBox3, 3, 3);
            tableLayoutPanel3.Controls.Add(textBox13, 1, 2);
            tableLayoutPanel3.Controls.Add(label12, 0, 4);
            tableLayoutPanel3.Controls.Add(dateTimePicker4, 3, 4);
            tableLayoutPanel3.Controls.Add(dateTimePicker5, 3, 5);
            tableLayoutPanel3.Location = new Point(34, 98);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8975067F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6204987F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6204987F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 13.01939F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.5246029F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6684246F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1010, 361);
            tableLayoutPanel3.TabIndex = 43;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(858, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(88, 34);
            textBox5.TabIndex = 54;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(531, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 34);
            textBox2.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 228);
            label5.Name = "label5";
            label5.Size = new Size(99, 56);
            label5.TabIndex = 47;
            label5.Text = "Fecha prestamo:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(174, 64);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(214, 34);
            dateTimePicker3.TabIndex = 31;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(174, 298);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(214, 34);
            textBox12.TabIndex = 41;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(531, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 34);
            textBox4.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(395, 0);
            label9.Name = "label9";
            label9.Size = new Size(90, 28);
            label9.TabIndex = 25;
            label9.Text = "Telefono:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 295);
            label10.Name = "label10";
            label10.Size = new Size(39, 28);
            label10.TabIndex = 23;
            label10.Text = "CP:";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(174, 184);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(214, 34);
            textBox17.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 181);
            label11.Name = "label11";
            label11.Size = new Size(104, 28);
            label11.TabIndex = 21;
            label11.Text = "Municipio:";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(174, 231);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(214, 34);
            textBox18.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 228);
            label12.Name = "label12";
            label12.Size = new Size(96, 28);
            label12.TabIndex = 20;
            label12.Text = "localidad:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 61);
            label13.Name = "label13";
            label13.Size = new Size(117, 56);
            label13.TabIndex = 10;
            label13.Text = "Fecha de Nacimiento:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 121);
            label14.Name = "label14";
            label14.Size = new Size(60, 28);
            label14.TabIndex = 16;
            label14.Text = "Edad:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(89, 28);
            label15.TabIndex = 5;
            label15.Text = "Nombre:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(395, 61);
            label16.Name = "label16";
            label16.Size = new Size(61, 28);
            label16.TabIndex = 28;
            label16.Text = "Libro:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(395, 121);
            label17.Name = "label17";
            label17.Size = new Size(58, 28);
            label17.TabIndex = 43;
            label17.Text = "ISBN:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(395, 181);
            label18.Name = "label18";
            label18.Size = new Size(66, 28);
            label18.TabIndex = 45;
            label18.Text = "Autor:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(395, 295);
            label19.Name = "label19";
            label19.Size = new Size(113, 56);
            label19.TabIndex = 48;
            label19.Text = "Fecha devolucion:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(531, 64);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 34);
            textBox6.TabIndex = 46;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(757, 0);
            label20.Name = "label20";
            label20.Size = new Size(94, 56);
            label20.TabIndex = 51;
            label20.Text = "Dias restantes:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(757, 61);
            label21.Name = "label21";
            label21.Size = new Size(81, 56);
            label21.TabIndex = 52;
            label21.Text = "Dias de retraso:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(757, 121);
            label22.Name = "label22";
            label22.Size = new Size(94, 60);
            label22.TabIndex = 53;
            label22.Text = "Multa generada:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(858, 64);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(88, 34);
            textBox7.TabIndex = 55;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(858, 124);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(88, 34);
            textBox8.TabIndex = 56;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(959, 121);
            label23.Name = "label23";
            label23.Size = new Size(47, 28);
            label23.TabIndex = 57;
            label23.Text = "dias";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(174, 3);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(214, 34);
            textBox9.TabIndex = 58;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(531, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 34);
            textBox3.TabIndex = 60;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(32, 41, 64);
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(221, 3);
            button4.Name = "button4";
            button4.Size = new Size(93, 38);
            button4.TabIndex = 63;
            button4.Text = "regresar";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(174, 124);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(87, 34);
            textBox13.TabIndex = 63;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(636, 485);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(408, 48);
            tableLayoutPanel1.TabIndex = 64;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(32, 41, 64);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(126, 38);
            button3.TabIndex = 65;
            button3.Text = "Editar plazo";
            button3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(531, 231);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(214, 34);
            dateTimePicker4.TabIndex = 64;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Format = DateTimePickerFormat.Short;
            dateTimePicker5.Location = new Point(531, 298);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(214, 34);
            dateTimePicker5.TabIndex = 65;
            // 
            // FrmRPrestamo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 536);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmRPrestamo";
            Text = "FrmRPrestamo";
            Load += FrmRPrestamo_Load;
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TextBox textBox13;
        private TextBox textBox14;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private ListBox Buscador;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox9;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox12;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private TextBox textBox17;
        private Label label11;
        private TextBox textBox18;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox textBox6;
        private Label label20;
        private Label label21;
        private Label label22;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label23;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Button button3;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker5;
    }
}