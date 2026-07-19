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
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelRegistrodePrestamos = new Label();

            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // textBox1
            // 
            textBox1.Location = new Point(380, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 34);
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
            label6.AutoSize = true;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 5;
            label6.Text = "Libro:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 190);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 20;
            label3.Text = "ISBN:";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 285);
            label7.Name = "label7";
            label7.Size = new Size(189, 28);
            label7.TabIndex = 23;
            label7.Text = "Devolucion Maxima:";
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
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(207, 241);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(215, 34);
            dateTimePicker2.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 34);
            textBox1.TabIndex = 39;
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
            tableLayoutPanel2.Size = new Size(644, 110);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(-22, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1267, 717);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3144588F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.45596F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.8134718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4145069F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 302.19F));
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(radioButton3, 4, 0);
            tableLayoutPanel1.Controls.Add(Buscador, 1, 1);
            tableLayoutPanel1.Controls.Add(button1, 3, 7);
            tableLayoutPanel1.Controls.Add(button2, 4, 7);
            tableLayoutPanel1.Controls.Add(radioButton2, 3, 0);
            tableLayoutPanel1.Controls.Add(radioButton1, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 7);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 6);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 1, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox14, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox13, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox10, 1, 2);
            tableLayoutPanel1.Location = new Point(34, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3036652F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3036652F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5492773F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5492773F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5492773F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3521681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3521681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5492773F));
            tableLayoutPanel1.Size = new Size(1179, 382);
            tableLayoutPanel1.TabIndex = 43;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(207, 97);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(208, 34);
            textBox10.TabIndex = 18;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(207, 145);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(208, 34);
            textBox13.TabIndex = 19;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(207, 193);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(208, 34);
            textBox14.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 34);
            textBox3.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(207, 288);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 34);
            dateTimePicker1.TabIndex = 44;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Value = new DateTime(2026, 7, 10, 7, 49, 49, 0);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox10;
        private TextBox textBox13;
        private TextBox textBox14;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private ListBox Buscador;
    }
}