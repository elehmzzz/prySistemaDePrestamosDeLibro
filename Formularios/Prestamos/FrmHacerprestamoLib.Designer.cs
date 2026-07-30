namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmHacerprestamoLib
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAgregar = new Button();
            btnvolverLector = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            cmbLibros = new ComboBox();
            label9 = new Label();
            textBox17 = new TextBox();
            label19 = new Label();
            label1 = new Label();
            txtISBN = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 0);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(498, 46);
            label5.TabIndex = 3;
            label5.Text = "Informacion del prestamo: Libro";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.60241F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.39759F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnAgregar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnvolverLector, 0, 0);
            tableLayoutPanel3.Location = new Point(556, 486);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(472, 47);
            tableLayoutPanel3.TabIndex = 44;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(241, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(181, 38);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar prestamo";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnvolverLector
            // 
            btnvolverLector.AutoSize = true;
            btnvolverLector.BackColor = Color.FromArgb(32, 41, 64);
            btnvolverLector.BackgroundImageLayout = ImageLayout.None;
            btnvolverLector.ForeColor = SystemColors.Control;
            btnvolverLector.Location = new Point(3, 3);
            btnvolverLector.Name = "btnvolverLector";
            btnvolverLector.Size = new Size(181, 38);
            btnvolverLector.TabIndex = 24;
            btnvolverLector.Text = "volver al Lector";
            btnvolverLector.UseVisualStyleBackColor = false;
            btnvolverLector.Click += btnRegresarPre_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(236, 223, 204);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.49206F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.8730164F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.7936516F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dateTimePicker3, 1, 5);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 1, 4);
            tableLayoutPanel1.Controls.Add(cmbLibros, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox17, 1, 3);
            tableLayoutPanel1.Controls.Add(label19, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(txtISBN, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Location = new Point(46, 93);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7924051F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4882641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9018164F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.00694F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5408249F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9543791F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3153706F));
            tableLayoutPanel1.Size = new Size(630, 342);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(213, 251);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(214, 34);
            dateTimePicker3.TabIndex = 45;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(213, 198);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 34);
            dateTimePicker2.TabIndex = 45;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(213, 3);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(214, 36);
            cmbLibros.TabIndex = 51;
            cmbLibros.SelectedIndexChanged += load_FrmLibro;
            cmbLibros.SelectedValueChanged += on_selected;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 28);
            label9.TabIndex = 5;
            label9.Text = "Libro:";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(213, 140);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(214, 34);
            textBox17.TabIndex = 22;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 248);
            label19.Name = "label19";
            label19.Size = new Size(195, 28);
            label19.TabIndex = 49;
            label19.Text = "Fecha de devolucion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 195);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 50;
            label1.Text = "Fecha de Prestamo:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(213, 50);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(214, 34);
            txtISBN.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 52;
            label3.Text = "ISBN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 93);
            label6.Name = "label6";
            label6.Size = new Size(66, 28);
            label6.TabIndex = 16;
            label6.Text = "Autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 137);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 10;
            label2.Text = "Disponibles:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 34);
            textBox1.TabIndex = 53;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 553);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // FrmHacerprestamoLib
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1034, 536);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmHacerprestamoLib";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRPrestamo";
            Load += load_FrmLibro;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnAgregar;
        private Button btnvolverLector;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label6;
        private Label label9;
        private TextBox txtISBN;
        private TextBox textBox17;
        private Panel panel2;
        private Label label19;
        private Label label1;
        private ComboBox cmbLibros;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox1;
    }
}