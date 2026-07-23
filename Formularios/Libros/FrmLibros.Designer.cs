namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmLibros
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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnCategorias = new Button();
            btnAutores = new Button();
            Editoriales = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBoxAutor = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscador
            // 
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(3, 4);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar...";
            txtBuscador.Size = new Size(315, 27);
            txtBuscador.TabIndex = 20;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(400, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Organizar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(11, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1025, 215);
            dataGridView1.TabIndex = 22;
            // 
            // Column1
            // 
            Column1.FillWeight = 94.62568F;
            Column1.HeaderText = "ISBN";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 100.0257F;
            Column2.HeaderText = "Título";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 102.275726F;
            Column3.HeaderText = "Autor";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 102.968048F;
            Column4.HeaderText = "Disponibles";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha de registro";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 47);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.AutoSize = true;
            btnCategorias.BackColor = Color.FromArgb(32, 41, 64);
            btnCategorias.ForeColor = SystemColors.Control;
            btnCategorias.Location = new Point(208, 3);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(155, 47);
            btnCategorias.TabIndex = 26;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnAutores
            // 
            btnAutores.AutoSize = true;
            btnAutores.BackColor = Color.FromArgb(32, 41, 64);
            btnAutores.ForeColor = SystemColors.Control;
            btnAutores.Location = new Point(413, 3);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(155, 47);
            btnAutores.TabIndex = 27;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // Editoriales
            // 
            Editoriales.AutoSize = true;
            Editoriales.BackColor = Color.FromArgb(32, 41, 64);
            Editoriales.ForeColor = SystemColors.Control;
            Editoriales.Location = new Point(618, 3);
            Editoriales.Name = "Editoriales";
            Editoriales.Size = new Size(158, 47);
            Editoriales.TabIndex = 28;
            Editoriales.Text = "Editoriales";
            Editoriales.UseVisualStyleBackColor = false;
            Editoriales.Click += Editoriales_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AccessibleRole = AccessibleRole.MenuBar;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(btnAgregar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCategorias, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAutores, 2, 0);
            tableLayoutPanel1.Controls.Add(Editoriales, 3, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(11, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(1029, 53);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txtBuscador);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(15, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 51);
            panel1.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 31;
            label4.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 32;
            label5.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 33;
            label2.Text = "Titulo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 45);
            label6.Name = "label6";
            label6.Size = new Size(175, 28);
            label6.TabIndex = 34;
            label6.Text = "Ejemplares Totales:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 90);
            label7.Name = "label7";
            label7.Size = new Size(116, 47);
            label7.TabIndex = 35;
            label7.Text = " Ejemplares Disponbles:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.45509F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.54491F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 449F));
            tableLayoutPanel2.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel2.Controls.Add(label5, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label7, 2, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxAutor, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox3, 3, 0);
            tableLayoutPanel2.Controls.Add(textBox5, 3, 2);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(9, 411);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Size = new Size(1029, 137);
            tableLayoutPanel2.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(582, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 34);
            textBox4.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(88, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 34);
            textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(88, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 34);
            textBox1.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 40;
            label3.Text = "Autor:";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Enabled = false;
            textBoxAutor.Location = new Point(88, 94);
            textBoxAutor.Margin = new Padding(3, 4, 3, 4);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(204, 34);
            textBoxAutor.TabIndex = 44;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(582, 4);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 34);
            textBox3.TabIndex = 45;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(582, 94);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(138, 34);
            textBox5.TabIndex = 46;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1051, 583);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmLibros";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmEditConsultaLibros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtBuscador;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnCategorias;
        private Button btnAutores;
        private Button Editoriales;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox textBoxAutor;
        private TextBox textBox3;
        private TextBox textBox5;
    }
}