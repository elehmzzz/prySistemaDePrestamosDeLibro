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
            label5 = new Label();
            txtPenalizacion = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            btnGuardarMulta = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4137211F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.6756763F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.9106026F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txtDiasTolerancia, 1, 0);
            tableLayoutPanel1.Controls.Add(label14, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(txtPenalizacion, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 2, 1);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(15, 142);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.93617F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.06383F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(962, 94);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // txtDiasTolerancia
            // 
            txtDiasTolerancia.Enabled = false;
            txtDiasTolerancia.Location = new Point(212, 6);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 46);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 4;
            label5.Text = "Monto por retraso: $";
            // 
            // txtPenalizacion
            // 
            txtPenalizacion.Enabled = false;
            txtPenalizacion.Location = new Point(212, 52);
            txtPenalizacion.Margin = new Padding(6);
            txtPenalizacion.Name = "txtPenalizacion";
            txtPenalizacion.Size = new Size(232, 34);
            txtPenalizacion.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(459, 46);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 85;
            label1.Text = "por los dias de retraso";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(15, 15);
            tableLayoutPanel2.Margin = new Padding(6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1004, 52);
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
            // btnGuardarMulta
            // 
            btnGuardarMulta.AutoSize = true;
            btnGuardarMulta.BackColor = Color.FromArgb(32, 41, 64);
            btnGuardarMulta.ForeColor = Color.White;
            btnGuardarMulta.Location = new Point(869, 474);
            btnGuardarMulta.Margin = new Padding(6);
            btnGuardarMulta.Name = "btnGuardarMulta";
            btnGuardarMulta.Size = new Size(129, 38);
            btnGuardarMulta.TabIndex = 34;
            btnGuardarMulta.Text = "Guardar";
            btnGuardarMulta.UseVisualStyleBackColor = false;
            // 
            // FrmEditarMultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1034, 536);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(btnGuardarMulta);
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
        private Button btnGuardarMulta;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private TextBox txtPenalizacion;
    }
}