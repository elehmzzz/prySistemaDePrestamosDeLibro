namespace prySistemaDePrestamosDeLibro.Formularios.Prestamos
{
    partial class FrmHacerprestamoLect
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnseguirprestamo = new Button();
            btnRegresarPre = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 223, 204);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9168034F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2153358F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.8678627F));
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
            tableLayoutPanel1.Location = new Point(38, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7924051F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4882641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9018164F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.00694F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5408249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9543791F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3153706F));
            tableLayoutPanel1.Size = new Size(613, 342);
            tableLayoutPanel1.TabIndex = 45;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cmbLectores
            // 
            cmbLectores.FormattingEnabled = true;
            cmbLectores.Items.AddRange(new object[] { "Vigentes", "Vencidos" });
            cmbLectores.Location = new Point(168, 3);
            cmbLectores.Name = "cmbLectores";
            cmbLectores.Size = new Size(214, 28);
            cmbLectores.TabIndex = 22;
            cmbLectores.Text = "Organizar";
            cmbLectores.SelectedIndexChanged += cmbLectores_SelectedIndexChanged;
            // 
            // btnAgregarCLector
            // 
            btnAgregarCLector.AutoSize = true;
            btnAgregarCLector.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarCLector.BackgroundImageLayout = ImageLayout.None;
            btnAgregarCLector.ForeColor = SystemColors.Control;
            btnAgregarCLector.Location = new Point(390, 3);
            btnAgregarCLector.Name = "btnAgregarCLector";
            btnAgregarCLector.Size = new Size(115, 30);
            btnAgregarCLector.TabIndex = 49;
            btnAgregarCLector.Text = "Agregar lector";
            btnAgregarCLector.UseVisualStyleBackColor = false;
            btnAgregarCLector.Click += btnAgregarCLector_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(168, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(168, 251);
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
            textBox16.Location = new Point(168, 96);
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
            textBox18.Location = new Point(168, 198);
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
            textBox4.Location = new Point(168, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 27);
            textBox4.TabIndex = 32;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(168, 140);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(214, 27);
            textBox17.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(38, 25);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(644, 53);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 0);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(516, 46);
            label5.TabIndex = 3;
            label5.Text = "Informacion del prestamo: Lector";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnseguirprestamo, 1, 0);
            tableLayoutPanel3.Controls.Add(btnRegresarPre, 0, 0);
            tableLayoutPanel3.Location = new Point(532, 432);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(472, 45);
            tableLayoutPanel3.TabIndex = 47;
            // 
            // btnseguirprestamo
            // 
            btnseguirprestamo.AutoSize = true;
            btnseguirprestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnseguirprestamo.BackgroundImageLayout = ImageLayout.None;
            btnseguirprestamo.ForeColor = SystemColors.Control;
            btnseguirprestamo.Location = new Point(241, 3);
            btnseguirprestamo.Name = "btnseguirprestamo";
            btnseguirprestamo.Size = new Size(140, 38);
            btnseguirprestamo.TabIndex = 23;
            btnseguirprestamo.Text = "siguiente";
            btnseguirprestamo.UseVisualStyleBackColor = false;
            btnseguirprestamo.Click += btnseguirprestamo_Click;
            // 
            // btnRegresarPre
            // 
            btnRegresarPre.AutoSize = true;
            btnRegresarPre.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresarPre.BackgroundImageLayout = ImageLayout.None;
            btnRegresarPre.ForeColor = SystemColors.Control;
            btnRegresarPre.Location = new Point(3, 3);
            btnRegresarPre.Name = "btnRegresarPre";
            btnRegresarPre.Size = new Size(141, 38);
            btnRegresarPre.TabIndex = 24;
            btnRegresarPre.Text = "cancelar prestamo";
            btnRegresarPre.UseVisualStyleBackColor = false;
            btnRegresarPre.Click += btnRegresarPre_Click;
            // 
            // FrmHacerprestamoLect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1016, 489);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHacerprestamoLect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHacerprestamop2Libro";
            Load += load_FrmLector;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnseguirprestamo;
        private Button btnRegresarPre;
    }
}