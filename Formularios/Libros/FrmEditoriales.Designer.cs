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
            lblTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBuscador = new TextBox();
            btnAgregarEditorial = new Button();
            lblBuscar = new Label();
            dtEditoriales = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtEditoriales).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(14, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 46);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Editoriales";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9712219F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.02878F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.Controls.Add(txtBuscador, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarEditorial, 2, 0);
            tableLayoutPanel1.Controls.Add(lblBuscar, 0, 0);
            tableLayoutPanel1.Location = new Point(15, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1003, 52);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Left;
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(282, 12);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar...";
            txtBuscador.Size = new Size(316, 27);
            txtBuscador.TabIndex = 26;
            // 
            // btnAgregarEditorial
            // 
            btnAgregarEditorial.Anchor = AnchorStyles.Left;
            btnAgregarEditorial.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarEditorial.ForeColor = SystemColors.Control;
            btnAgregarEditorial.Location = new Point(779, 3);
            btnAgregarEditorial.Name = "btnAgregarEditorial";
            btnAgregarEditorial.Size = new Size(221, 46);
            btnAgregarEditorial.TabIndex = 24;
            btnAgregarEditorial.Text = "Agregar Editorial";
            btnAgregarEditorial.UseVisualStyleBackColor = false;
            btnAgregarEditorial.Click += BtnAgregarEditorial_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.Left;
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(3, 12);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(170, 28);
            lblBuscar.TabIndex = 25;
            lblBuscar.Text = "Buscar la Editorial:";
            // 
            // dtEditoriales
            // 
            dtEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEditoriales.Columns.AddRange(new DataGridViewColumn[] { id, nombre });
            dtEditoriales.Location = new Point(14, 184);
            dtEditoriales.Name = "dtEditoriales";
            dtEditoriales.RowHeadersVisible = false;
            dtEditoriales.RowHeadersWidth = 51;
            dtEditoriales.Size = new Size(1001, 387);
            dtEditoriales.TabIndex = 29;
            dtEditoriales.CellDoubleClick += dtEditoriales_CellDoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.FillWeight = 94.62568F;
            id.HeaderText = "Id";
            id.MinimumWidth = 3;
            id.Name = "id";
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.FillWeight = 100.0257F;
            nombre.HeaderText = "Editorial";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresar.ForeColor = SystemColors.Control;
            btnRegresar.Location = new Point(909, 26);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(109, 38);
            btnRegresar.TabIndex = 40;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1052, 583);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtEditoriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtBuscador;
        private Button btnAgregarCategoria;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnRegresar;
        private Button btnAgregarEditorial;
        private Label lblBuscar;
        private DataGridView dtEditoriales;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
    }
}