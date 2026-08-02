namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    partial class FrmCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtCategorias = new DataGridView();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBuscador = new TextBox();
            label1 = new Label();
            lblTitulo = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtCategorias).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtCategorias
            // 
            dtCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCategorias.EnableHeadersVisualStyles = false;
            dtCategorias.Location = new Point(14, 184);
            dtCategorias.Name = "dtCategorias";
            dtCategorias.ReadOnly = true;
            dtCategorias.RowHeadersVisible = false;
            dtCategorias.RowHeadersWidth = 51;
            dtCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtCategorias.Size = new Size(784, 215);
            dtCategorias.TabIndex = 23;
            dtCategorias.CellDoubleClick += dtCategorias_CellDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left;
            btnAgregar.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(559, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(221, 44);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Agregar categoria";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregarCategoria_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9712219F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.02878F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.Controls.Add(txtBuscador, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregar, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(15, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(783, 51);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Left;
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(203, 14);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar...";
            txtBuscador.Size = new Size(316, 22);
            txtBuscador.TabIndex = 26;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 25;
            label1.Text = "Buscar la categoría:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(14, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 46);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "Categorías";
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(18, 418);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(266, 28);
            lblCategoria.TabIndex = 28;
            lblCategoria.Text = "Editar categoría seleccionada";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 475);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 29;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.Location = new Point(130, 469);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(371, 34);
            txtNombre.TabIndex = 30;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.AutoSize = true;
            btnActualizar.BackColor = Color.FromArgb(32, 41, 64);
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(534, 415);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(129, 38);
            btnActualizar.TabIndex = 31;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.AutoSize = true;
            btnEliminar.BackColor = Color.FromArgb(32, 41, 64);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(665, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 38);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresar.ForeColor = SystemColors.Control;
            btnRegresar.Location = new Point(689, 18);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(109, 38);
            btnRegresar.TabIndex = 39;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(853, 569);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dtCategorias);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dtCategorias).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtCategorias;
        private Button btnAgregar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtBuscador;
        private Label lblTitulo;
        private Label lblCategoria;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button buttonActualizar;
        private Button button3;
        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnActualizar;
    }
}