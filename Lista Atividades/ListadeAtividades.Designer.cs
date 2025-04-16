namespace Lista_Atividades
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
            textBox1AtividadeEmAndamento = new TextBox();
            buttonFinalizar = new Button();
            dataGridViewAtividades = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).BeginInit();
            SuspendLayout();
            // 
            // textBox1AtividadeEmAndamento
            // 
            textBox1AtividadeEmAndamento.Location = new Point(12, 12);
            textBox1AtividadeEmAndamento.Name = "textBox1AtividadeEmAndamento";
            textBox1AtividadeEmAndamento.ReadOnly = true;
            textBox1AtividadeEmAndamento.Size = new Size(648, 23);
            textBox1AtividadeEmAndamento.TabIndex = 0;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(666, 12);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(168, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAtividades
            // 
            dataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividades.Location = new Point(12, 82);
            dataGridViewAtividades.Name = "dataGridViewAtividades";
            dataGridViewAtividades.Size = new Size(639, 333);
            dataGridViewAtividades.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(666, 82);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 3;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(666, 390);
            button2.Name = "button2";
            button2.Size = new Size(168, 25);
            button2.TabIndex = 4;
            button2.Text = "Criar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(846, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewAtividades);
            Controls.Add(buttonFinalizar);
            Controls.Add(textBox1AtividadeEmAndamento);
            Name = "Form1";
            Text = "Lista de Atividades";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1AtividadeEmAndamento;
        private Button buttonFinalizar;
        private DataGridView dataGridViewAtividades;
        private Button button1;
        private Button button2;
    }
}
