namespace prySistemaDePrestamosDeLibro.Formularios.Libros
{
    partial class FrmAgregarEditorial
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblEditorial = new Label();
            txtEditorial = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9946957F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.0053F));
            tableLayoutPanel1.Controls.Add(lblEditorial, 0, 0);
            tableLayoutPanel1.Controls.Add(txtEditorial, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(403, 59);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(4, 0);
            lblEditorial.Margin = new Padding(4, 0, 4, 0);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(68, 20);
            lblEditorial.TabIndex = 3;
            lblEditorial.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(108, 4);
            txtEditorial.Margin = new Padding(4);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(283, 27);
            txtEditorial.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(261, 118);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 38);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.AutoSize = true;
            btnGuardar.Location = new Point(343, 118);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(72, 38);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAgregarEditorial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(439, 168);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarEditorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Editorial ";
            Load += FrmAgregarEditorial_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblEditorial;
        private TextBox txtEditorial;
        private Button btnCancelar;
        private Button button2;
        private Button btnGuardar;
    }
}