namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmNuevoLibro
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
            panel3 = new Panel();
            textBoxEditorial = new TextBox();
            Editorial = new Label();
            buttonRegistrar = new Button();
            buttonCancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            textCategoria = new TextBox();
            textejemplares = new TextBox();
            textISBN = new TextBox();
            textAutor = new TextBox();
            textTitulo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Location = new Point(-3, -5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1052, 583);
            panel3.TabIndex = 1;
            // 
            // textBoxEditorial
            // 
            textBoxEditorial.Location = new Point(198, 281);
            textBoxEditorial.Name = "textBoxEditorial";
            textBoxEditorial.Size = new Size(232, 29);
            textBoxEditorial.TabIndex = 16;
            // 
            // Editorial
            // 
            Editorial.AutoSize = true;
            Editorial.Font = new Font("Segoe UI", 12F);
            Editorial.Location = new Point(3, 278);
            Editorial.Name = "Editorial";
            Editorial.Size = new Size(70, 21);
            Editorial.TabIndex = 15;
            Editorial.Text = "Editorial:";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.FromArgb(32, 41, 64);
            buttonRegistrar.ForeColor = Color.White;
            buttonRegistrar.Location = new Point(683, 281);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(133, 48);
            buttonRegistrar.TabIndex = 14;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(32, 41, 64);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(476, 281);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(133, 48);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(476, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 29);
            dateTimePicker1.TabIndex = 12;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(198, 227);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(232, 29);
            textCategoria.TabIndex = 11;
            // 
            // textejemplares
            // 
            textejemplares.Location = new Point(198, 176);
            textejemplares.Name = "textejemplares";
            textejemplares.Size = new Size(232, 29);
            textejemplares.TabIndex = 10;
            // 
            // textISBN
            // 
            textISBN.Location = new Point(198, 117);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(232, 29);
            textISBN.TabIndex = 9;
            // 
            // textAutor
            // 
            textAutor.Location = new Point(198, 60);
            textAutor.Name = "textAutor";
            textAutor.Size = new Size(232, 29);
            textAutor.TabIndex = 8;
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(198, 3);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(232, 29);
            textTitulo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(476, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 21);
            label7.TabIndex = 6;
            label7.Text = "Fecha de registro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 224);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 5;
            label6.Text = "Categoria";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 173);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 4;
            label5.Text = "Ejemplares:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 3;
            label4.Text = "ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Titulo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 55);
            label1.Name = "label1";
            label1.Size = new Size(263, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingresa los datos del libro a registrar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(224, 37);
            label8.TabIndex = 0;
            label8.Text = "Registro de libros";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.1885262F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.8114738F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 207F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonCancelar, 2, 5);
            tableLayoutPanel1.Controls.Add(buttonRegistrar, 3, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(Editorial, 0, 5);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label7, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(textCategoria, 1, 4);
            tableLayoutPanel1.Controls.Add(textTitulo, 1, 0);
            tableLayoutPanel1.Controls.Add(textAutor, 1, 1);
            tableLayoutPanel1.Controls.Add(textISBN, 1, 2);
            tableLayoutPanel1.Controls.Add(textejemplares, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxEditorial, 1, 5);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel1.Location = new Point(31, 179);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel1.Size = new Size(831, 332);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Location = new Point(31, 17);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(644, 110);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // FrmNuevoLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 544);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmNuevoLibro";
            Text = "FrmNuevoLibro";
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textTitulo;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox textCategoria;
        private TextBox textejemplares;
        private TextBox textISBN;
        private TextBox textAutor;
        private Button buttonRegistrar;
        private Button buttonCancelar;
        private Label Editorial;
        private TextBox textBoxEditorial;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}