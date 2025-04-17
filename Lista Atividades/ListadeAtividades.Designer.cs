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
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            labelErro = new Label();
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
            textBox1AtividadeEmAndamento.TextChanged += textBox1AtividadeEmAndamento_TextChanged;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(666, 12);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(168, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // dataGridViewAtividades
            // 
            dataGridViewAtividades.AllowUserToAddRows = false;
            dataGridViewAtividades.AllowUserToDeleteRows = false;
            dataGridViewAtividades.AllowUserToResizeColumns = false;
            dataGridViewAtividades.AllowUserToResizeRows = false;
            dataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividades.Location = new Point(12, 41);
            dataGridViewAtividades.MultiSelect = false;
            dataGridViewAtividades.Name = "dataGridViewAtividades";
            dataGridViewAtividades.ReadOnly = true;
            dataGridViewAtividades.Size = new Size(639, 333);
            dataGridViewAtividades.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(666, 82);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(168, 23);
            buttonAtualizar.TabIndex = 3;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            buttonAtualizar.Click += button1_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(666, 390);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(168, 25);
            buttonCriar.TabIndex = 4;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += button2_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(41, 426);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(38, 15);
            labelErro.TabIndex = 5;
            labelErro.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(846, 450);
            Controls.Add(labelErro);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
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
        private Button buttonAtualizar;
        private Button buttonCriar;
        private Label labelErro;
    }
}
