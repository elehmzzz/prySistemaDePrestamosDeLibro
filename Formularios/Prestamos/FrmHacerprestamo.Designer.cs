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
            dateTimePicker1 = new DateTimePicker();
            textBox12 = new TextBox();
            label7 = new Label();
            textBox16 = new TextBox();
            label4 = new Label();
            textBox18 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox17 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnvalidarprestamo = new Button();
            tbcprestamollenado = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            cmbLibros = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label19 = new Label();
            label10 = new Label();
            txtISBN = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(cmbLectores, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarCLector, 2, 0);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox12, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(textBox16, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox18, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 6);
            tableLayoutPanel1.Controls.Add(textBox17, 1, 3);
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7924051F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4882641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9018164F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.00694F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5408249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9543791F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3153706F));
            tableLayoutPanel1.Size = new Size(600, 342);
            tableLayoutPanel1.TabIndex = 45;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cmbLectores
            // 
            cmbLectores.FormattingEnabled = true;
            cmbLectores.Items.AddRange(new object[] { "Vigentes", "Vencidos" });
            cmbLectores.Location = new Point(164, 3);
            cmbLectores.Name = "cmbLectores";
            cmbLectores.Size = new Size(214, 28);
            cmbLectores.TabIndex = 22;
            cmbLectores.SelectedIndexChanged += cmbLectores_SelectedIndexChanged;
            // 
            // btnAgregarCLector
            // 
            btnAgregarCLector.AutoSize = true;
            btnAgregarCLector.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarCLector.BackgroundImageLayout = ImageLayout.None;
            btnAgregarCLector.ForeColor = SystemColors.Control;
            btnAgregarCLector.Location = new Point(396, 3);
            btnAgregarCLector.Name = "btnAgregarCLector";
            btnAgregarCLector.Size = new Size(115, 30);
            btnAgregarCLector.TabIndex = 49;
            btnAgregarCLector.Text = "Agregar lector";
            btnAgregarCLector.UseVisualStyleBackColor = false;
            btnAgregarCLector.Click += btnAgregarCLector_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(164, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // textBox12
            // 
            textBox12.Enabled = false;
            textBox12.Location = new Point(164, 251);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(214, 27);
            textBox12.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 248);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 23;
            label7.Text = "CP:";
            // 
            // textBox16
            // 
            textBox16.Enabled = false;
            textBox16.Location = new Point(164, 96);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(214, 27);
            textBox16.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 195);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 21;
            label4.Text = "Municipio:";
            // 
            // textBox18
            // 
            textBox18.Enabled = false;
            textBox18.Location = new Point(164, 198);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(214, 27);
            textBox18.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 137);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 20;
            label3.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 10;
            label2.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 93);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 16;
            label6.Text = "Edad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 5;
            label9.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 299);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 25;
            label8.Text = "Telefono:";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(164, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 27);
            textBox4.TabIndex = 32;
            // 
            // textBox17
            // 
            textBox17.Enabled = false;
            textBox17.Location = new Point(164, 140);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(214, 27);
            textBox17.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnvalidarprestamo, 1, 0);
            tableLayoutPanel3.Enabled = false;
            tableLayoutPanel3.Location = new Point(499, 442);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(136, 45);
            tableLayoutPanel3.TabIndex = 47;
            // 
            // btnvalidarprestamo
            // 
            btnvalidarprestamo.AutoSize = true;
            btnvalidarprestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnvalidarprestamo.BackgroundImageLayout = ImageLayout.None;
            btnvalidarprestamo.ForeColor = SystemColors.Control;
            btnvalidarprestamo.Location = new Point(3, 3);
            btnvalidarprestamo.Name = "btnvalidarprestamo";
            btnvalidarprestamo.Size = new Size(130, 38);
            btnvalidarprestamo.TabIndex = 23;
            btnvalidarprestamo.Text = "validar prestamo";
            btnvalidarprestamo.UseVisualStyleBackColor = false;
            // 
            // tbcprestamollenado
            // 
            tbcprestamollenado.Controls.Add(tabPage1);
            tbcprestamollenado.Controls.Add(tabPage2);
            tbcprestamollenado.HotTrack = true;
            tbcprestamollenado.Location = new Point(15, 57);
            tbcprestamollenado.Name = "tbcprestamollenado";
            tbcprestamollenado.SelectedIndex = 0;
            tbcprestamollenado.Size = new Size(620, 383);
            tbcprestamollenado.TabIndex = 48;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(236, 223, 204);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(612, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lector";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(236, 223, 204);
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(612, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Libro";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(236, 223, 204);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.2837448F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.7162552F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(dateTimePicker3, 1, 5);
            tableLayoutPanel2.Controls.Add(dateTimePicker2, 1, 4);
            tableLayoutPanel2.Controls.Add(cmbLibros, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 3);
            tableLayoutPanel2.Controls.Add(label19, 0, 5);
            tableLayoutPanel2.Controls.Add(label10, 0, 4);
            tableLayoutPanel2.Controls.Add(txtISBN, 1, 1);
            tableLayoutPanel2.Controls.Add(label11, 0, 1);
            tableLayoutPanel2.Controls.Add(label12, 0, 2);
            tableLayoutPanel2.Controls.Add(label13, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel2.Location = new Point(6, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7295637F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3827F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7138853F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.3955784F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7235451F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.0547333F));
            tableLayoutPanel2.Size = new Size(435, 342);
            tableLayoutPanel2.TabIndex = 49;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(213, 284);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(214, 27);
            dateTimePicker3.TabIndex = 45;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(213, 224);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 27);
            dateTimePicker2.TabIndex = 45;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(213, 3);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(214, 28);
            cmbLibros.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "Libro:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(213, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 22;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 281);
            label19.Name = "label19";
            label19.Size = new Size(148, 20);
            label19.TabIndex = 49;
            label19.Text = "Fecha de devolucion:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 221);
            label10.Name = "label10";
            label10.Size = new Size(137, 20);
            label10.TabIndex = 50;
            label10.Text = "Fecha de Prestamo:";
            // 
            // txtISBN
            // 
            txtISBN.Enabled = false;
            txtISBN.Location = new Point(213, 56);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(214, 27);
            txtISBN.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 53);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 52;
            label11.Text = "ISBN:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 105);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 16;
            label12.Text = "Autor:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 155);
            label13.Name = "label13";
            label13.Size = new Size(90, 20);
            label13.TabIndex = 10;
            label13.Text = "Disponibles:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(213, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 8);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(406, 46);
            label5.TabIndex = 3;
            label5.Text = "Informacion del prestamo";
            // 
            // FrmHacerprestamoLect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(674, 489);
            Controls.Add(label5);
            Controls.Add(tbcprestamollenado);
            Controls.Add(tableLayoutPanel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmHacerprestamoLect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hacer prestamo";
            Load += load_FrmLector;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private DateTimePicker dateTimePicker1;
        private TextBox textBox12;
        private Label label7;
        private TextBox textBox16;
        private Label label4;
        private TextBox textBox18;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label9;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox17;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnvalidarprestamo;
        private TabControl tbcprestamollenado;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private ComboBox cmbLibros;
        private Label label1;
        private TextBox textBox1;
        private Label label19;
        private Label label10;
        private TextBox txtISBN;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox2;
    }
}