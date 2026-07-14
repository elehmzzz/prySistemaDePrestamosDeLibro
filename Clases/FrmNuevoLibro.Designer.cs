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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
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
            panel4 = new Panel();
            label8 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 41, 64);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 391);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Location = new Point(116, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 392);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 223, 204);
            panel3.Controls.Add(buttonRegistrar);
            panel3.Controls.Add(buttonCancelar);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(textCategoria);
            panel3.Controls.Add(textejemplares);
            panel3.Controls.Add(textISBN);
            panel3.Controls.Add(textAutor);
            panel3.Controls.Add(textTitulo);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(111, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 391);
            panel3.TabIndex = 1;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.FromArgb(0, 64, 96);
            buttonRegistrar.ForeColor = SystemColors.ButtonFace;
            buttonRegistrar.Location = new Point(550, 319);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(86, 35);
            buttonRegistrar.TabIndex = 14;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(0, 64, 96);
            buttonCancelar.ForeColor = SystemColors.ButtonFace;
            buttonCancelar.Location = new Point(426, 319);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(86, 35);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(151, 315);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(151, 267);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(152, 23);
            textCategoria.TabIndex = 11;
            // 
            // textejemplares
            // 
            textejemplares.Location = new Point(151, 218);
            textejemplares.Name = "textejemplares";
            textejemplares.Size = new Size(152, 23);
            textejemplares.TabIndex = 10;
            // 
            // textISBN
            // 
            textISBN.Location = new Point(151, 171);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(152, 23);
            textISBN.TabIndex = 9;
            // 
            // textAutor
            // 
            textAutor.Location = new Point(151, 118);
            textAutor.Name = "textAutor";
            textAutor.Size = new Size(152, 23);
            textAutor.TabIndex = 8;
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(151, 61);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(152, 23);
            textTitulo.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(34, 319);
            label7.Name = "label7";
            label7.Size = new Size(117, 19);
            label7.TabIndex = 6;
            label7.Text = "Fecha de registro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(34, 271);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 5;
            label6.Text = "Categoria";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(34, 222);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 4;
            label5.Text = "Ejemplares:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(37, 175);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 3;
            label4.Text = "ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(34, 122);
            label3.Name = "label3";
            label3.Size = new Size(47, 19);
            label3.TabIndex = 2;
            label3.Text = "Autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(32, 65);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 1;
            label2.Text = "Titulo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingresa los datos del libro a registrar";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(92, 109, 152);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(103, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(698, 59);
            panel4.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(29, 9);
            label8.Name = "label8";
            label8.Size = new Size(224, 37);
            label8.TabIndex = 0;
            label8.Text = "Registro de libros";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(12, 41, 64);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(110, 59);
            panel5.TabIndex = 3;
            // 
            // FrmNuevoLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmNuevoLibro";
            Text = "FrmNuevoLibro";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
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
    }
}