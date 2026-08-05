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
            btnConsultar = new Button();
            dGVPrestamos = new DataGridView();
            btnDatosLectores = new Button();
            txtNombre = new TextBox();
            contenedorBusquedayAgrPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGVPrestamos).BeginInit();
            SuspendLayout();
            // 
            // contenedorBusquedayAgrPrestamo
            // 
            contenedorBusquedayAgrPrestamo.ColumnCount = 5;
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            contenedorBusquedayAgrPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            contenedorBusquedayAgrPrestamo.Controls.Add(dtpFecha, 2, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(label1, 0, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(btnAgregarPrestamo, 4, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(cmbVistasPrestamos, 1, 0);
            contenedorBusquedayAgrPrestamo.Controls.Add(btnConsultar, 3, 0);
            contenedorBusquedayAgrPrestamo.Location = new Point(20, 25);
            contenedorBusquedayAgrPrestamo.Margin = new Padding(3, 2, 3, 2);
            contenedorBusquedayAgrPrestamo.Name = "contenedorBusquedayAgrPrestamo";
            contenedorBusquedayAgrPrestamo.RowCount = 1;
            contenedorBusquedayAgrPrestamo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contenedorBusquedayAgrPrestamo.Size = new Size(864, 30);
            contenedorBusquedayAgrPrestamo.TabIndex = 9;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(347, 2);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(166, 23);
            dtpFecha.TabIndex = 33;
            dtpFecha.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 28;
            label1.Text = "Ver opciones de informes:";
            // 
            // btnAgregarPrestamo
            // 
            btnAgregarPrestamo.Anchor = AnchorStyles.Right;
            btnAgregarPrestamo.AutoSize = true;
            btnAgregarPrestamo.BackColor = Color.FromArgb(32, 41, 64);
            btnAgregarPrestamo.BackgroundImageLayout = ImageLayout.None;
            btnAgregarPrestamo.ForeColor = SystemColors.Control;
            btnAgregarPrestamo.Location = new Point(739, 2);
            btnAgregarPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            btnAgregarPrestamo.Size = new Size(122, 26);
            btnAgregarPrestamo.TabIndex = 23;
            btnAgregarPrestamo.Text = "Agregar Prestamo";
            btnAgregarPrestamo.UseVisualStyleBackColor = false;
            btnAgregarPrestamo.Click += btnAgregarPrestamo_Click;
            // 
            // cmbVistasPrestamos
            // 
            cmbVistasPrestamos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVistasPrestamos.FormattingEnabled = true;
            cmbVistasPrestamos.Items.AddRange(new object[] { "[Selecciona una opción]", "Todos los Péstamos", "Préstamos por día", "Préstamos con multa", "Prestamos retrasados" });
            cmbVistasPrestamos.Location = new Point(175, 3);
            cmbVistasPrestamos.Name = "cmbVistasPrestamos";
            cmbVistasPrestamos.Size = new Size(166, 23);
            cmbVistasPrestamos.TabIndex = 29;
            cmbVistasPrestamos.SelectedValueChanged += on_changed;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Right;
            btnConsultar.AutoSize = true;
            btnConsultar.BackColor = Color.FromArgb(32, 41, 64);
            btnConsultar.BackgroundImageLayout = ImageLayout.None;
            btnConsultar.ForeColor = SystemColors.Control;
            btnConsultar.Location = new Point(563, 2);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(122, 26);
            btnConsultar.TabIndex = 34;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += on_Consultar;
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
            dGVPrestamos.Location = new Point(20, 59);
            dGVPrestamos.Margin = new Padding(3, 2, 3, 2);
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
            dGVPrestamos.Size = new Size(864, 271);
            dGVPrestamos.TabIndex = 31;
            dGVPrestamos.CellDoubleClick += dtPrestamos_CellDoubleClick;
            // 
            // btnDatosLectores
            // 
            btnDatosLectores.AutoSize = true;
            btnDatosLectores.BackColor = Color.FromArgb(32, 41, 64);
            btnDatosLectores.ForeColor = SystemColors.Control;
            btnDatosLectores.Location = new Point(740, 350);
            btnDatosLectores.Margin = new Padding(3, 2, 3, 2);
            btnDatosLectores.Name = "btnDatosLectores";
            btnDatosLectores.Size = new Size(144, 35);
            btnDatosLectores.TabIndex = 32;
            btnDatosLectores.Text = "Datos del prestamo";
            btnDatosLectores.UseVisualStyleBackColor = false;
            btnDatosLectores.Click += btnDatosLectores_Click;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(20, 358);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(411, 23);
            txtNombre.TabIndex = 59;
            // 
            // FrmPrestamosHechos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(905, 402);
            Controls.Add(txtNombre);
            Controls.Add(btnDatosLectores);
            Controls.Add(dGVPrestamos);
            Controls.Add(contenedorBusquedayAgrPrestamo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnConsultar;
    }
}