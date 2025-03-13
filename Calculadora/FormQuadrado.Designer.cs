namespace Calculadora
{
    partial class FormQuadrado
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
            TxtLadoQuadrado = new TextBox();
            TxtLarguraRetangulo = new TextBox();
            TxtAlturaRetangulo = new TextBox();
            lblLadoQuadrado = new Label();
            lblLarguraRetangulo = new Label();
            lblAlturaRetangulo = new Label();
            lblResultado = new Label();
            BntCalcular = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LblResultadoPerímetro = new Label();
            TxtVolume1 = new TextBox();
            TxtVolume2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Resultado2 = new Label();
            SuspendLayout();
            // 
            // TxtLadoQuadrado
            // 
            TxtLadoQuadrado.BackColor = SystemColors.InactiveBorder;
            TxtLadoQuadrado.Location = new Point(310, 128);
            TxtLadoQuadrado.Name = "TxtLadoQuadrado";
            TxtLadoQuadrado.Size = new Size(171, 23);
            TxtLadoQuadrado.TabIndex = 0;
            // 
            // TxtLarguraRetangulo
            // 
            TxtLarguraRetangulo.Location = new Point(310, 169);
            TxtLarguraRetangulo.Name = "TxtLarguraRetangulo";
            TxtLarguraRetangulo.Size = new Size(171, 23);
            TxtLarguraRetangulo.TabIndex = 1;
            // 
            // TxtAlturaRetangulo
            // 
            TxtAlturaRetangulo.Location = new Point(681, 128);
            TxtAlturaRetangulo.Name = "TxtAlturaRetangulo";
            TxtAlturaRetangulo.Size = new Size(171, 23);
            TxtAlturaRetangulo.TabIndex = 2;
            // 
            // lblLadoQuadrado
            // 
            lblLadoQuadrado.AutoSize = true;
            lblLadoQuadrado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLadoQuadrado.Location = new Point(114, 126);
            lblLadoQuadrado.Name = "lblLadoQuadrado";
            lblLadoQuadrado.Size = new Size(143, 25);
            lblLadoQuadrado.TabIndex = 3;
            lblLadoQuadrado.Text = "Lado Quadrado";
            lblLadoQuadrado.Click += lblLadoQuadrado_Click;
            // 
            // lblLarguraRetangulo
            // 
            lblLarguraRetangulo.AutoSize = true;
            lblLarguraRetangulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLarguraRetangulo.Location = new Point(81, 169);
            lblLarguraRetangulo.Name = "lblLarguraRetangulo";
            lblLarguraRetangulo.Size = new Size(194, 25);
            lblLarguraRetangulo.TabIndex = 4;
            lblLarguraRetangulo.Text = "Largura do Retângulo";
            // 
            // lblAlturaRetangulo
            // 
            lblAlturaRetangulo.AutoSize = true;
            lblAlturaRetangulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlturaRetangulo.Location = new Point(495, 126);
            lblAlturaRetangulo.Name = "lblAlturaRetangulo";
            lblAlturaRetangulo.Size = new Size(180, 25);
            lblAlturaRetangulo.TabIndex = 5;
            lblAlturaRetangulo.Text = "Altura do Retângulo";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(1076, 222);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(104, 30);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // BntCalcular
            // 
            BntCalcular.Location = new Point(681, 256);
            BntCalcular.Name = "BntCalcular";
            BntCalcular.Size = new Size(171, 28);
            BntCalcular.TabIndex = 7;
            BntCalcular.Text = "Calculcar";
            BntCalcular.UseVisualStyleBackColor = true;
            BntCalcular.Click += BntCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 38);
            label1.Name = "label1";
            label1.Size = new Size(310, 32);
            label1.TabIndex = 8;
            label1.Text = "Área Quadrado e Retângulo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(681, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(310, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 164);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 11;
            label2.Text = "Perímetro Quadrado";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 208);
            label3.Name = "label3";
            label3.Size = new Size(184, 25);
            label3.TabIndex = 12;
            label3.Text = "Perímetro Retângulo";
            // 
            // LblResultadoPerímetro
            // 
            LblResultadoPerímetro.AutoSize = true;
            LblResultadoPerímetro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblResultadoPerímetro.Location = new Point(1039, 62);
            LblResultadoPerímetro.Name = "LblResultadoPerímetro";
            LblResultadoPerímetro.Size = new Size(199, 30);
            LblResultadoPerímetro.TabIndex = 13;
            LblResultadoPerímetro.Text = "Resultado Perímetro";
            LblResultadoPerímetro.Click += LblResultadoPerímetro_Click;
            // 
            // TxtVolume1
            // 
            TxtVolume1.Location = new Point(681, 213);
            TxtVolume1.Name = "TxtVolume1";
            TxtVolume1.Size = new Size(171, 23);
            TxtVolume1.TabIndex = 14;
            // 
            // TxtVolume2
            // 
            TxtVolume2.Location = new Point(310, 256);
            TxtVolume2.Name = "TxtVolume2";
            TxtVolume2.Size = new Size(171, 23);
            TxtVolume2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(495, 208);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 16;
            label4.Text = "Volume Quadrado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 251);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 17;
            label5.Text = "Volume Retângulo";
            label5.Click += label5_Click;
            // 
            // Resultado2
            // 
            Resultado2.AutoSize = true;
            Resultado2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resultado2.Location = new Point(478, 367);
            Resultado2.Name = "Resultado2";
            Resultado2.Size = new Size(131, 32);
            Resultado2.TabIndex = 18;
            Resultado2.Text = "Resultado2";
            // 
            // FormQuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1471, 450);
            Controls.Add(Resultado2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtVolume2);
            Controls.Add(TxtVolume1);
            Controls.Add(LblResultadoPerímetro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BntCalcular);
            Controls.Add(lblResultado);
            Controls.Add(lblAlturaRetangulo);
            Controls.Add(lblLarguraRetangulo);
            Controls.Add(lblLadoQuadrado);
            Controls.Add(TxtAlturaRetangulo);
            Controls.Add(TxtLarguraRetangulo);
            Controls.Add(TxtLadoQuadrado);
            Name = "FormQuadrado";
            Text = "FormQuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtLadoQuadrado;
        private TextBox TxtLarguraRetangulo;
        private TextBox TxtAlturaRetangulo;
        private Label lblLadoQuadrado;
        private Label lblLarguraRetangulo;
        private Label lblAlturaRetangulo;
        private Label lblResultado;
        private Button BntCalcular;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label LblResultadoPerímetro;
        private TextBox TxtVolume1;
        private TextBox TxtVolume2;
        private Label label4;
        private Label label5;
        private Label Resultado2;
    }
}