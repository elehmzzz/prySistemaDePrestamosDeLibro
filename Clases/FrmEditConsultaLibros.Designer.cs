namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class FrmEditConsultaLibros
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
            panel4 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxEDispo = new TextBox();
            textBoxETotal = new TextBox();
            textBoxCategoria = new TextBox();
            textBoxISBN = new TextBox();
            textBoxAutor = new TextBox();
            textBoxTitulo = new TextBox();
            textBoxID = new TextBox();
            Aceptar = new Button();
            Cancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Font = new Font("Segoe UI", 10F);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1038, 546);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(434, 0);
            label8.Name = "label8";
            label8.Size = new Size(136, 21);
            label8.TabIndex = 17;
            label8.Text = "Fecha de Registro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 295);
            label7.Name = "label7";
            label7.Size = new Size(174, 21);
            label7.TabIndex = 16;
            label7.Text = " Ejemplares Disponbles:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 239);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 15;
            label6.Text = "Ejemplares Totales:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 194);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 14;
            label5.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 141);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 13;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 12;
            label3.Text = "Autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 11;
            label2.Text = "Titulo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 21);
            label1.TabIndex = 10;
            label1.Text = "ID:";
            // 
            // textBoxEDispo
            // 
            textBoxEDispo.Location = new Point(188, 298);
            textBoxEDispo.Name = "textBoxEDispo";
            textBoxEDispo.Size = new Size(232, 29);
            textBoxEDispo.TabIndex = 9;
            // 
            // textBoxETotal
            // 
            textBoxETotal.Location = new Point(188, 242);
            textBoxETotal.Name = "textBoxETotal";
            textBoxETotal.Size = new Size(232, 29);
            textBoxETotal.TabIndex = 8;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.Location = new Point(188, 197);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(232, 29);
            textBoxCategoria.TabIndex = 7;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(188, 144);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(232, 29);
            textBoxISBN.TabIndex = 6;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(188, 94);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(232, 29);
            textBoxAutor.TabIndex = 5;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(188, 49);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(232, 29);
            textBoxTitulo.TabIndex = 4;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(188, 3);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(232, 29);
            textBoxID.TabIndex = 3;
            // 
            // Aceptar
            // 
            Aceptar.BackColor = Color.FromArgb(32, 41, 64);
            Aceptar.ForeColor = Color.White;
            Aceptar.Location = new Point(637, 298);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(181, 29);
            Aceptar.TabIndex = 2;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = false;
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.FromArgb(32, 41, 64);
            Cancelar.ForeColor = Color.White;
            Cancelar.Location = new Point(434, 298);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(133, 50);
            Cancelar.TabIndex = 1;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(434, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 29);
            dateTimePicker1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(154, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 37);
            label10.TabIndex = 1;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(127, 37);
            label9.TabIndex = 0;
            label9.Text = "Ejemplar:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.9234352F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.0765648F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 203F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 2, 1);
            tableLayoutPanel1.Controls.Add(label8, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(Aceptar, 3, 6);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(Cancelar, 2, 6);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxEDispo, 1, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxETotal, 1, 5);
            tableLayoutPanel1.Controls.Add(textBoxID, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxCategoria, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxTitulo, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxISBN, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxAutor, 1, 2);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel1.Location = new Point(29, 145);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.45045F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.54955F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel1.Size = new Size(821, 367);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label9, 0, 0);
            tableLayoutPanel2.Controls.Add(label10, 1, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 12F);
            tableLayoutPanel2.Location = new Point(29, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(302, 65);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // FrmEditConsultaLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 544);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmEditConsultaLibros";
            Text = "FrmEditConsultaLibros";
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxETotal;
        private TextBox textBoxCategoria;
        private TextBox textBoxISBN;
        private TextBox textBoxAutor;
        private TextBox textBoxTitulo;
        private TextBox textBoxID;
        private Button Aceptar;
        private Button Cancelar;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxEDispo;
        private Label label9;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}