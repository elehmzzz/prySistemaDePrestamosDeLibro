namespace prySistemaDePrestamosDeLibro.Clases
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
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox2 = new TextBox();
            cmbLectores = new ComboBox();
            btnAgregarPrestamo = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox12 = new TextBox();
            label7 = new Label();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            label4 = new Label();
            textBox18 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 553);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(button1, 1, 0);
            tableLayoutPanel3.Controls.Add(button2, 0, 0);
            tableLayoutPanel3.Location = new Point(556, 488);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(472, 45);
            tableLayoutPanel3.TabIndex = 44;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(32, 41, 64);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(241, 3);
            button1.Name = "button1";
            button1.Size = new Size(181, 38);
            button1.TabIndex = 23;
            button1.Text = "Agregar prestamo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(32, 41, 64);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(181, 38);
            button2.TabIndex = 24;
            button2.Text = "cancelar prestamo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 223, 204);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9994221F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3651981F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6567659F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.7964773F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5264187F));
            tableLayoutPanel1.Controls.Add(textBox2, 4, 0);
            tableLayoutPanel1.Controls.Add(cmbLectores, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarPrestamo, 2, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox12, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox16, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox17, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox18, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 6);
            tableLayoutPanel1.Controls.Add(label10, 3, 0);
            tableLayoutPanel1.Controls.Add(label11, 3, 1);
            tableLayoutPanel1.Controls.Add(label12, 3, 2);
            tableLayoutPanel1.Controls.Add(label13, 3, 4);
            tableLayoutPanel1.Controls.Add(label1, 3, 3);
            tableLayoutPanel1.Controls.Add(textBox3, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox5, 4, 2);
            tableLayoutPanel1.Controls.Add(textBox6, 4, 3);
            tableLayoutPanel1.Controls.Add(textBox7, 4, 4);
            tableLayoutPanel1.Location = new Point(6, 94);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7535782F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0458469F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9658117F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1054134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9658117F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1022, 375);
            tableLayoutPanel1.TabIndex = 43;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(804, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 34);
            textBox2.TabIndex = 50;
            // 
            // cmbLectores
            // 
            cmbLectores.FormattingEnabled = true;
            cmbLectores.Items.AddRange(new object[] { "Vigentes", "Vencidos" });
            cmbLectores.Location = new Point(237, 3);
            cmbLectores.Name = "cmbLectores";
            cmbLectores.Size = new Size(214, 36);
            cmbLectores.TabIndex = 22;
            cmbLectores.Text = "Organizar";
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.AutoSize = true;
            btnAgregarPrestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarPrestamo.BackgroundImageLayout = ImageLayout.None;
            btnAgregarPrestamo.ForeColor = SystemColors.Control;
            btnAgregarPrestamo.Location = new Point(505, 3);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(148, 38);
            btnAgregarPrestamo.TabIndex = 49;
            btnAgregarPrestamo.Text = "Agregar lector";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(237, 54);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 34);
            dateTimePicker1.TabIndex = 31;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(237, 282);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(214, 34);
            textBox12.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 279);
            label7.Name = "label7";
            label7.Size = new Size(39, 28);
            label7.TabIndex = 23;
            label7.Text = "CP:";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(237, 114);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(214, 34);
            textBox16.TabIndex = 19;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(237, 159);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(214, 34);
            textBox17.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 222);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 21;
            label4.Text = "Municipio:";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(237, 225);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(214, 34);
            textBox18.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 156);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 20;
            label3.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 51);
            label2.Name = "label2";
            label2.Size = new Size(199, 28);
            label2.TabIndex = 10;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 111);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 16;
            label6.Text = "Edad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(89, 28);
            label9.TabIndex = 5;
            label9.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 328);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 25;
            label8.Text = "Telefono:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(237, 331);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 34);
            textBox4.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(664, 0);
            label10.Name = "label10";
            label10.Size = new Size(61, 28);
            label10.TabIndex = 28;
            label10.Text = "Libro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(664, 51);
            label11.Name = "label11";
            label11.Size = new Size(58, 28);
            label11.TabIndex = 43;
            label11.Text = "ISBN:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(664, 111);
            label12.Name = "label12";
            label12.Size = new Size(66, 28);
            label12.TabIndex = 45;
            label12.Text = "Autor:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(664, 222);
            label13.Name = "label13";
            label13.Size = new Size(113, 56);
            label13.TabIndex = 48;
            label13.Text = "Fecha de devolucion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(664, 156);
            label1.Name = "label1";
            label1.Size = new Size(99, 56);
            label1.TabIndex = 47;
            label1.Text = "Fecha de prestamo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(804, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 34);
            textBox3.TabIndex = 51;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(804, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 34);
            textBox5.TabIndex = 52;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(804, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 34);
            textBox6.TabIndex = 53;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(804, 225);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(214, 34);
            textBox7.TabIndex = 54;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(46, 31);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(644, 53);
            tableLayoutPanel2.TabIndex = 42;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 0);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(406, 46);
            label5.TabIndex = 3;
            label5.Text = "Informacion del prestamo";
            // 
            // FrmHacerprestamo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 536);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmHacerprestamo";
            Text = "FrmRPrestamo";
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox12;
        private TextBox textBox4;
        private Label label8;
        private Label label7;
        private TextBox textBox16;
        private TextBox textBox17;
        private Label label4;
        private TextBox textBox18;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox2;
        private Button btnAgregarPrestamo;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private ComboBox cmbLectores;
    }
}