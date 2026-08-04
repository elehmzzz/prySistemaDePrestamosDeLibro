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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtLibros = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtBuscador = new TextBox();
            btnAgregar = new Button();
            lblBuscar = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            label4 = new Label();
            txtISBN = new TextBox();
            lblAutor = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            lblLibro = new Label();
            cmbEditorial = new ComboBox();
            cmbCategoria = new ComboBox();
            lblEditorial = new Label();
            lblCategoria = new Label();
            cmbAutor = new ComboBox();
            btnCategorias = new Button();
            btnAutores = new Button();
            Editoriales = new Button();
            ((System.ComponentModel.ISupportInitialize)dtLibros).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtLibros
            // 
            dtLibros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtLibros.EnableHeadersVisualStyles = false;
            dtLibros.Location = new Point(10, 128);
            dtLibros.Margin = new Padding(3, 2, 3, 2);
            dtLibros.Name = "dtLibros";
            dtLibros.ReadOnly = true;
            dtLibros.RowHeadersVisible = false;
            dtLibros.RowHeadersWidth = 51;
            dtLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtLibros.Size = new Size(686, 161);
            dtLibros.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9712219F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.02878F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel3.Controls.Add(txtBuscador, 1, 0);
            tableLayoutPanel3.Controls.Add(btnAgregar, 2, 0);
            tableLayoutPanel3.Controls.Add(lblBuscar, 0, 0);
            tableLayoutPanel3.Location = new Point(13, 67);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(685, 38);
            tableLayoutPanel3.TabIndex = 37;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Left;
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(177, 8);
            txtBuscador.Margin = new Padding(3, 2, 3, 2);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar...";
            txtBuscador.Size = new Size(276, 22);
            txtBuscador.TabIndex = 26;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left;
            btnAgregar.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(488, 2);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(193, 34);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Agregar Libro";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.Left;
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(3, 11);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(75, 15);
            lblBuscar.TabIndex = 25;
            lblBuscar.Text = "Buscar  libro:";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtTitulo.Enabled = false;
            txtTitulo.Location = new Point(78, 381);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(179, 23);
            txtTitulo.TabIndex = 53;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F);
            lblTitulo.Location = new Point(16, 381);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(52, 21);
            lblTitulo.TabIndex = 49;
            lblTitulo.Text = "Titulo:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(16, 351);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 47;
            label4.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtISBN.Enabled = false;
            txtISBN.Location = new Point(78, 351);
            txtISBN.Margin = new Padding(3, 2, 3, 2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(179, 23);
            txtISBN.TabIndex = 52;
            // 
            // lblAutor
            // 
            lblAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 12F);
            lblAutor.Location = new Point(16, 411);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(52, 21);
            lblAutor.TabIndex = 55;
            lblAutor.Text = "Autor:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnEliminar.AutoSize = true;
            btnEliminar.BackColor = Color.FromArgb(32, 41, 64);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(582, 311);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 28);
            btnEliminar.TabIndex = 60;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnActualizar.AutoSize = true;
            btnActualizar.BackColor = Color.FromArgb(32, 41, 64);
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(467, 311);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 28);
            btnActualizar.TabIndex = 59;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lblLibro
            // 
            lblLibro.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Segoe UI", 12F);
            lblLibro.Location = new Point(16, 314);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(210, 21);
            lblLibro.TabIndex = 58;
            lblLibro.Text = "Editar categoría seleccionada";
            // 
            // cmbEditorial
            // 
            cmbEditorial.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(516, 380);
            cmbEditorial.Margin = new Padding(3, 2, 3, 2);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(179, 23);
            cmbEditorial.TabIndex = 64;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(516, 350);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(179, 23);
            cmbCategoria.TabIndex = 63;
            // 
            // lblEditorial
            // 
            lblEditorial.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 12F);
            lblEditorial.Location = new Point(424, 380);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(70, 21);
            lblEditorial.TabIndex = 62;
            lblEditorial.Text = "Editorial:";
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F);
            lblCategoria.Location = new Point(424, 350);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 21);
            lblCategoria.TabIndex = 61;
            lblCategoria.Text = "Categoria:";
            // 
            // cmbAutor
            // 
            cmbAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(78, 411);
            cmbAutor.Margin = new Padding(3, 2, 3, 2);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(179, 23);
            cmbAutor.TabIndex = 65;
            // 
            // btnCategorias
            // 
            btnCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCategorias.AutoSize = true;
            btnCategorias.BackColor = Color.FromArgb(32, 41, 64);
            btnCategorias.ForeColor = SystemColors.Control;
            btnCategorias.Location = new Point(220, 11);
            btnCategorias.Margin = new Padding(3, 2, 3, 2);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(136, 34);
            btnCategorias.TabIndex = 66;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnAutores
            // 
            btnAutores.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAutores.AutoSize = true;
            btnAutores.BackColor = Color.FromArgb(32, 41, 64);
            btnAutores.ForeColor = SystemColors.Control;
            btnAutores.Location = new Point(386, 11);
            btnAutores.Margin = new Padding(3, 2, 3, 2);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(136, 34);
            btnAutores.TabIndex = 67;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // Editoriales
            // 
            Editoriales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Editoriales.AutoSize = true;
            Editoriales.BackColor = Color.FromArgb(32, 41, 64);
            Editoriales.ForeColor = SystemColors.Control;
            Editoriales.Location = new Point(557, 11);
            Editoriales.Margin = new Padding(3, 2, 3, 2);
            Editoriales.Name = "Editoriales";
            Editoriales.Size = new Size(138, 34);
            Editoriales.TabIndex = 68;
            Editoriales.Text = "Editoriales";
            Editoriales.UseVisualStyleBackColor = false;
            Editoriales.Click += Editoriales_Click;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(746, 465);
            Controls.Add(btnCategorias);
            Controls.Add(btnAutores);
            Controls.Add(Editoriales);
            Controls.Add(cmbAutor);
            Controls.Add(cmbEditorial);
            Controls.Add(cmbCategoria);
            Controls.Add(lblEditorial);
            Controls.Add(lblCategoria);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(lblLibro);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(label4);
            Controls.Add(txtISBN);
            Controls.Add(lblAutor);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(dtLibros);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditConsultaLibros";
            Load += Load_FrmLibros;
            ((System.ComponentModel.ISupportInitialize)dtLibros).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtLibros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtBuscador;
        private Button btnAgregar;
        private Label lblBuscar;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Label label4;
        private TextBox txtISBN;
        private Label lblAutor;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label lblLibro;
        private ComboBox cmbEditorial;
        private ComboBox cmbCategoria;
        private Label lblEditorial;
        private Label lblCategoria;
        private ComboBox cmbAutor;
        private Button btnCategorias;
        private Button btnAutores;
        private Button Editoriales;
    }
}
