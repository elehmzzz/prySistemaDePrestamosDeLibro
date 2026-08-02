namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    partial class FrmEditoriales
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
            lblTitulo = new Label();
            txtBuscador = new TextBox();
            btnAgregar = new Button();
            lblBuscar = new Label();
            dtEditoriales = new DataGridView();
            btnRegresar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEliminar = new Button();
            btnActualizar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dtEditoriales).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(14, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(141, 37);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Editoriales";
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Left;
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(203, 12);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar...";
            txtBuscador.Size = new Size(316, 22);
            txtBuscador.TabIndex = 26;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left;
            btnAgregar.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(559, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(221, 45);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Agregar Editorial";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += BtnAgregarEditorial_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.Left;
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(3, 11);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(136, 21);
            lblBuscar.TabIndex = 25;
            lblBuscar.Text = "Buscar la Editorial:";
            // 
            // dtEditoriales
            // 
            dtEditoriales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtEditoriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEditoriales.EnableHeadersVisualStyles = false;
            dtEditoriales.Location = new Point(14, 184);
            dtEditoriales.Name = "dtEditoriales";
            dtEditoriales.ReadOnly = true;
            dtEditoriales.RowHeadersVisible = false;
            dtEditoriales.RowHeadersWidth = 51;
            dtEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtEditoriales.Size = new Size(784, 215);
            dtEditoriales.TabIndex = 29;
            dtEditoriales.CellDoubleClick += dtEditoriales_CellDoubleClick;
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresar.ForeColor = SystemColors.Control;
            btnRegresar.Location = new Point(685, 19);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(109, 38);
            btnRegresar.TabIndex = 40;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
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
            tableLayoutPanel1.Controls.Add(lblBuscar, 0, 0);
            tableLayoutPanel1.Location = new Point(15, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(783, 51);
            tableLayoutPanel1.TabIndex = 30;
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
            btnEliminar.TabIndex = 45;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnActualizar.TabIndex = 44;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.Location = new Point(130, 469);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(371, 34);
            txtNombre.TabIndex = 43;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 475);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "Nombre:";
            // 
            // lblCategoria
            // 
            lblCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(18, 418);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(266, 28);
            lblCategoria.TabIndex = 41;
            lblCategoria.Text = "Editar categoría seleccionada";
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(853, 569);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblCategoria);
            Controls.Add(btnRegresar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dtEditoriales);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEditoriales";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmEditoriales";
            Load += FrmEditoriales_Load;
            ((System.ComponentModel.ISupportInitialize)dtEditoriales).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtBuscador;
        private Button btnAgregarCategoria;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnRegresar;
        private Button btnAgregar;
        private Label lblBuscar;
        private DataGridView dtEditoriales;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEliminar;
        private Button btnActualizar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblCategoria;
    }
}