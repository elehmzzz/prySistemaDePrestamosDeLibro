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
            comboBoxCategoria = new ComboBox();
            comboBoxAutor = new ComboBox();
            comboBoxEjemplares = new ComboBox();
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
            txtBuscador.Location = new Point(3, 3);
            txtBuscador.Margin = new Padding(3, 2, 3, 2);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(276, 22);
            txtBuscador.TabIndex = 20;
            txtBuscador.Text = "Buscar...";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(350, 3);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 29);
            comboBox1.TabIndex = 21;
            comboBox1.Text = "Organizar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(10, 128);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(897, 161);
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
            btnAgregar.Location = new Point(3, 2);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 31);
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
            btnCategorias.Location = new Point(183, 2);
            btnCategorias.Margin = new Padding(3, 2, 3, 2);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(136, 31);
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
            btnAutores.Location = new Point(362, 2);
            btnAutores.Margin = new Padding(3, 2, 3, 2);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(136, 31);
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
            Editoriales.Location = new Point(541, 2);
            Editoriales.Margin = new Padding(3, 2, 3, 2);
            Editoriales.Name = "Editoriales";
            Editoriales.Size = new Size(138, 31);
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
            tableLayoutPanel1.Location = new Point(10, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(900, 40);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(txtBuscador);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(13, 67);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 38);
            panel1.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 31;
            label4.Text = "ISBN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 32;
            label5.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 33;
            label2.Text = "Titulo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 34);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 34;
            label6.Text = "Ejemplares Totales:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 68);
            label7.Name = "label7";
            label7.Size = new Size(94, 35);
            label7.TabIndex = 35;
            label7.Text = " Ejemplares Disponbles:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.45509F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.54491F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 392F));
            tableLayoutPanel2.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel2.Controls.Add(label5, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label7, 2, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 2, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(comboBoxCategoria, 3, 0);
            tableLayoutPanel2.Controls.Add(comboBoxAutor, 1, 2);
            tableLayoutPanel2.Controls.Add(comboBoxEjemplares, 3, 2);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(8, 308);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Size = new Size(900, 103);
            tableLayoutPanel2.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(510, 36);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(88, 29);
            textBox4.TabIndex = 39;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 36);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 29);
            textBox2.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 2);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 29);
            textBox1.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 40;
            label3.Text = "Autor:";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(510, 3);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(121, 29);
            comboBoxCategoria.TabIndex = 41;
            // 
            // comboBoxAutor
            // 
            comboBoxAutor.FormattingEnabled = true;
            comboBoxAutor.Location = new Point(78, 71);
            comboBoxAutor.Name = "comboBoxAutor";
            comboBoxAutor.Size = new Size(179, 29);
            comboBoxAutor.TabIndex = 42;
            // 
            // comboBoxEjemplares
            // 
            comboBoxEjemplares.FormattingEnabled = true;
            comboBoxEjemplares.Location = new Point(510, 71);
            comboBoxEjemplares.Name = "comboBoxEjemplares";
            comboBoxEjemplares.Size = new Size(121, 29);
            comboBoxEjemplares.TabIndex = 43;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(920, 437);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmLibros";
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
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxAutor;
        private ComboBox comboBoxEjemplares;
    }
}