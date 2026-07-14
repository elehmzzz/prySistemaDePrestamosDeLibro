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
            textBox7 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            labelRegistrodePrestamos = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(Buscador);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(-22, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1349, 731);
            panel2.TabIndex = 4;
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
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(380, 402);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(215, 34);
            dateTimePicker2.TabIndex = 36;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(1034, 151);
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
            radioButton2.Location = new Point(926, 149);
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
            radioButton1.Location = new Point(807, 149);
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
            dateTimePicker1.Location = new Point(380, 473);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 34);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Value = new DateTime(2026, 7, 10, 7, 49, 49, 0);
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(32, 41, 64);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1055, 597);
            button2.Name = "button2";
            button2.Size = new Size(184, 38);
            button2.TabIndex = 30;
            button2.Text = "Finalizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(32, 41, 64);
            button1.ForeColor = Color.White;
            button1.Location = new Point(807, 597);
            button1.Name = "button1";
            button1.Size = new Size(184, 38);
            button1.TabIndex = 7;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 554);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 25;
            label8.Text = "Telefono:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(380, 209);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(215, 34);
            textBox7.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 479);
            label7.Name = "label7";
            label7.Size = new Size(189, 28);
            label7.TabIndex = 23;
            label7.Text = "Devolucion Maxima:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(380, 551);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(215, 34);
            textBox6.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 407);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 21;
            label4.Text = "Prestamo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 339);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 20;
            label3.Text = "ISBN:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(380, 336);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 34);
            textBox5.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(380, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 34);
            textBox2.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 274);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 16;
            label2.Text = "Autor:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 41, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 731);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 153);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 4;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 150);
            label6.Name = "label6";
            label6.Size = new Size(61, 28);
            label6.TabIndex = 5;
            label6.Text = "Libro:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 212);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 10;
            label1.Text = "Nombre del Libro:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 41, 64);
            panel3.Controls.Add(labelRegistrodePrestamos);
            panel3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(5, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1344, 87);
            panel3.TabIndex = 15;
            panel3.Paint += panel3_Paint;
            // 
            // labelRegistrodePrestamos
            // 
            labelRegistrodePrestamos.AutoSize = true;
            labelRegistrodePrestamos.BackColor = Color.FromArgb(32, 41, 64);
            labelRegistrodePrestamos.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegistrodePrestamos.ForeColor = Color.White;
            labelRegistrodePrestamos.Location = new Point(143, 23);
            labelRegistrodePrestamos.Name = "labelRegistrodePrestamos";
            labelRegistrodePrestamos.Size = new Size(355, 46);
            labelRegistrodePrestamos.TabIndex = 3;
            labelRegistrodePrestamos.Text = "Registro de préstamos";
            // 
            // FrmRPrestamo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 648);
            Controls.Add(panel2);
            Name = "FrmRPrestamo";
            Text = "FrmRPrestamo";
            Load += FrmRPrestamo_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private Label label8;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox6;
        private Label label4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label label2;
        public Panel panel1;
        private Label label5;
        private Label label6;
        private Label label1;
        public Panel panel3;
        private Label labelRegistrodePrestamos;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker2;
        private ListBox Buscador;
        private TextBox textBox1;
    }
}