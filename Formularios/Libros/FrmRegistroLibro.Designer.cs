namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmRegistroLibro
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
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBuscador = new TextBox();
            btnAgregarLibro = new Button();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Location = new Point(14, 18);
            tableLayoutPanel2.Margin = new Padding(4, 6, 4, 6);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(241, 48);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(4, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 37);
            label8.TabIndex = 0;
            label8.Text = "Libros";
            label8.Click += label8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(13, 158);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1025, 215);
            dataGridView1.TabIndex = 23;
            // 
            // Column1
            // 
            Column1.FillWeight = 94.62568F;
            Column1.HeaderText = "ISBN";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 100.0257F;
            Column2.HeaderText = "Título";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 102.275726F;
            Column3.HeaderText = "Autor";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 102.968048F;
            Column4.HeaderText = "Disponibles";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Fecha de registro";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.6176472F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.3823547F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 312F));
            tableLayoutPanel1.Controls.Add(txtBuscador, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarLibro, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(18, 86);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(896, 51);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // txtBuscador
            // 
            txtBuscador.Anchor = AnchorStyles.Left;
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(188, 14);
            txtBuscador.Margin = new Padding(4);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.PlaceholderText = "Buscar";
            txtBuscador.Size = new Size(391, 22);
            txtBuscador.TabIndex = 26;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Anchor = AnchorStyles.Left;
            btnAgregarLibro.AutoSize = true;
            btnAgregarLibro.Location = new Point(587, 4);
            btnAgregarLibro.Margin = new Padding(4);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(144, 43);
            btnAgregarLibro.TabIndex = 24;
            btnAgregarLibro.Text = "Agregar libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(4, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 25;
            label2.Text = "Buscar el autor:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(12, 386);
            label3.Name = "label3";
            label3.Size = new Size(187, 21);
            label3.TabIndex = 32;
            label3.Text = "Editar autor seleccionado:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.45509F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.54491F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 233F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 275F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tableLayoutPanel3.Controls.Add(textBox4, 3, 1);
            tableLayoutPanel3.Controls.Add(label5, 2, 0);
            tableLayoutPanel3.Controls.Add(textBox3, 3, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel3.Controls.Add(label7, 2, 2);
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(label6, 2, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(label9, 0, 2);
            tableLayoutPanel3.Controls.Add(textBox5, 1, 2);
            tableLayoutPanel3.Controls.Add(textBox6, 3, 2);
            tableLayoutPanel3.Controls.Add(button2, 4, 0);
            tableLayoutPanel3.Controls.Add(button1, 4, 2);
            tableLayoutPanel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel3.Location = new Point(14, 417);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Size = new Size(1028, 137);
            tableLayoutPanel3.TabIndex = 37;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(563, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 32;
            label5.Text = "Categoria:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(563, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 29);
            textBox3.TabIndex = 38;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 29);
            textBox2.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 90);
            label7.Name = "label7";
            label7.Size = new Size(174, 21);
            label7.TabIndex = 35;
            label7.Text = " Ejemplares Disponbles:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 33;
            label1.Text = "Titulo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 45);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 34;
            label6.Text = "Ejemplares Totales:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 31;
            label4.Text = "ISBN:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 29);
            textBox1.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 90);
            label9.Name = "label9";
            label9.Size = new Size(52, 21);
            label9.TabIndex = 40;
            label9.Text = "Autor:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 93);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(235, 29);
            textBox5.TabIndex = 41;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(563, 93);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 29);
            textBox6.TabIndex = 42;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.AutoSize = true;
            button2.Location = new Point(839, 4);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(144, 37);
            button2.TabIndex = 44;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.AutoSize = true;
            button1.Location = new Point(839, 94);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(144, 38);
            button1.TabIndex = 43;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroLibro
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            ClientSize = new Size(1052, 583);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            Name = "FrmRegistroLibro";
            Text = "FrmNuevoLibro";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtBuscador;
        private Button btnAgregarLibro;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label4;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private Button button1;
    }
}