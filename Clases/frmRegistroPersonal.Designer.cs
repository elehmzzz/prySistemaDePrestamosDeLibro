namespace prySistemaDePrestamosDeLibro.Clases
{
    partial class frmRegistroPersonal
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
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 41, 64);
            panel1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(810, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 469);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 223, 204);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 469);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 153);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 4;
            label5.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 218);
            label6.Name = "label6";
            label6.Size = new Size(164, 28);
            label6.TabIndex = 5;
            label6.Text = "Apellido paterno:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(538, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 34);
            textBox3.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 34);
            textBox1.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(199, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 34);
            textBox4.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 153);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 10;
            label1.Text = "Ciudad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 17);
            label4.Name = "label4";
            label4.Size = new Size(282, 46);
            label4.TabIndex = 3;
            label4.Text = "Registro de datos";
            // 
            // label7
            // 
            label7.Location = new Point(12, 63);
            label7.Name = "label7";
            label7.Size = new Size(469, 40);
            label7.TabIndex = 9;
            label7.Text = "Ingresa tus datos personales y da click en siguiente.";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(32, 41, 64);
            button1.ForeColor = Color.White;
            button1.Location = new Point(575, 404);
            button1.Name = "button1";
            button1.Size = new Size(184, 38);
            button1.TabIndex = 6;
            button1.Text = "Iniciar sesion";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmRegistroPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 493);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRegistroPersonal";
            Text = "frmRegistroPersonal";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
    }
}