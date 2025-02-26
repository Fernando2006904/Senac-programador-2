namespace Login
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
            textboxsenha = new TextBox();
            button1 = new Button();
            textboxusuario = new TextBox();
            Cadastro = new Label();
            label2 = new Label();
            label3 = new Label();
            button = new Button();
            labelresultado = new Label();
            SuspendLayout();
            // 
            // textboxsenha
            // 
            textboxsenha.Location = new Point(399, 178);
            textboxsenha.Name = "textboxsenha";
            textboxsenha.Size = new Size(144, 23);
            textboxsenha.TabIndex = 0;
            textboxsenha.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(433, 207);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 1;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textboxusuario
            // 
            textboxusuario.Location = new Point(399, 137);
            textboxusuario.Name = "textboxusuario";
            textboxusuario.Size = new Size(144, 23);
            textboxusuario.TabIndex = 2;
            textboxusuario.TextChanged += textBox2_TextChanged;
            // 
            // Cadastro
            // 
            Cadastro.AutoSize = true;
            Cadastro.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cadastro.ForeColor = SystemColors.WindowText;
            Cadastro.Location = new Point(286, 126);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(107, 96);
            Cadastro.TabIndex = 3;
            Cadastro.Text = "Cadastro\r\n\r\n\r\n";
            Cadastro.Click += Cadastro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(313, 169);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HotTrack;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(414, 68);
            label3.Name = "label3";
            label3.Size = new Size(113, 50);
            label3.TabIndex = 5;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // button
            // 
            button.Location = new Point(414, 246);
            button.Name = "button";
            button.Size = new Size(110, 35);
            button.TabIndex = 6;
            button.Text = "Esqueci a senha";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(606, 145);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(38, 15);
            labelresultado.TabIndex = 7;
            labelresultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(940, 617);
            Controls.Add(labelresultado);
            Controls.Add(button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cadastro);
            Controls.Add(textboxusuario);
            Controls.Add(button1);
            Controls.Add(textboxsenha);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "FormLogin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxsenha;
        private Button button1;
        private TextBox textBox2;
        private Label Cadastro;
        private Label label2;
        private Label label3;
        private Button button;
        private TextBox textboxusuario;
        private Label labelresultado;
    }
}
