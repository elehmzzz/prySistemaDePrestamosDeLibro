namespace prySistemaDePrestamosDeLibro.Formularios
{
    partial class FrmDatosUsuario
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label7 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            txtUsuario = new TextBox();
            label6 = new Label();
            txtContrasenia = new TextBox();
            label1 = new Label();
            txtConfirmarContrasenia = new TextBox();
            btnRegresar = new Button();
            btnSiguiente = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label7, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Location = new Point(19, 18);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(712, 133);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // label7
            // 
            label7.Location = new Point(4, 46);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(632, 56);
            label7.TabIndex = 9;
            label7.Text = "Ingresa un nombre de usuario y crea tu contraseña.\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(308, 46);
            label4.TabIndex = 3;
            label4.Text = "Registro de usuario";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.05162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.94838F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(txtUsuario, 1, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(txtContrasenia, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(txtConfirmarContrasenia, 1, 2);
            tableLayoutPanel1.Location = new Point(19, 168);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.Size = new Size(833, 188);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 4;
            label5.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(246, 4);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(238, 34);
            txtUsuario.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 62);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 5;
            label6.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(246, 66);
            txtContrasenia.Margin = new Padding(4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(238, 34);
            txtContrasenia.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 28;
            label1.Text = "Confirma contraseña:";
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.Location = new Point(246, 128);
            txtConfirmarContrasenia.Margin = new Padding(4);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.PasswordChar = '*';
            txtConfirmarContrasenia.Size = new Size(238, 34);
            txtConfirmarContrasenia.TabIndex = 29;
            // 
            // btnRegresar
            // 
            btnRegresar.AutoSize = true;
            btnRegresar.BackColor = Color.FromArgb(32, 41, 64);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(4, 4);
            btnRegresar.Margin = new Padding(4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(117, 42);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoSize = true;
            btnSiguiente.BackColor = Color.FromArgb(32, 41, 64);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(153, 4);
            btnSiguiente.Margin = new Padding(4);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(117, 42);
            btnSiguiente.TabIndex = 27;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnRegresar, 0, 0);
            tableLayoutPanel3.Controls.Add(btnSiguiente, 1, 0);
            tableLayoutPanel3.Location = new Point(554, 469);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(298, 56);
            tableLayoutPanel3.TabIndex = 28;
            // 
            // FrmDatosUsuario
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1052, 583);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmDatosUsuario";
            Text = "FrmRegistroUsuario";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private TextBox txtUsuario;
        private Label label6;
        private TextBox txtContrasenia;
        private Button btnRegresar;
        private Button btnSiguiente;
        private Label label1;
        private TextBox txtConfirmarContrasenia;
        private TableLayoutPanel tableLayoutPanel3;
    }
}