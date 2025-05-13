namespace GestaoRH
{
    partial class Interface_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface_Inicial));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            button4 = new Button();
            label1 = new Label();
            ButtonNovo = new Button();
            buttonAtualizar = new Button();
            panel2 = new Panel();
            Logo = new Panel();
            Background = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(216, 217);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(866, 288);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(185, 383);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(881, 419);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ButtonNovo);
            groupBox1.Controls.Add(buttonAtualizar);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(130, 779);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(32, 213);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 6;
            label2.Text = "Editar";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(18, 674);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 88);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(4, 105);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 6;
            label1.Text = "Novo Funcionário";
            // 
            // ButtonNovo
            // 
            ButtonNovo.BackColor = Color.Transparent;
            ButtonNovo.BackgroundImage = (Image)resources.GetObject("ButtonNovo.BackgroundImage");
            ButtonNovo.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonNovo.Cursor = Cursors.Hand;
            ButtonNovo.FlatStyle = FlatStyle.Flat;
            ButtonNovo.ForeColor = Color.Transparent;
            ButtonNovo.Location = new Point(18, 27);
            ButtonNovo.Margin = new Padding(3, 4, 3, 4);
            ButtonNovo.Name = "ButtonNovo";
            ButtonNovo.Size = new Size(78, 78);
            ButtonNovo.TabIndex = 0;
            ButtonNovo.UseMnemonic = false;
            ButtonNovo.UseVisualStyleBackColor = false;
            ButtonNovo.Click += ButtonNovo_Click;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.BackColor = Color.Transparent;
            buttonAtualizar.BackgroundImage = (Image)resources.GetObject("buttonAtualizar.BackgroundImage");
            buttonAtualizar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAtualizar.Cursor = Cursors.Hand;
            buttonAtualizar.FlatStyle = FlatStyle.Flat;
            buttonAtualizar.ForeColor = Color.Transparent;
            buttonAtualizar.Location = new Point(18, 130);
            buttonAtualizar.Margin = new Padding(3, 4, 3, 4);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(78, 78);
            buttonAtualizar.TabIndex = 0;
            buttonAtualizar.UseVisualStyleBackColor = false;
            buttonAtualizar.Click += buttonAtualizar_Click_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Logo);
            panel2.Controls.Add(groupBox1);
            panel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(45, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 803);
            panel2.TabIndex = 9;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(139, 1);
            Logo.Margin = new Padding(3, 5, 3, 5);
            Logo.Name = "Logo";
            Logo.Size = new Size(881, 361);
            Logo.TabIndex = 5;
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.BackColor = Color.Transparent;
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.Controls.Add(pictureBox4);
            Background.Location = new Point(-59, -145);
            Background.Margin = new Padding(3, 5, 3, 5);
            Background.Name = "Background";
            Background.Size = new Size(1202, 1095);
            Background.TabIndex = 11;
            // 
            // Interface_Inicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1104, 804);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(Background);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Interface_Inicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Recursos Humanos";
            Load += Interface_Inicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            Background.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button ButtonNovo;
        private Button buttonAtualizar;
        private Panel panel2;
        private Button button4;
        private Panel Background;
        private Panel Logo;
    }
}