namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmLectores
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
            label1 = new Label();
            txtBuscador = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            chkAlfabetico = new CheckBox();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAgregarLectores = new Button();
            Editoriales = new Button();
            btnEditarLectores = new Button();
            btnDatosLectores = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(384, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 3;
            label1.Text = "Organizado por:";
            // 
            // txtBuscador
            // 
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(3, 3);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar";
            txtBuscador.Size = new Size(316, 27);
            txtBuscador.TabIndex = 1;
            txtBuscador.TextChanged += txtBuscador_TextChanged_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtBuscador, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(chkAlfabetico, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 91);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(762, 110);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // chkAlfabetico
            // 
            chkAlfabetico.AutoSize = true;
            chkAlfabetico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAlfabetico.Location = new Point(384, 58);
            chkAlfabetico.Name = "chkAlfabetico";
            chkAlfabetico.Size = new Size(123, 32);
            chkAlfabetico.TabIndex = 4;
            chkAlfabetico.Text = "Alfabetico";
            chkAlfabetico.UseVisualStyleBackColor = true;
            chkAlfabetico.CheckedChanged += chkAlfabetico_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 20);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(324, 46);
            label4.TabIndex = 8;
            label4.Text = "Consulta de lectores";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AccessibleRole = AccessibleRole.MenuBar;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.Controls.Add(btnAgregarLectores, 0, 0);
            tableLayoutPanel2.Controls.Add(Editoriales, 3, 0);
            tableLayoutPanel2.Controls.Add(btnEditarLectores, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDatosLectores, 2, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(15, 518);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.Size = new Size(1029, 53);
            tableLayoutPanel2.TabIndex = 30;
            // 
            // btnAgregarLectores
            // 
            btnAgregarLectores.AutoSize = true;
            btnAgregarLectores.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarLectores.BackgroundImageLayout = ImageLayout.None;
            btnAgregarLectores.ForeColor = SystemColors.Control;
            btnAgregarLectores.Location = new Point(3, 3);
            btnAgregarLectores.Name = "btnAgregarLectores";
            btnAgregarLectores.Size = new Size(170, 47);
            btnAgregarLectores.TabIndex = 23;
            btnAgregarLectores.Text = "Agregar Lector";
            btnAgregarLectores.UseVisualStyleBackColor = false;
            btnAgregarLectores.Click += btnAgregarLectores_Click;
            // 
            // Editoriales
            // 
            Editoriales.AutoSize = true;
            Editoriales.BackColor = Color.FromArgb(32, 41, 64);
            Editoriales.ForeColor = SystemColors.Control;
            Editoriales.Location = new Point(618, 3);
            Editoriales.Name = "Editoriales";
            Editoriales.Size = new Size(113, 47);
            Editoriales.TabIndex = 28;
            Editoriales.Text = "Editoriales";
            Editoriales.UseVisualStyleBackColor = false;
            // 
            // btnEditarLectores
            // 
            btnEditarLectores.AutoSize = true;
            btnEditarLectores.BackColor = Color.FromArgb(32, 41, 64);
            btnEditarLectores.ForeColor = SystemColors.Control;
            btnEditarLectores.Location = new Point(208, 3);
            btnEditarLectores.Name = "btnEditarLectores";
            btnEditarLectores.Size = new Size(150, 47);
            btnEditarLectores.TabIndex = 27;
            btnEditarLectores.Text = "Editar Lector";
            btnEditarLectores.UseVisualStyleBackColor = false;
            btnEditarLectores.Click += btnEditarLectores_Click;
            // 
            // btnDatosLectores
            // 
            btnDatosLectores.AutoSize = true;
            btnDatosLectores.BackColor = Color.FromArgb(32, 41, 64);
            btnDatosLectores.ForeColor = SystemColors.Control;
            btnDatosLectores.Location = new Point(413, 3);
            btnDatosLectores.Name = "btnDatosLectores";
            btnDatosLectores.Size = new Size(164, 47);
            btnDatosLectores.TabIndex = 26;
            btnDatosLectores.Text = "Datos del Lector";
            btnDatosLectores.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1025, 284);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // FrmLectores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1052, 583);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmLectores";
            Text = "FrmLectores";
            Load += FrmLectores_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBuscador;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregarLectores;
        private Button btnDatosLectores;
        private Button btnEditarLectores;
        private Button Editoriales;
        private DataGridView dataGridView1;
        private CheckBox chkAlfabetico;
    }
}