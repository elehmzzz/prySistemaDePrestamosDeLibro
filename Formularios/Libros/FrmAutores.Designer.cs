namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    partial class FrmAutores
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
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBuscador = new TextBox();
            btnAgregarAutor = new Button();
            label1 = new Label();
            dtAutores = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnRegresar = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtAutores).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 4);
            label2.Name = "label2";
            label2.Size = new Size(108, 37);
            label2.TabIndex = 28;
            label2.Text = "Autores";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.6176472F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.3823547F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel1.Controls.Add(txtBuscador, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarAutor, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(15, 89);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(783, 51);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Left;
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(179, 14);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar";
            txtBuscador.Size = new Size(316, 22);
            txtBuscador.TabIndex = 26;
            txtBuscador.TextChanged += txtBuscador_TextChanged;
            // 
            // btnAgregarAutor
            // 
            btnAgregarAutor.Anchor = AnchorStyles.Left;
            btnAgregarAutor.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarAutor.ForeColor = SystemColors.Control;
            btnAgregarAutor.Location = new Point(559, 3);
            btnAgregarAutor.Name = "btnAgregarAutor";
            btnAgregarAutor.Size = new Size(221, 45);
            btnAgregarAutor.TabIndex = 24;
            btnAgregarAutor.Text = "Agregar autor";
            btnAgregarAutor.UseVisualStyleBackColor = false;
            btnAgregarAutor.Click += btnAgregarAutor_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 25;
            label1.Text = "Buscar el autor:";
            // 
            // dtAutores
            // 
            dtAutores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtAutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtAutores.EnableHeadersVisualStyles = false;
            dtAutores.Location = new Point(14, 184);
            dtAutores.Name = "dtAutores";
            dtAutores.ReadOnly = true;
            dtAutores.RowHeadersVisible = false;
            dtAutores.RowHeadersWidth = 51;
            dtAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtAutores.Size = new Size(784, 215);
            dtAutores.TabIndex = 30;
            dtAutores.CellDoubleClick += dtAutores_CellDoubleClick;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(18, 411);
            label3.Name = "label3";
            label3.Size = new Size(187, 21);
            label3.TabIndex = 31;
            label3.Text = "Editar autor seleccionado:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(18, 468);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 32;
            label4.Text = "Nombre(s):";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(18, 521);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 33;
            label5.Text = "Apellido P:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(442, 468);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 34;
            label6.Text = "Apellido M:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombre.Location = new Point(130, 469);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 29);
            txtNombre.TabIndex = 35;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtAPaterno.Location = new Point(130, 522);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(199, 29);
            txtAPaterno.TabIndex = 36;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtAMaterno.Location = new Point(561, 469);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(194, 29);
            txtAMaterno.TabIndex = 37;
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
            btnActualizar.TabIndex = 38;
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
            btnEliminar.TabIndex = 39;
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
            btnRegresar.Location = new Point(685, 19);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(109, 38);
            btnRegresar.TabIndex = 40;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(853, 569);
            Controls.Add(label4);
            Controls.Add(btnActualizar);
            Controls.Add(txtAMaterno);
            Controls.Add(btnRegresar);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(label6);
            Controls.Add(txtAPaterno);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(dtAutores);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FrmAutores";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmAutores";
            Load += FrmAutores_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtBuscador;
        private Button btnAgregarAutor;
        private Label label1;
        private DataGridView dtAutores;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnRegresar;
        private Button btnActualizar;
        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
    }
}