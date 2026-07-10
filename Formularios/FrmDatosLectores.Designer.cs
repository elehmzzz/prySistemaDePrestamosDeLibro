namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmDatosLectores
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
            panel1 = new Panel();
            panel2 = new Panel();
            label14 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            btnRegresar = new Button();
            btnEditar = new Button();
            label6 = new Label();
            txtCalle = new TextBox();
            label7 = new Label();
            txtMunicipio = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            txtNombreCompleto = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtIdLector = new TextBox();
            txtPrestamosActuales = new TextBox();
            txtCP = new TextBox();
            cmbEscuela = new ComboBox();
            cmbOcupacion = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 41, 64);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 648);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 41, 64);
            panel2.Controls.Add(label14);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(110, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 65);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 6);
            label14.Name = "label14";
            label14.Size = new Size(345, 54);
            label14.TabIndex = 1;
            label14.Text = "Datos Personales";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 12F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(319, 140);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(215, 34);
            dtpFechaNacimiento.TabIndex = 41;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(545, 442);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(184, 38);
            btnRegresar.TabIndex = 40;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = true;
            btnEditar.BackColor = Color.FromArgb(32, 41, 64);
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(735, 442);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(184, 38);
            btnEditar.TabIndex = 39;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(255, 447);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 37;
            label6.Text = "Calle:";
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Segoe UI", 12F);
            txtCalle.Location = new Point(319, 444);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(215, 34);
            txtCalle.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(209, 386);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 35;
            label7.Text = "Municipio:";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Font = new Font("Segoe UI", 12F);
            txtMunicipio.Location = new Point(319, 386);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(215, 34);
            txtMunicipio.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(215, 328);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 33;
            label4.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(319, 328);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(215, 34);
            txtDireccion.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(223, 261);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 31;
            label3.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(319, 261);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 34);
            txtTelefono.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(253, 201);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 29;
            label2.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 12F);
            txtEdad.Location = new Point(319, 201);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(215, 34);
            txtEdad.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(122, 145);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 27;
            label1.Text = "Fecha de nacimiento";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(231, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 34);
            textBox2.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(135, 86);
            label5.Name = "label5";
            label5.Size = new Size(178, 28);
            label5.TabIndex = 25;
            label5.Text = "Nombre completo:";
            label5.Click += label5_Click;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 12F);
            txtNombreCompleto.Location = new Point(319, 83);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(215, 34);
            txtNombreCompleto.TabIndex = 26;
            txtNombreCompleto.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(643, 92);
            label8.Name = "label8";
            label8.Size = new Size(43, 28);
            label8.TabIndex = 42;
            label8.Text = "C.P:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(607, 146);
            label9.Name = "label9";
            label9.Size = new Size(79, 28);
            label9.TabIndex = 43;
            label9.Text = "Escuela:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(576, 201);
            label10.Name = "label10";
            label10.Size = new Size(110, 28);
            label10.TabIndex = 44;
            label10.Text = "Ocupación:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(576, 331);
            label11.Name = "label11";
            label11.Size = new Size(92, 28);
            label11.TabIndex = 45;
            label11.Text = "Id Lector:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(650, 267);
            label12.Name = "label12";
            label12.Size = new Size(217, 28);
            label12.TabIndex = 46;
            label12.Text = "Información Academica";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(557, 386);
            label13.Name = "label13";
            label13.Size = new Size(184, 28);
            label13.TabIndex = 47;
            label13.Text = "Prestamos Actuales:";
            // 
            // txtIdLector
            // 
            txtIdLector.Font = new Font("Segoe UI", 12F);
            txtIdLector.Location = new Point(674, 328);
            txtIdLector.Name = "txtIdLector";
            txtIdLector.Size = new Size(246, 34);
            txtIdLector.TabIndex = 49;
            // 
            // txtPrestamosActuales
            // 
            txtPrestamosActuales.Font = new Font("Segoe UI", 12F);
            txtPrestamosActuales.Location = new Point(747, 383);
            txtPrestamosActuales.Name = "txtPrestamosActuales";
            txtPrestamosActuales.Size = new Size(173, 34);
            txtPrestamosActuales.TabIndex = 50;
            txtPrestamosActuales.TextChanged += textBox1_TextChanged_1;
            // 
            // txtCP
            // 
            txtCP.Font = new Font("Segoe UI", 12F);
            txtCP.Location = new Point(704, 89);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(216, 34);
            txtCP.TabIndex = 51;
            // 
            // cmbEscuela
            // 
            cmbEscuela.FormattingEnabled = true;
            cmbEscuela.Items.AddRange(new object[] { "UTHH", "UAECH", "CBTA", "CECYT" });
            cmbEscuela.Location = new Point(704, 149);
            cmbEscuela.Name = "cmbEscuela";
            cmbEscuela.Size = new Size(215, 28);
            cmbEscuela.TabIndex = 52;
            // 
            // cmbOcupacion
            // 
            cmbOcupacion.FormattingEnabled = true;
            cmbOcupacion.Items.AddRange(new object[] { "Alumno", "Maestro", "Profesionista" });
            cmbOcupacion.Location = new Point(705, 201);
            cmbOcupacion.Name = "cmbOcupacion";
            cmbOcupacion.Size = new Size(215, 28);
            cmbOcupacion.TabIndex = 53;
            // 
            // FrmDatosLectores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1274, 648);
            Controls.Add(cmbOcupacion);
            Controls.Add(cmbEscuela);
            Controls.Add(txtCP);
            Controls.Add(txtPrestamosActuales);
            Controls.Add(txtIdLector);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(btnRegresar);
            Controls.Add(btnEditar);
            Controls.Add(label6);
            Controls.Add(txtCalle);
            Controls.Add(label7);
            Controls.Add(txtMunicipio);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtEdad);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(txtNombreCompleto);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDatosLectores";
            Text = "FrmDatosLectores";
            Load += FrmDatosLectores_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnRegresar;
        private Button btnEditar;
        private Label label6;
        private TextBox txtCalle;
        private Label label7;
        private TextBox txtMunicipio;
        private Label label4;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtEdad;
        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private TextBox txtNombreCompleto;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtIdLector;
        private TextBox txtPrestamosActuales;
        private TextBox txtCP;
        private ComboBox cmbEscuela;
        private ComboBox cmbOcupacion;
        private Label label14;
    }
}