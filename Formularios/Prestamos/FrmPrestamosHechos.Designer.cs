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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            contenedorBusquedayAgrPrestamo = new TableLayoutPanel();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            btnAgregarPrestamo = new Button();
            cmbVistasPrestamos = new ComboBox();
            dGVPrestamos = new DataGridView();
            btnDatosLectores = new Button();
            txtNombre = new TextBox();
            contenedorBusquedayAgrPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVPrestamos).BeginInit();
            SuspendLayout();
            // 
            // contenedorBusquedayAgrPrestamo
            // 
            contenedorBusquedayAgrPrestamo.ColumnCount = 4;
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            contenedorBusquedayAgrPrestamo.Controls.Add(dtpFecha, 2, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(label1, 0, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(btnAgregarPrestamo, 3, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(cmbVistasPrestamos, 1, 0);
            contenedorBusquedayAgrPrestamo.Location = new Point(23, 33);
            contenedorBusquedayAgrPrestamo.Name = "contenedorBusquedayAgrPrestamo";
            contenedorBusquedayAgrPrestamo.RowCount = 1;
            contenedorBusquedayAgrPrestamo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contenedorBusquedayAgrPrestamo.Size = new Size(987, 40);
            contenedorBusquedayAgrPrestamo.TabIndex = 9;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(495, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(233, 27);
            dtpFecha.TabIndex = 33;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 28;
            label1.Text = "Ver opciones de informes:";
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.AutoSize = true;
            btnAgregarPrestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarPrestamo.BackgroundImageLayout = ImageLayout.None;
            btnAgregarPrestamo.ForeColor = SystemColors.Control;
            btnAgregarPrestamo.Location = new Point(741, 3);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(139, 34);
            btnAgregarPrestamo.TabIndex = 23;
            btnAgregarPrestamo.Text = "Agregar Prestamo";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            // 
            // cmbVistasPrestamos
            // 
            cmbVistasPrestamos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVistasPrestamos.FormattingEnabled = true;
            cmbVistasPrestamos.Items.AddRange(new object[] { "[Selecciona una opción]", "Ver préstamos", "Ver préstamos por día" });
            cmbVistasPrestamos.Location = new Point(249, 4);
            cmbVistasPrestamos.Margin = new Padding(3, 4, 3, 4);
            cmbVistasPrestamos.Name = "cmbVistasPrestamos";
            cmbVistasPrestamos.Size = new Size(240, 28);
            cmbVistasPrestamos.TabIndex = 29;
            cmbVistasPrestamos.SelectedIndexChanged += cmbVistasPrestamos_SelectedIndexChanged;
            // 
            // dGVPrestamos
            // 
            dGVPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGVPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGVPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVPrestamos.EnableHeadersVisualStyles = false;
            dGVPrestamos.Location = new Point(23, 79);
            dGVPrestamos.Name = "dGVPrestamos";
            dGVPrestamos.ReadOnly = true;
            dGVPrestamos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGVPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGVPrestamos.RowHeadersVisible = false;
            dGVPrestamos.RowHeadersWidth = 51;
            dGVPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVPrestamos.Size = new Size(987, 361);
            dGVPrestamos.TabIndex = 31;
            dGVPrestamos.CellDoubleClick += dtPrestamos_CellDoubleClick;
            // 
            // btnDatosLectores
            // 
            btnDatosLectores.AutoSize = true;
            btnDatosLectores.BackColor = Color.FromArgb(32, 41, 64);
            btnDatosLectores.ForeColor = SystemColors.Control;
            btnDatosLectores.Location = new Point(846, 467);
            btnDatosLectores.Name = "btnDatosLectores";
            btnDatosLectores.Size = new Size(165, 47);
            btnDatosLectores.TabIndex = 32;
            btnDatosLectores.Text = "Datos del prestamo";
            btnDatosLectores.UseVisualStyleBackColor = false;
            btnDatosLectores.Click += btnDatosLectores_Click;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(23, 477);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(469, 27);
            txtNombre.TabIndex = 59;
            // 
            // FrmPrestamosHechos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1034, 536);
            Controls.Add(txtNombre);
            Controls.Add(btnDatosLectores);
            Controls.Add(dGVPrestamos);
            Controls.Add(contenedorBusquedayAgrPrestamo);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmPrestamosHechos";
            Text = "FrmPrestamosHechos";
            Load += onLoad;
            contenedorBusquedayAgrPrestamo.ResumeLayout(false);
            contenedorBusquedayAgrPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGVPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel contenedorBusquedayAgrPrestamo;
        private Button btnAgregarPrestamo;
        private Button btnDatosLectores;
        private TextBox txtNombre;
        private DataGridView dGVPrestamos;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox cmbVistasPrestamos;
        private DateTimePicker dtpFecha;
    }
}