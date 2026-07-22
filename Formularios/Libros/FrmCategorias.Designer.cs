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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnAgregarCategoria = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBuscador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtcategoriaSeleccioanda = new TextBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(14, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(784, 215);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.FillWeight = 94.62568F;
            Column1.HeaderText = "id";
            Column1.MinimumWidth = 3;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "nombre";
            Column2.FillWeight = 100.0257F;
            Column2.HeaderText = "Categoria";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Anchor = AnchorStyles.Left;
            btnAgregarCategoria.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarCategoria.ForeColor = SystemColors.Control;
            btnAgregarCategoria.Location = new Point(559, 3);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(221, 44);
            btnAgregarCategoria.TabIndex = 24;
            btnAgregarCategoria.Text = "Agregar categoria";
            btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9712219F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.02878F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.Controls.Add(txtBuscador, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarCategoria, 2, 0);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 18);
            label2.Name = "label2";
            label2.Size = new Size(144, 37);
            label2.TabIndex = 27;
            label2.Text = "Categorías";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(18, 425);
            label3.Name = "label3";
            label3.Size = new Size(210, 21);
            label3.TabIndex = 28;
            label3.Text = "Editar categoría seleccionada";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(18, 482);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 29;
            label4.Text = "Nombre:";
            // 
            // txtcategoriaSeleccioanda
            // 
            txtcategoriaSeleccioanda.Location = new Point(134, 484);
            txtcategoriaSeleccioanda.Name = "txtcategoriaSeleccioanda";
            txtcategoriaSeleccioanda.Size = new Size(371, 29);
            txtcategoriaSeleccioanda.TabIndex = 30;
            // 
            // btnActualizar
            // 
            btnActualizar.AutoSize = true;
            btnActualizar.BackColor = Color.FromArgb(32, 41, 64);
            btnActualizar.ForeColor = SystemColors.Control;
            btnActualizar.Location = new Point(669, 482);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(129, 38);
            btnActualizar.TabIndex = 31;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.BackColor = Color.FromArgb(32, 41, 64);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(825, 482);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 38);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresar.ForeColor = SystemColors.Control;
            btnRegresar.Location = new Point(909, 26);
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
            ClientSize = new Size(1052, 583);
            Controls.Add(btnRegresar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(txtcategoriaSeleccioanda);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnAgregarCategoria;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox txtBuscador;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtcategoriaSeleccioanda;
        private Button buttonActualizar;
        private Button button3;
        private Button btnRegresar;
        private Button btnEliminar;
        private Button btnActualizar;
    }
}