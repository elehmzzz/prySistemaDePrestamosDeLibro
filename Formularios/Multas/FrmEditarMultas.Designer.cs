namespace prySistemaDePrestamosDeLibro.Formularios.Multas
{
    partial class FrmEditarMultas
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
            txtDiasTolerancia = new TextBox();
            label14 = new Label();
            label6 = new Label();
            txtBloqueoMaximo = new TextBox();
            label5 = new Label();
            txtBloqueoPorRetraso = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
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
            tableLayoutPanel1.Controls.Add(txtDiasTolerancia, 1, 0);
            tableLayoutPanel1.Controls.Add(label14, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(txtBloqueoMaximo, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(txtBloqueoPorRetraso, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 2, 1);
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 6);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(36, 156);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853088F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285306F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853088F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881632F));
            tableLayoutPanel1.Size = new Size(821, 367);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // txtDiasTolerancia
            // 
            txtDiasTolerancia.Location = new Point(222, 6);
            txtDiasTolerancia.Margin = new Padding(6);
            txtDiasTolerancia.Name = "txtDiasTolerancia";
            txtDiasTolerancia.Size = new Size(232, 34);
            txtDiasTolerancia.TabIndex = 84;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 0);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(171, 28);
            label14.TabIndex = 83;
            label14.Text = "Días de tolerancia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 104);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(164, 28);
            label6.TabIndex = 5;
            label6.Text = "Bloqueo máximo:";
            // 
            // txtBloqueoMaximo
            // 
            txtBloqueoMaximo.Location = new Point(222, 110);
            txtBloqueoMaximo.Margin = new Padding(6);
            txtBloqueoMaximo.Name = "txtBloqueoMaximo";
            txtBloqueoMaximo.Size = new Size(232, 34);
            txtBloqueoMaximo.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 52);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(191, 28);
            label5.TabIndex = 4;
            label5.Text = "Bloqueo por retraso:";
            // 
            // txtBloqueoPorRetraso
            // 
            txtBloqueoPorRetraso.Location = new Point(222, 58);
            txtBloqueoPorRetraso.Margin = new Padding(6);
            txtBloqueoPorRetraso.Name = "txtBloqueoPorRetraso";
            txtBloqueoPorRetraso.Size = new Size(232, 34);
            txtBloqueoPorRetraso.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Location = new Point(466, 52);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(314, 28);
            label1.TabIndex = 85;
            label1.Text = "días de bloqueo por día de retraso";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(36, 13);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(644, 110);
            tableLayoutPanel2.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 0);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(387, 46);
            label4.TabIndex = 3;
            label4.Text = "Configuración de Multas";
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.FromArgb(32, 41, 64);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(869, 474);
            btnGuardar.Margin = new Padding(6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(129, 38);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.FromArgb(32, 41, 64);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(622, 318);
            btnCancelar.Margin = new Padding(6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 38);
            btnCancelar.TabIndex = 86;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmEditarMultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1034, 536);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarMultas";
            Text = "FrmEditarMultas";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDiasTolerancia;
        private Label label14;
        private Label label6;
        private TextBox txtBloqueoMaximo;
        private Label label5;
        private TextBox txtBloqueoPorRetraso;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
    }
}