namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BotãoCalculos = new Button();
            TextBoxNúmero1 = new TextBox();
            TextBoxNúmero2 = new TextBox();
            lblresultado = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // BotãoCalculos
            // 
            BotãoCalculos.Location = new Point(315, 182);
            BotãoCalculos.Name = "BotãoCalculos";
            BotãoCalculos.Size = new Size(168, 30);
            BotãoCalculos.TabIndex = 0;
            BotãoCalculos.Text = "Soma";
            BotãoCalculos.UseVisualStyleBackColor = true;
            BotãoCalculos.Click += button1_Click;
            // 
            // TextBoxNúmero1
            // 
            TextBoxNúmero1.Location = new Point(315, 93);
            TextBoxNúmero1.Name = "TextBoxNúmero1";
            TextBoxNúmero1.Size = new Size(168, 23);
            TextBoxNúmero1.TabIndex = 1;
            TextBoxNúmero1.TextChanged += textBox1_TextChanged;
            // 
            // TextBoxNúmero2
            // 
            TextBoxNúmero2.Location = new Point(315, 135);
            TextBoxNúmero2.Name = "TextBoxNúmero2";
            TextBoxNúmero2.Size = new Size(168, 23);
            TextBoxNúmero2.TabIndex = 2;
            TextBoxNúmero2.TextChanged += textBox2_TextChanged;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(338, 350);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(118, 32);
            lblresultado.TabIndex = 3;
            lblresultado.Text = "Resultado";
            lblresultado.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 43);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 4;
            label2.Text = "Calculadora";
            // 
            // button1
            // 
            button1.Location = new Point(315, 218);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
            button1.TabIndex = 5;
            button1.Text = "Subtração";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(315, 253);
            button2.Name = "button2";
            button2.Size = new Size(168, 29);
            button2.TabIndex = 6;
            button2.Text = "Multiplicação";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(315, 288);
            button3.Name = "button3";
            button3.Size = new Size(168, 30);
            button3.TabIndex = 7;
            button3.Text = "Divisão";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblresultado);
            Controls.Add(TextBoxNúmero2);
            Controls.Add(TextBoxNúmero1);
            Controls.Add(BotãoCalculos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotãoCalculos;
        private TextBox TextBoxNúmero1;
        private TextBox TextBoxNúmero2;
        private Label lblresultado;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
