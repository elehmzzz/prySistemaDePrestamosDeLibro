namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmEditarLectores
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
            cmbOcupacion = new ComboBox();
            cmbEscuela = new ComboBox();
            txtCP = new TextBox();
            txtIdLector = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            btnCancelar = new Button();
            btnGuardar = new Button();
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
            txtNombres = new TextBox();
            textBox1 = new TextBox();
            label12 = new Label();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            textBox3 = new TextBox();
            label13 = new Label();
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
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 6);
            label14.Name = "label14";
            label14.Size = new Size(488, 54);
            label14.TabIndex = 2;
            label14.Text = "Editar Registro de Lector";
            // 
            // cmbOcupacion
            // 
            cmbOcupacion.FormattingEnabled = true;
            cmbOcupacion.Items.AddRange(new object[] { "Alumno", "Maestro", "Profesionista" });
            cmbOcupacion.Location = new Point(708, 371);
            cmbOcupacion.Name = "cmbOcupacion";
            cmbOcupacion.Size = new Size(215, 28);
            cmbOcupacion.TabIndex = 81;
            // 
            // cmbEscuela
            // 
            cmbEscuela.FormattingEnabled = true;
            cmbEscuela.Items.AddRange(new object[] { "UTHH", "UAECH", "CBTA", "CECYT" });
            cmbEscuela.Location = new Point(708, 328);
            cmbEscuela.Name = "cmbEscuela";
            cmbEscuela.Size = new Size(215, 28);
            cmbEscuela.TabIndex = 80;
            cmbEscuela.SelectedIndexChanged += cmbEscuela_SelectedIndexChanged;
            // 
            // txtCP
            // 
            txtCP.Font = new Font("Segoe UI", 12F);
            txtCP.Location = new Point(708, 227);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(216, 34);
            txtCP.TabIndex = 79;
            // 
            // txtIdLector
            // 
            txtIdLector.Font = new Font("Segoe UI", 12F);
            txtIdLector.Location = new Point(312, 88);
            txtIdLector.Name = "txtIdLector";
            txtIdLector.Size = new Size(215, 34);
            txtIdLector.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(214, 91);
            label11.Name = "label11";
            label11.Size = new Size(92, 28);
            label11.TabIndex = 74;
            label11.Text = "Id Lector:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(592, 371);
            label10.Name = "label10";
            label10.Size = new Size(110, 28);
            label10.TabIndex = 73;
            label10.Text = "Ocupación:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(622, 328);
            label9.Name = "label9";
            label9.Size = new Size(79, 28);
            label9.TabIndex = 72;
            label9.Text = "Escuela:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(659, 233);
            label8.Name = "label8";
            label8.Size = new Size(43, 28);
            label8.TabIndex = 71;
            label8.Text = "C.P:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 12F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(312, 308);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(215, 34);
            dtpFechaNacimiento.TabIndex = 70;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.FromArgb(32, 41, 64);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(301, 443);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(184, 38);
            btnCancelar.TabIndex = 69;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.FromArgb(32, 41, 64);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(523, 443);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(184, 38);
            btnGuardar.TabIndex = 68;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(645, 137);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 66;
            label6.Text = "Calle:";
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Segoe UI", 12F);
            txtCalle.Location = new Point(709, 133);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(215, 34);
            txtCalle.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(598, 184);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 64;
            label7.Text = "Municipio:";
            // 
            // txtMunicipio
            // 
            txtMunicipio.Font = new Font("Segoe UI", 12F);
            txtMunicipio.Location = new Point(708, 178);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(215, 34);
            txtMunicipio.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(604, 91);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 62;
            label4.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F);
            txtDireccion.Location = new Point(708, 88);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(215, 34);
            txtDireccion.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(611, 284);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 60;
            label3.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(708, 278);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 34);
            txtTelefono.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(246, 367);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 58;
            label2.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 12F);
            txtEdad.Location = new Point(312, 364);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(215, 34);
            txtEdad.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(115, 314);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 56;
            label1.Text = "Fecha de nacimiento";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(224, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 34);
            textBox2.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(209, 151);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 54;
            label5.Text = "Nombres:";
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Segoe UI", 12F);
            txtNombres.Location = new Point(312, 148);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(215, 34);
            txtNombres.TabIndex = 55;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(224, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 34);
            textBox1.TabIndex = 84;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(136, 203);
            label12.Name = "label12";
            label12.Size = new Size(170, 28);
            label12.TabIndex = 82;
            label12.Text = "Apellido Materno:";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Segoe UI", 12F);
            txtApellidoMaterno.Location = new Point(312, 200);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(215, 34);
            txtApellidoMaterno.TabIndex = 83;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Segoe UI", 12F);
            txtApellidoPaterno.Location = new Point(312, 250);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(215, 34);
            txtApellidoPaterno.TabIndex = 86;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(224, 247);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(0, 34);
            textBox3.TabIndex = 87;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(144, 253);
            label13.Name = "label13";
            label13.Size = new Size(162, 28);
            label13.TabIndex = 85;
            label13.Text = "Apellido Paterno:";
            // 
            // FrmEditarLectores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1274, 648);
            Controls.Add(textBox3);
            Controls.Add(label13);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(cmbOcupacion);
            Controls.Add(cmbEscuela);
            Controls.Add(txtCP);
            Controls.Add(txtIdLector);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
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
            Controls.Add(txtNombres);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmEditarLectores";
            Text = "FrmEditarLectores";
            Load += FrmEditarLectores_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox cmbOcupacion;
        private ComboBox cmbEscuela;
        private TextBox txtCP;
        private TextBox txtIdLector;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnCancelar;
        private Button btnGuardar;
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
        private TextBox txtNombres;
        private Label label14;
        private TextBox textBox1;
        private Label label12;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox textBox3;
        private Label label13;
    }
}