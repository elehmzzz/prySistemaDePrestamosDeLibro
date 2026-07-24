namespace prySistemaDePrestamosDeLibro.Formularios.FRMprestamos
{
    partial class FrmPrestamosHechos
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
            contenedorBusquedayAgrPrestamo = new TableLayoutPanel();
            cmbxbuscarprestamo = new ComboBox();
            btnAgregarPrestamo = new Button();
            comboBoxFiltro = new ComboBox();
            dGVPrestamos = new DataGridView();
            btnDatosLectores = new Button();
            textBoxnamelector = new TextBox();
            contenedorBusquedayAgrPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVPrestamos).BeginInit();
            SuspendLayout();
            // 
            // contenedorBusquedayAgrPrestamo
            // 
            contenedorBusquedayAgrPrestamo.ColumnCount = 3;
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.5014F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5294113F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.9691868F));
            contenedorBusquedayAgrPrestamo.Controls.Add(cmbxbuscarprestamo, 0, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(btnAgregarPrestamo, 2, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(comboBoxFiltro, 1, 0);
            contenedorBusquedayAgrPrestamo.Location = new Point(23, 33);
            contenedorBusquedayAgrPrestamo.Name = "contenedorBusquedayAgrPrestamo";
            contenedorBusquedayAgrPrestamo.RowCount = 1;
            contenedorBusquedayAgrPrestamo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contenedorBusquedayAgrPrestamo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            contenedorBusquedayAgrPrestamo.Size = new Size(714, 40);
            contenedorBusquedayAgrPrestamo.TabIndex = 9;
            contenedorBusquedayAgrPrestamo.Paint += tableLayoutPanel1_Paint;
            // 
            // cmbxbuscarprestamo
            // 
            cmbxbuscarprestamo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbxbuscarprestamo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbxbuscarprestamo.ForeColor = Color.Gray;
            cmbxbuscarprestamo.FormattingEnabled = true;
            cmbxbuscarprestamo.Location = new Point(3, 3);
            cmbxbuscarprestamo.Name = "cmbxbuscarprestamo";
            cmbxbuscarprestamo.Size = new Size(376, 28);
            cmbxbuscarprestamo.TabIndex = 24;
            cmbxbuscarprestamo.Text = "busca a tu lector y sus prestamos";
            cmbxbuscarprestamo.SelectedIndexChanged += cmbxbuscarprestamo_SelectedIndexChanged;
            cmbxbuscarprestamo.TextChanged += cmbxbuscarprestamo_TextChanged;
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.AutoSize = true;
            btnAgregarPrestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarPrestamo.BackgroundImageLayout = ImageLayout.None;
            btnAgregarPrestamo.ForeColor = SystemColors.Control;
            btnAgregarPrestamo.Location = new Point(553, 3);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(139, 30);
            btnAgregarPrestamo.TabIndex = 23;
            btnAgregarPrestamo.Text = "Agregar Prestamo";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            // 
            // comboBoxFiltro
            // 
            comboBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltro.FormattingEnabled = true;
            comboBoxFiltro.Items.AddRange(new object[] { "Todos", "Vigentes", "Vencidos" });
            comboBoxFiltro.Location = new Point(385, 3);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(140, 28);
            comboBoxFiltro.TabIndex = 22;
            comboBoxFiltro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dGVPrestamos
            // 
            dGVPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVPrestamos.Location = new Point(23, 79);
            dGVPrestamos.Name = "dGVPrestamos";
            dGVPrestamos.RowHeadersVisible = false;
            dGVPrestamos.RowHeadersWidth = 51;
            dGVPrestamos.Size = new Size(987, 361);
            dGVPrestamos.TabIndex = 31;
            dGVPrestamos.CellContentClick += dGVPrestamos_CellContentClick;
            // 
            // btnDatosLectores
            // 
            btnDatosLectores.AutoSize = true;
            btnDatosLectores.BackColor = Color.FromArgb(32, 41, 64);
            btnDatosLectores.ForeColor = SystemColors.Control;
            btnDatosLectores.Location = new Point(846, 467);
            btnDatosLectores.Name = "btnDatosLectores";
            btnDatosLectores.Size = new Size(164, 47);
            btnDatosLectores.TabIndex = 32;
            btnDatosLectores.Text = "Datos del prestamo";
            btnDatosLectores.UseVisualStyleBackColor = false;
            // 
            // textBoxnamelector
            // 
            textBoxnamelector.Enabled = false;
            textBoxnamelector.Location = new Point(23, 467);
            textBoxnamelector.Name = "textBoxnamelector";
            textBoxnamelector.Size = new Size(469, 27);
            textBoxnamelector.TabIndex = 59;
            textBoxnamelector.TextChanged += textBoxnamelector_TextChanged;
            // 
            // FrmPrestamosHechos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1034, 536);
            Controls.Add(textBoxnamelector);
            Controls.Add(btnDatosLectores);
            Controls.Add(dGVPrestamos);
            Controls.Add(contenedorBusquedayAgrPrestamo);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmPrestamosHechos";
            Text = "FrmPrestamosHechos";
            Load += FrmPrestamosHechos_Load_1;
            contenedorBusquedayAgrPrestamo.ResumeLayout(false);
            contenedorBusquedayAgrPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel contenedorBusquedayAgrPrestamo;
        private Button btnAgregarPrestamo;
        private ComboBox comboBoxFiltro;
        private Button btnDatosLectores;
        private TextBox textBoxnamelector;
        private ComboBox cmbxbuscarprestamo;
        private DataGridView dGVPrestamos;
        private TableLayoutPanel tableLayoutPanel1;
    }
}