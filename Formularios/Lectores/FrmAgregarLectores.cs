using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaDePrestamosDeLibro.Formularios.Lectores
{
    public partial class FrmAgregarLectores : Form
    {
        public FrmAgregarLectores()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAgregarLectores_Load(object sender, EventArgs e)
        {

        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            txtApellidoPat = new TextBox();
            label1 = new Label();
            txtApellidoMat = new TextBox();
            label2 = new Label();
            btnRegresar = new Button();
            btnSiguiente = new Button();
            label3 = new Label();
            txtEdad = new TextBox();
            dtpFechaNac = new DateTimePicker();
            label9 = new Label();
            txtLocalidad = new TextBox();
            label10 = new Label();
            txtCP = new TextBox();
            label11 = new Label();
            txtTelefono = new TextBox();
            label12 = new Label();
            cmbEscuela = new ComboBox();
            label13 = new Label();
            cmbOcupacion = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.39675F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.73479F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0414143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8270473F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(txtApellidoPat, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(txtApellidoMat, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(btnRegresar, 2, 5);
            tableLayoutPanel1.Controls.Add(btnSiguiente, 3, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEdad, 1, 4);
            tableLayoutPanel1.Controls.Add(dtpFechaNac, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(txtLocalidad, 1, 5);
            tableLayoutPanel1.Controls.Add(label10, 2, 0);
            tableLayoutPanel1.Controls.Add(txtCP, 3, 0);
            tableLayoutPanel1.Controls.Add(label11, 2, 1);
            tableLayoutPanel1.Controls.Add(txtTelefono, 3, 1);
            tableLayoutPanel1.Controls.Add(label12, 2, 3);
            tableLayoutPanel1.Controls.Add(label13, 2, 2);
            tableLayoutPanel1.Controls.Add(cmbEscuela, 3, 3);
            tableLayoutPanel1.Controls.Add(cmbOcupacion, 3, 2);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(15, 158);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(821, 367);
            tableLayoutPanel1.TabIndex = 29;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 0);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 4;
            label5.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(222, 6);
            txtNombre.Margin = new Padding(6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 34);
            txtNombre.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 61);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 28);
            label6.TabIndex = 5;
            label6.Text = "Apellido parterno:";
            // 
            // txtApellidoPat
            // 
            txtApellidoPat.Location = new Point(222, 67);
            txtApellidoPat.Margin = new Padding(6);
            txtApellidoPat.Name = "txtApellidoPat";
            txtApellidoPat.Size = new Size(232, 34);
            txtApellidoPat.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 122);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 28;
            label1.Text = "Apellido materno:";
            // 
            // txtApellidoMat
            // 
            txtApellidoMat.Location = new Point(222, 128);
            txtApellidoMat.Margin = new Padding(6);
            txtApellidoMat.Name = "txtApellidoMat";
            txtApellidoMat.Size = new Size(232, 34);
            txtApellidoMat.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 183);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 30;
            label2.Text = "Fecha de nacimiento:";
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(466, 311);
            btnRegresar.Margin = new Padding(6);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(97, 38);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoSize = true;
            btnSiguiente.BackColor = Color.FromArgb(32, 41, 64);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(622, 311);
            btnSiguiente.Margin = new Padding(6);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(104, 38);
            btnSiguiente.TabIndex = 27;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 244);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 31;
            label3.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(222, 250);
            txtEdad.Margin = new Padding(6);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(109, 34);
            txtEdad.TabIndex = 34;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Font = new Font("Segoe UI", 12F);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(219, 186);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(232, 34);
            dtpFechaNac.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 305);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 36;
            label9.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(222, 311);
            txtLocalidad.Margin = new Padding(6);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(229, 34);
            txtLocalidad.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(466, 0);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 28);
            label10.TabIndex = 37;
            label10.Text = "C.P:";
            // 
            // txtCP
            // 
            txtCP.Location = new Point(622, 6);
            txtCP.Margin = new Padding(6);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(193, 34);
            txtCP.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(466, 61);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(90, 28);
            label11.TabIndex = 38;
            label11.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(622, 67);
            txtTelefono.Margin = new Padding(6);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(193, 34);
            txtTelefono.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(466, 183);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(79, 28);
            label12.TabIndex = 39;
            label12.Text = "Escuela:";
            // 
            // cmbEscuela
            // 
            cmbEscuela.FormattingEnabled = true;
            cmbEscuela.Items.AddRange(new object[] { "UTHH", "UAECH", "CBTA", "CECYT" });
            cmbEscuela.Location = new Point(619, 186);
            cmbEscuela.Name = "cmbEscuela";
            cmbEscuela.Size = new Size(193, 36);
            cmbEscuela.TabIndex = 81;
            cmbEscuela.SelectedIndexChanged += cmbEscuela_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(466, 122);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(110, 28);
            label13.TabIndex = 43;
            label13.Text = "Ocupación:";
            // 
            // cmbOcupacion
            // 
            cmbOcupacion.FormattingEnabled = true;
            cmbOcupacion.Items.AddRange(new object[] { "Alumno", "Maestro", "Profesionista" });
            cmbOcupacion.Location = new Point(619, 125);
            cmbOcupacion.Name = "cmbOcupacion";
            cmbOcupacion.Size = new Size(199, 36);
            cmbOcupacion.TabIndex = 82;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 1);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(15, 15);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(644, 110);
            tableLayoutPanel2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 0);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(293, 46);
            label4.TabIndex = 3;
            label4.Text = "Registro de Lector";
            // 
            // label7
            // 
            label7.Location = new Point(6, 46);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(632, 78);
            label7.TabIndex = 9;
            label7.Text = "Ingresa tus datos personales y da click en siguiente.";
            // 
            // FrmAgregarLectores
            // 
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1052, 583);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregarLectores";
            Load += FrmAgregarLectores_Load_2;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);


        }

        private void FrmAgregarLectores_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmAgregarLectores_Load_2(object sender, EventArgs e)
        {

        }
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTelefono;
        private TextBox txtCP;
        private TextBox txtLocalidad;
        private Label label9;
        private Label label5;
        private TextBox txtNombre;
        private Label label6;
        private TextBox txtApellidoPat;
        private Label label1;
        private TextBox txtApellidoMat;
        private Label label2;
        private Button btnRegresar;
        private Button btnSiguiente;
        private Label label3;
        private TextBox txtEdad;
        private Label label10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label7;
        private DateTimePicker dtpFechaNac;
        private Label label12;
        private Label label13;
        private ComboBox cmbEscuela;
        private ComboBox cmbOcupacion;

        private void cmbEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
