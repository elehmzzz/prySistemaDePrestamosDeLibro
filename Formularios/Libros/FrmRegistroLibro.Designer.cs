namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmRegistroLibro
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
            lblCategoria = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblAutor = new Label();
            lblEditorial = new Label();
            cmbAutor = new ComboBox();
            cmbCategoria = new ComboBox();
            cmbEditorial = new ComboBox();
            btnCerrar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F);
            lblCategoria.Location = new Point(20, 140);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(101, 28);
            lblCategoria.TabIndex = 32;
            lblCategoria.Text = "Categoria:";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.Location = new Point(126, 61);
            txtTitulo.Margin = new Padding(4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(286, 27);
            txtTitulo.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F);
            lblTitulo.Location = new Point(20, 60);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(66, 28);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Titulo:";
            // 
            // lblISBN
            // 
            lblISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 12F);
            lblISBN.Location = new Point(20, 20);
            lblISBN.Margin = new Padding(4, 0, 4, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(58, 28);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtISBN.Location = new Point(126, 21);
            txtISBN.Margin = new Padding(4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(286, 27);
            txtISBN.TabIndex = 4;
            // 
            // lblAutor
            // 
            lblAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 12F);
            lblAutor.Location = new Point(20, 100);
            lblAutor.Margin = new Padding(4, 0, 4, 0);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(66, 28);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "Autor:";
            // 
            // lblEditorial
            // 
            lblEditorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 12F);
            lblEditorial.Location = new Point(20, 180);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(89, 28);
            lblEditorial.TabIndex = 44;
            lblEditorial.Text = "Editorial:";
            // 
            // cmbAutor
            // 
            cmbAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(126, 100);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(286, 28);
            cmbAutor.TabIndex = 45;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(126, 140);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(286, 28);
            cmbCategoria.TabIndex = 46;
            // 
            // cmbEditorial
            // 
            cmbEditorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(126, 180);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(286, 28);
            cmbEditorial.TabIndex = 47;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.AutoSize = true;
            btnCerrar.Font = new Font("Segoe UI", 12F);
            btnCerrar.Location = new Point(207, 249);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(96, 38);
            btnCerrar.TabIndex = 48;
            btnCerrar.Text = "Cancelar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.FromArgb(32, 41, 64);
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(318, 249);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 38);
            btnGuardar.TabIndex = 49;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmRegistroLibro
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(445, 309);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEditorial);
            Controls.Add(cmbCategoria);
            Controls.Add(cmbAutor);
            Controls.Add(lblEditorial);
            Controls.Add(lblCategoria);
            Controls.Add(txtTitulo);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistroLibro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Libro";
            Load += load_frmRegistroLibro;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private Label lblCategoria;
        private Label label7;
        private Button button1;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblAutor;
        private Label lblEditorial;
        private ComboBox cmbAutor;
        private ComboBox cmbCategoria;
        private ComboBox cmbEditorial;
        private Button btnCerrar;
        private Button btnGuardar;
    }
}