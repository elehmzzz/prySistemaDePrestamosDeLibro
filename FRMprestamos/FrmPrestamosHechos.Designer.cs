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
            dataGridView1 = new DataGridView();
            rbAlfabetico = new RadioButton();
            label1 = new Label();
            txtBuscador = new TextBox();
            radioButton1 = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Estadi = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Estadi, Column5 });
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1007, 366);
            dataGridView1.TabIndex = 8;
            // 
            // rbAlfabetico
            // 
            rbAlfabetico.AutoSize = true;
            rbAlfabetico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAlfabetico.Location = new Point(241, 58);
            rbAlfabetico.Name = "rbAlfabetico";
            rbAlfabetico.Size = new Size(100, 32);
            rbAlfabetico.TabIndex = 6;
            rbAlfabetico.TabStop = true;
            rbAlfabetico.Text = "Vigente";
            rbAlfabetico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(241, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 3;
            label1.Text = "Organizado por:";
            // 
            // txtBuscador
            // 
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(3, 3);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(232, 27);
            txtBuscador.TabIndex = 1;
            txtBuscador.Text = "Busar...";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(479, 58);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 32);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Vencido";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(radioButton1, 2, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(rbAlfabetico, 1, 1);
            tableLayoutPanel1.Controls.Add(txtBuscador, 0, 0);
            tableLayoutPanel1.Location = new Point(70, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(714, 110);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Prestamo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Lector";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Libro";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fecha Limite";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Estadi
            // 
            Estadi.HeaderText = "Estado";
            Estadi.MinimumWidth = 6;
            Estadi.Name = "Estadi";
            // 
            // Column5
            // 
            Column5.HeaderText = "Ver más..";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // FrmPrestamosHechos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1034, 536);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmPrestamosHechos";
            Text = "FrmPrestamosHechos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private RadioButton rbAlfabetico;
        private Label label1;
        private TextBox txtBuscador;
        private RadioButton radioButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Estadi;
        private DataGridViewLinkColumn Column5;
    }
}