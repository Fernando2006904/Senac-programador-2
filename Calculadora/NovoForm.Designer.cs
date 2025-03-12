namespace Calculadora
{
    partial class NovoForm
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
            label1 = new Label();
            label2 = new Label();
            Lado1 = new Label();
            Lado2 = new Label();
            Lado3 = new Label();
            LabelResultarea = new Label();
            LabelResultPerímeter = new Label();
            Textbox1 = new TextBox();
            TextBox2 = new TextBox();
            txtaltura = new TextBox();
            txtbase = new TextBox();
            BntCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Base do triângulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 101);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Altura do triângulo";
            // 
            // Lado1
            // 
            Lado1.AutoSize = true;
            Lado1.Location = new Point(401, 82);
            Lado1.Name = "Lado1";
            Lado1.Size = new Size(39, 15);
            Lado1.TabIndex = 2;
            Lado1.Text = "Lado1";
            // 
            // Lado2
            // 
            Lado2.AutoSize = true;
            Lado2.Location = new Point(401, 128);
            Lado2.Name = "Lado2";
            Lado2.Size = new Size(39, 15);
            Lado2.TabIndex = 3;
            Lado2.Text = "Lado2";
            // 
            // Lado3
            // 
            Lado3.AutoSize = true;
            Lado3.Location = new Point(401, 172);
            Lado3.Name = "Lado3";
            Lado3.Size = new Size(39, 15);
            Lado3.TabIndex = 4;
            Lado3.Text = "Lado3";
            // 
            // LabelResultarea
            // 
            LabelResultarea.AutoSize = true;
            LabelResultarea.Location = new Point(143, 192);
            LabelResultarea.Name = "LabelResultarea";
            LabelResultarea.Size = new Size(31, 15);
            LabelResultarea.TabIndex = 5;
            LabelResultarea.Text = "Área";
            // 
            // LabelResultPerímeter
            // 
            LabelResultPerímeter.AutoSize = true;
            LabelResultPerímeter.Location = new Point(143, 151);
            LabelResultPerímeter.Name = "LabelResultPerímeter";
            LabelResultPerímeter.Size = new Size(59, 15);
            LabelResultPerímeter.TabIndex = 6;
            LabelResultPerímeter.Text = "Perímetro";
            // 
            // Textbox1
            // 
            Textbox1.Location = new Point(247, 148);
            Textbox1.Name = "Textbox1";
            Textbox1.Size = new Size(100, 23);
            Textbox1.TabIndex = 7;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(247, 189);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(100, 23);
            TextBox2.TabIndex = 8;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(247, 101);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(100, 23);
            txtaltura.TabIndex = 9;
            // 
            // txtbase
            // 
            txtbase.Location = new Point(247, 58);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(100, 23);
            txtbase.TabIndex = 10;
            txtbase.TextChanged += textBox4_TextChanged;
            // 
            // BntCalcular
            // 
            BntCalcular.Location = new Point(260, 235);
            BntCalcular.Name = "BntCalcular";
            BntCalcular.Size = new Size(75, 23);
            BntCalcular.TabIndex = 11;
            BntCalcular.Text = "Calcular";
            BntCalcular.UseVisualStyleBackColor = true;
            BntCalcular.Click += BntCalcular_Click;
            // 
            // NovoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BntCalcular);
            Controls.Add(txtbase);
            Controls.Add(txtaltura);
            Controls.Add(TextBox2);
            Controls.Add(Textbox1);
            Controls.Add(LabelResultPerímeter);
            Controls.Add(LabelResultarea);
            Controls.Add(Lado3);
            Controls.Add(Lado2);
            Controls.Add(Lado1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NovoForm";
            Text = "NovoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Lado1;
        private Label Lado2;
        private Label Lado3;
        private Label LabelResultarea;
        private Label LabelResultPerímeter;
        private TextBox Textbox1;
        private TextBox TextBox2;
        private TextBox txtaltura;
        private TextBox txtbase;
        private Button BntCalcular;
    }
}