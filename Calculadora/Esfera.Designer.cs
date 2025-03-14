namespace Calculadora
{
    partial class Esfera
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
            BntCalcular = new Button();
            textBox1 = new TextBox();
            CalculoVolume = new Label();
            CalcularCircunferência = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BntCalcular
            // 
            BntCalcular.Location = new Point(309, 287);
            BntCalcular.Name = "BntCalcular";
            BntCalcular.Size = new Size(100, 35);
            BntCalcular.TabIndex = 0;
            BntCalcular.Text = "Calcular";
            BntCalcular.UseVisualStyleBackColor = true;
            BntCalcular.Click += BntCalcular_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 1;
            // 
            // CalculoVolume
            // 
            CalculoVolume.AutoSize = true;
            CalculoVolume.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalculoVolume.Location = new Point(224, 128);
            CalculoVolume.Name = "CalculoVolume";
            CalculoVolume.Size = new Size(63, 21);
            CalculoVolume.TabIndex = 2;
            CalculoVolume.Text = "Volume";
            // 
            // CalcularCircunferência
            // 
            CalcularCircunferência.AutoSize = true;
            CalcularCircunferência.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalcularCircunferência.Location = new Point(213, 200);
            CalcularCircunferência.Name = "CalcularCircunferência";
            CalcularCircunferência.Size = new Size(110, 21);
            CalcularCircunferência.TabIndex = 3;
            CalcularCircunferência.Text = "Circunferência";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 26);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 4;
            label1.Text = "Calculo Esfera";
            // 
            // Esfera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CalcularCircunferência);
            Controls.Add(CalculoVolume);
            Controls.Add(textBox1);
            Controls.Add(BntCalcular);
            Name = "Esfera";
            Text = "Esfera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BntCalcular;
        private TextBox textBox1;
        private Label CalculoVolume;
        private Label CalcularCircunferência;
        private Label label1;
    }
}