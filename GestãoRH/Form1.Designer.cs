namespace GestãoRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Situacao = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            groupBoxFuncao = new GroupBox();
            MBSalario = new MaskedTextBox();
            TXTCargo = new TextBox();
            label24 = new Label();
            TXTDepartamento = new TextBox();
            label22 = new Label();
            label18 = new Label();
            label23 = new Label();
            MBDataAdimissao = new MaskedTextBox();
            groupBoxDependente = new GroupBox();
            checkBox1 = new CheckBox();
            label15 = new Label();
            CBParentesco = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            txtNome2 = new TextBox();
            CBGeneroDependente = new ComboBox();
            label19 = new Label();
            MBDataDependente = new MaskedTextBox();
            label20 = new Label();
            MBRgDependente = new MaskedTextBox();
            label21 = new Label();
            MBCPFDependente = new MaskedTextBox();
            groupBoxEndereco = new GroupBox();
            TXTComplemento = new TextBox();
            label9 = new Label();
            TXTNumero = new TextBox();
            label13 = new Label();
            CBEstado = new ComboBox();
            label11 = new Label();
            TXTCidade = new TextBox();
            label12 = new Label();
            TXTBairro = new TextBox();
            label8 = new Label();
            MBCEP = new MaskedTextBox();
            label7 = new Label();
            TXTLogradouro = new TextBox();
            label10 = new Label();
            groupBoxDadoPessoal = new GroupBox();
            label14 = new Label();
            CBEstadoCivil = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            textNome = new TextBox();
            CBGenero = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            textBoxID = new TextBox();
            MBDataNascimento = new MaskedTextBox();
            label4 = new Label();
            MBRG = new MaskedTextBox();
            label3 = new Label();
            MBCpf = new MaskedTextBox();
            Logo = new Panel();
            panel1 = new Panel();
            Background = new Panel();
            pictureBox1 = new PictureBox();
            Tela = new Panel();
            lErro = new Label();
            lSenha = new Label();
            lUsuario = new Label();
            btesquecisenha = new Label();
            Mensagem = new Label();
            groupBoxFuncao.SuspendLayout();
            groupBoxDependente.SuspendLayout();
            groupBoxEndereco.SuspendLayout();
            groupBoxDadoPessoal.SuspendLayout();
            panel1.SuspendLayout();
            Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Tela.SuspendLayout();
            SuspendLayout();
            // 
            // Situacao
            // 
            Situacao.AutoSize = true;
            Situacao.BackColor = Color.Transparent;
            Situacao.Checked = true;
            Situacao.CheckState = CheckState.Checked;
            Situacao.Font = new Font("Microsoft Sans Serif", 9F);
            Situacao.ForeColor = Color.MidnightBlue;
            Situacao.Location = new Point(21, 783);
            Situacao.Margin = new Padding(3, 4, 3, 4);
            Situacao.Name = "Situacao";
            Situacao.Size = new Size(88, 22);
            Situacao.TabIndex = 22;
            Situacao.Text = "Situação";
            Situacao.UseVisualStyleBackColor = false;
            Situacao.CheckedChanged += Situacao_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Microsoft Sans Serif", 9F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(21, 745);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(216, 29);
            button2.TabIndex = 27;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(208, 745);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(216, 29);
            button1.TabIndex = 25;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBoxFuncao
            // 
            groupBoxFuncao.BackColor = Color.Transparent;
            groupBoxFuncao.Controls.Add(MBSalario);
            groupBoxFuncao.Controls.Add(TXTCargo);
            groupBoxFuncao.Controls.Add(label24);
            groupBoxFuncao.Controls.Add(TXTDepartamento);
            groupBoxFuncao.Controls.Add(label22);
            groupBoxFuncao.Controls.Add(label18);
            groupBoxFuncao.Controls.Add(label23);
            groupBoxFuncao.Controls.Add(MBDataAdimissao);
            groupBoxFuncao.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxFuncao.ForeColor = Color.MidnightBlue;
            groupBoxFuncao.Location = new Point(21, 577);
            groupBoxFuncao.Margin = new Padding(3, 4, 3, 4);
            groupBoxFuncao.Name = "groupBoxFuncao";
            groupBoxFuncao.Padding = new Padding(3, 4, 3, 4);
            groupBoxFuncao.Size = new Size(403, 161);
            groupBoxFuncao.TabIndex = 24;
            groupBoxFuncao.TabStop = false;
            groupBoxFuncao.Text = "FUNÇÃO";
            // 
            // MBSalario
            // 
            MBSalario.BorderStyle = BorderStyle.None;
            MBSalario.Location = new Point(173, 96);
            MBSalario.Margin = new Padding(3, 4, 3, 4);
            MBSalario.Mask = "$000000000000000000";
            MBSalario.Name = "MBSalario";
            MBSalario.Size = new Size(158, 17);
            MBSalario.TabIndex = 20;
            // 
            // TXTCargo
            // 
            TXTCargo.BorderStyle = BorderStyle.None;
            TXTCargo.Location = new Point(7, 96);
            TXTCargo.Margin = new Padding(3, 4, 3, 4);
            TXTCargo.Name = "TXTCargo";
            TXTCargo.Size = new Size(158, 17);
            TXTCargo.TabIndex = 12;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 9F);
            label24.Location = new Point(173, 76);
            label24.Name = "label24";
            label24.Size = new Size(74, 18);
            label24.TabIndex = 19;
            label24.Text = "SALARIO:";
            // 
            // TXTDepartamento
            // 
            TXTDepartamento.BorderStyle = BorderStyle.None;
            TXTDepartamento.Location = new Point(8, 44);
            TXTDepartamento.Margin = new Padding(3, 4, 3, 4);
            TXTDepartamento.Name = "TXTDepartamento";
            TXTDepartamento.Size = new Size(158, 17);
            TXTDepartamento.TabIndex = 14;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 9F);
            label22.Location = new Point(9, 21);
            label22.Name = "label22";
            label22.Size = new Size(136, 18);
            label22.TabIndex = 15;
            label22.Text = "DEPARTAMENTO:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9F);
            label18.Location = new Point(8, 76);
            label18.Name = "label18";
            label18.Size = new Size(67, 18);
            label18.TabIndex = 13;
            label18.Text = "CARGO:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 9F);
            label23.Location = new Point(174, 24);
            label23.Name = "label23";
            label23.RightToLeft = RightToLeft.No;
            label23.Size = new Size(156, 18);
            label23.TabIndex = 17;
            label23.Text = "DATA DE ADMISSÃO:";
            // 
            // MBDataAdimissao
            // 
            MBDataAdimissao.BorderStyle = BorderStyle.None;
            MBDataAdimissao.Location = new Point(174, 44);
            MBDataAdimissao.Margin = new Padding(3, 4, 3, 4);
            MBDataAdimissao.Mask = "00/00/0000";
            MBDataAdimissao.Name = "MBDataAdimissao";
            MBDataAdimissao.Size = new Size(158, 17);
            MBDataAdimissao.TabIndex = 16;
            MBDataAdimissao.ValidatingType = typeof(DateTime);
            // 
            // groupBoxDependente
            // 
            groupBoxDependente.BackColor = Color.Transparent;
            groupBoxDependente.Controls.Add(checkBox1);
            groupBoxDependente.Controls.Add(label15);
            groupBoxDependente.Controls.Add(CBParentesco);
            groupBoxDependente.Controls.Add(label16);
            groupBoxDependente.Controls.Add(label17);
            groupBoxDependente.Controls.Add(txtNome2);
            groupBoxDependente.Controls.Add(CBGeneroDependente);
            groupBoxDependente.Controls.Add(label19);
            groupBoxDependente.Controls.Add(MBDataDependente);
            groupBoxDependente.Controls.Add(label20);
            groupBoxDependente.Controls.Add(MBRgDependente);
            groupBoxDependente.Controls.Add(label21);
            groupBoxDependente.Controls.Add(MBCPFDependente);
            groupBoxDependente.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxDependente.ForeColor = Color.MidnightBlue;
            groupBoxDependente.Location = new Point(21, 409);
            groupBoxDependente.Margin = new Padding(3, 4, 3, 4);
            groupBoxDependente.Name = "groupBoxDependente";
            groupBoxDependente.Padding = new Padding(3, 4, 3, 4);
            groupBoxDependente.Size = new Size(738, 161);
            groupBoxDependente.TabIndex = 23;
            groupBoxDependente.TabStop = false;
            groupBoxDependente.Text = "DEPENDENTES";
            groupBoxDependente.Enter += groupBoxDependente_Enter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(505, 136);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 22);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Sem dependentes";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9F);
            label15.Location = new Point(182, 79);
            label15.Name = "label15";
            label15.Size = new Size(115, 18);
            label15.TabIndex = 13;
            label15.Text = "PARENTESCO:";
            // 
            // CBParentesco
            // 
            CBParentesco.FormattingEnabled = true;
            CBParentesco.Items.AddRange(new object[] { "CÔNJUGE", "FILHO(A)" });
            CBParentesco.Location = new Point(182, 101);
            CBParentesco.Margin = new Padding(3, 4, 3, 4);
            CBParentesco.Name = "CBParentesco";
            CBParentesco.Size = new Size(138, 26);
            CBParentesco.TabIndex = 12;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9F);
            label16.Location = new Point(328, 79);
            label16.Name = "label16";
            label16.Size = new Size(78, 18);
            label16.TabIndex = 8;
            label16.Text = "GENERO:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9F);
            label17.Location = new Point(8, 24);
            label17.Name = "label17";
            label17.Size = new Size(147, 18);
            label17.TabIndex = 11;
            label17.Text = "NOME COMPLETO:";
            // 
            // txtNome2
            // 
            txtNome2.BorderStyle = BorderStyle.None;
            txtNome2.Location = new Point(8, 47);
            txtNome2.Margin = new Padding(3, 4, 3, 4);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(681, 17);
            txtNome2.TabIndex = 10;
            txtNome2.TextChanged += txtNome2_TextChanged;
            // 
            // CBGeneroDependente
            // 
            CBGeneroDependente.FormattingEnabled = true;
            CBGeneroDependente.Items.AddRange(new object[] { "MASCULINO", "FEMININO", "OUTROS" });
            CBGeneroDependente.Location = new Point(328, 101);
            CBGeneroDependente.Margin = new Padding(3, 4, 3, 4);
            CBGeneroDependente.Name = "CBGeneroDependente";
            CBGeneroDependente.Size = new Size(132, 26);
            CBGeneroDependente.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9F);
            label19.Location = new Point(8, 79);
            label19.Name = "label19";
            label19.Size = new Size(178, 18);
            label19.TabIndex = 6;
            label19.Text = "DATA DE NASCIMENTO:";
            // 
            // MBDataDependente
            // 
            MBDataDependente.BorderStyle = BorderStyle.None;
            MBDataDependente.Location = new Point(7, 101);
            MBDataDependente.Margin = new Padding(3, 4, 3, 4);
            MBDataDependente.Mask = "00/00/0000";
            MBDataDependente.Name = "MBDataDependente";
            MBDataDependente.Size = new Size(167, 17);
            MBDataDependente.TabIndex = 5;
            MBDataDependente.ValidatingType = typeof(DateTime);
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9F);
            label20.Location = new Point(583, 79);
            label20.Name = "label20";
            label20.Size = new Size(35, 18);
            label20.TabIndex = 4;
            label20.Text = "RG:";
            // 
            // MBRgDependente
            // 
            MBRgDependente.BorderStyle = BorderStyle.None;
            MBRgDependente.Location = new Point(583, 101);
            MBRgDependente.Margin = new Padding(3, 4, 3, 4);
            MBRgDependente.Mask = "00,000,000-0";
            MBRgDependente.Name = "MBRgDependente";
            MBRgDependente.Size = new Size(105, 17);
            MBRgDependente.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 9F);
            label21.Location = new Point(469, 79);
            label21.Name = "label21";
            label21.Size = new Size(42, 18);
            label21.TabIndex = 2;
            label21.Text = "CPF:";
            // 
            // MBCPFDependente
            // 
            MBCPFDependente.BorderStyle = BorderStyle.None;
            MBCPFDependente.Location = new Point(469, 101);
            MBCPFDependente.Margin = new Padding(3, 4, 3, 4);
            MBCPFDependente.Mask = "000,000,000-00";
            MBCPFDependente.Name = "MBCPFDependente";
            MBCPFDependente.Size = new Size(105, 17);
            MBCPFDependente.TabIndex = 1;
            // 
            // groupBoxEndereco
            // 
            groupBoxEndereco.BackColor = Color.Transparent;
            groupBoxEndereco.Controls.Add(TXTComplemento);
            groupBoxEndereco.Controls.Add(label9);
            groupBoxEndereco.Controls.Add(TXTNumero);
            groupBoxEndereco.Controls.Add(label13);
            groupBoxEndereco.Controls.Add(CBEstado);
            groupBoxEndereco.Controls.Add(label11);
            groupBoxEndereco.Controls.Add(TXTCidade);
            groupBoxEndereco.Controls.Add(label12);
            groupBoxEndereco.Controls.Add(TXTBairro);
            groupBoxEndereco.Controls.Add(label8);
            groupBoxEndereco.Controls.Add(MBCEP);
            groupBoxEndereco.Controls.Add(label7);
            groupBoxEndereco.Controls.Add(TXTLogradouro);
            groupBoxEndereco.Controls.Add(label10);
            groupBoxEndereco.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxEndereco.ForeColor = Color.MidnightBlue;
            groupBoxEndereco.Location = new Point(21, 236);
            groupBoxEndereco.Margin = new Padding(3, 4, 3, 4);
            groupBoxEndereco.Name = "groupBoxEndereco";
            groupBoxEndereco.Padding = new Padding(3, 4, 3, 4);
            groupBoxEndereco.Size = new Size(738, 167);
            groupBoxEndereco.TabIndex = 21;
            groupBoxEndereco.TabStop = false;
            groupBoxEndereco.Text = "ENDEREÇO";
            // 
            // TXTComplemento
            // 
            TXTComplemento.BorderStyle = BorderStyle.None;
            TXTComplemento.Location = new Point(98, 101);
            TXTComplemento.Margin = new Padding(3, 4, 3, 4);
            TXTComplemento.Name = "TXTComplemento";
            TXTComplemento.Size = new Size(270, 17);
            TXTComplemento.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.Location = new Point(7, 79);
            label9.Name = "label9";
            label9.Size = new Size(80, 18);
            label9.TabIndex = 37;
            label9.Text = "NUMERO:";
            // 
            // TXTNumero
            // 
            TXTNumero.BorderStyle = BorderStyle.None;
            TXTNumero.Location = new Point(7, 101);
            TXTNumero.Margin = new Padding(3, 4, 3, 4);
            TXTNumero.Name = "TXTNumero";
            TXTNumero.Size = new Size(86, 17);
            TXTNumero.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F);
            label13.Location = new Point(530, 79);
            label13.Name = "label13";
            label13.Size = new Size(73, 18);
            label13.TabIndex = 35;
            label13.Text = "ESTADO:";
            // 
            // CBEstado
            // 
            CBEstado.FormattingEnabled = true;
            CBEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            CBEstado.Location = new Point(530, 101);
            CBEstado.Margin = new Padding(3, 4, 3, 4);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(157, 26);
            CBEstado.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.Location = new Point(376, 79);
            label11.Name = "label11";
            label11.Size = new Size(67, 18);
            label11.TabIndex = 33;
            label11.Text = "CIDADE:";
            // 
            // TXTCidade
            // 
            TXTCidade.BorderStyle = BorderStyle.None;
            TXTCidade.Location = new Point(376, 101);
            TXTCidade.Margin = new Padding(3, 4, 3, 4);
            TXTCidade.Name = "TXTCidade";
            TXTCidade.Size = new Size(145, 17);
            TXTCidade.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F);
            label12.Location = new Point(397, 24);
            label12.Name = "label12";
            label12.Size = new Size(68, 18);
            label12.TabIndex = 31;
            label12.Text = "BAIRRO:";
            // 
            // TXTBairro
            // 
            TXTBairro.BorderStyle = BorderStyle.None;
            TXTBairro.Location = new Point(397, 47);
            TXTBairro.Margin = new Padding(3, 4, 3, 4);
            TXTBairro.Name = "TXTBairro";
            TXTBairro.Size = new Size(289, 17);
            TXTBairro.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(6, 24);
            label8.Name = "label8";
            label8.Size = new Size(43, 18);
            label8.TabIndex = 29;
            label8.Text = "CEP:";
            // 
            // MBCEP
            // 
            MBCEP.BorderStyle = BorderStyle.None;
            MBCEP.Location = new Point(6, 47);
            MBCEP.Margin = new Padding(3, 4, 3, 4);
            MBCEP.Mask = "00000-000";
            MBCEP.Name = "MBCEP";
            MBCEP.Size = new Size(86, 17);
            MBCEP.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(99, 24);
            label7.Name = "label7";
            label7.Size = new Size(121, 18);
            label7.TabIndex = 27;
            label7.Text = "LOGRADOURO:";
            // 
            // TXTLogradouro
            // 
            TXTLogradouro.BorderStyle = BorderStyle.None;
            TXTLogradouro.Location = new Point(99, 47);
            TXTLogradouro.Margin = new Padding(3, 4, 3, 4);
            TXTLogradouro.Name = "TXTLogradouro";
            TXTLogradouro.Size = new Size(289, 17);
            TXTLogradouro.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.Location = new Point(98, 79);
            label10.Name = "label10";
            label10.Size = new Size(131, 18);
            label10.TabIndex = 39;
            label10.Text = "COMPLEMENTO:";
            // 
            // groupBoxDadoPessoal
            // 
            groupBoxDadoPessoal.BackColor = Color.Transparent;
            groupBoxDadoPessoal.Controls.Add(label14);
            groupBoxDadoPessoal.Controls.Add(CBEstadoCivil);
            groupBoxDadoPessoal.Controls.Add(label6);
            groupBoxDadoPessoal.Controls.Add(label2);
            groupBoxDadoPessoal.Controls.Add(textNome);
            groupBoxDadoPessoal.Controls.Add(CBGenero);
            groupBoxDadoPessoal.Controls.Add(label1);
            groupBoxDadoPessoal.Controls.Add(label5);
            groupBoxDadoPessoal.Controls.Add(textBoxID);
            groupBoxDadoPessoal.Controls.Add(MBDataNascimento);
            groupBoxDadoPessoal.Controls.Add(label4);
            groupBoxDadoPessoal.Controls.Add(MBRG);
            groupBoxDadoPessoal.Controls.Add(label3);
            groupBoxDadoPessoal.Controls.Add(MBCpf);
            groupBoxDadoPessoal.Font = new Font("Microsoft Sans Serif", 9F);
            groupBoxDadoPessoal.ForeColor = Color.MidnightBlue;
            groupBoxDadoPessoal.Location = new Point(21, 63);
            groupBoxDadoPessoal.Margin = new Padding(3, 4, 3, 4);
            groupBoxDadoPessoal.Name = "groupBoxDadoPessoal";
            groupBoxDadoPessoal.Padding = new Padding(3, 4, 3, 4);
            groupBoxDadoPessoal.Size = new Size(738, 167);
            groupBoxDadoPessoal.TabIndex = 20;
            groupBoxDadoPessoal.TabStop = false;
            groupBoxDadoPessoal.Text = "DADOS PESSOAIS";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9F);
            label14.Location = new Point(186, 79);
            label14.Name = "label14";
            label14.Size = new Size(111, 18);
            label14.TabIndex = 13;
            label14.Text = "ESTADO CIVIL:";
            // 
            // CBEstadoCivil
            // 
            CBEstadoCivil.FormattingEnabled = true;
            CBEstadoCivil.Items.AddRange(new object[] { "SOLTEIRO(a)", "CASADO(a)", "DIVORCIADO(a)", "VIUVO(a)" });
            CBEstadoCivil.Location = new Point(189, 101);
            CBEstadoCivil.Margin = new Padding(3, 4, 3, 4);
            CBEstadoCivil.Name = "CBEstadoCivil";
            CBEstadoCivil.Size = new Size(132, 26);
            CBEstadoCivil.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(329, 79);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 8;
            label6.Text = "GENERO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(81, 24);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 11;
            label2.Text = "NOME COMPLETO:";
            // 
            // textNome
            // 
            textNome.BorderStyle = BorderStyle.None;
            textNome.Location = new Point(81, 47);
            textNome.Margin = new Padding(3, 4, 3, 4);
            textNome.Name = "textNome";
            textNome.Size = new Size(608, 17);
            textNome.TabIndex = 10;
            // 
            // CBGenero
            // 
            CBGenero.FormattingEnabled = true;
            CBGenero.Items.AddRange(new object[] { "MASCULINO", "FEMININO", "OUTROS" });
            CBGenero.Location = new Point(329, 101);
            CBGenero.Margin = new Padding(3, 4, 3, 4);
            CBGenero.Name = "CBGenero";
            CBGenero.Size = new Size(132, 26);
            CBGenero.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(8, 24);
            label1.Name = "label1";
            label1.Size = new Size(26, 18);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(8, 79);
            label5.Name = "label5";
            label5.Size = new Size(178, 18);
            label5.TabIndex = 6;
            label5.Text = "DATA DE NASCIMENTO:";
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.None;
            textBoxID.Location = new Point(8, 47);
            textBoxID.Margin = new Padding(3, 4, 3, 4);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(65, 17);
            textBoxID.TabIndex = 8;
            // 
            // MBDataNascimento
            // 
            MBDataNascimento.BorderStyle = BorderStyle.None;
            MBDataNascimento.Location = new Point(8, 101);
            MBDataNascimento.Margin = new Padding(3, 4, 3, 4);
            MBDataNascimento.Mask = "00/00/0000";
            MBDataNascimento.Name = "MBDataNascimento";
            MBDataNascimento.Size = new Size(171, 17);
            MBDataNascimento.TabIndex = 5;
            MBDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(584, 79);
            label4.Name = "label4";
            label4.Size = new Size(35, 18);
            label4.TabIndex = 4;
            label4.Text = "RG:";
            // 
            // MBRG
            // 
            MBRG.BorderStyle = BorderStyle.None;
            MBRG.Location = new Point(584, 101);
            MBRG.Margin = new Padding(3, 4, 3, 4);
            MBRG.Mask = "00,000,000-0";
            MBRG.Name = "MBRG";
            MBRG.Size = new Size(105, 17);
            MBRG.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(470, 79);
            label3.Name = "label3";
            label3.Size = new Size(42, 18);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // MBCpf
            // 
            MBCpf.BorderStyle = BorderStyle.None;
            MBCpf.Location = new Point(470, 101);
            MBCpf.Margin = new Padding(3, 4, 3, 4);
            MBCpf.Mask = "000,000,000-00";
            MBCpf.Name = "MBCpf";
            MBCpf.Size = new Size(105, 17);
            MBCpf.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImage = (Image)resources.GetObject("Logo.BackgroundImage");
            Logo.BackgroundImageLayout = ImageLayout.Zoom;
            Logo.Location = new Point(431, 579);
            Logo.Margin = new Padding(3, 5, 3, 5);
            Logo.Name = "Logo";
            Logo.Size = new Size(328, 228);
            Logo.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(Background);
            panel1.Location = new Point(14, 17);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1674, 929);
            panel1.TabIndex = 29;
            // 
            // Background
            // 
            Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Background.AutoSize = true;
            Background.BackColor = Color.Transparent;
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.Controls.Add(pictureBox1);
            Background.Controls.Add(Tela);
            Background.Controls.Add(Mensagem);
            Background.Location = new Point(-79, -83);
            Background.Margin = new Padding(3, 5, 3, 5);
            Background.Name = "Background";
            Background.Size = new Size(1945, 1095);
            Background.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(942, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(722, 717);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Tela
            // 
            Tela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tela.BackColor = Color.Transparent;
            Tela.BackgroundImage = (Image)resources.GetObject("Tela.BackgroundImage");
            Tela.BackgroundImageLayout = ImageLayout.Stretch;
            Tela.Controls.Add(Logo);
            Tela.Controls.Add(lErro);
            Tela.Controls.Add(Situacao);
            Tela.Controls.Add(lSenha);
            Tela.Controls.Add(button2);
            Tela.Controls.Add(lUsuario);
            Tela.Controls.Add(button1);
            Tela.Controls.Add(btesquecisenha);
            Tela.Controls.Add(groupBoxFuncao);
            Tela.Controls.Add(groupBoxDadoPessoal);
            Tela.Controls.Add(groupBoxDependente);
            Tela.Controls.Add(groupBoxEndereco);
            Tela.Location = new Point(101, 120);
            Tela.Margin = new Padding(3, 5, 3, 5);
            Tela.Name = "Tela";
            Tela.Size = new Size(803, 861);
            Tela.TabIndex = 5;
            // 
            // lErro
            // 
            lErro.AutoSize = true;
            lErro.Location = new Point(445, 663);
            lErro.Name = "lErro";
            lErro.Size = new Size(0, 20);
            lErro.TabIndex = 14;
            // 
            // lSenha
            // 
            lSenha.AutoSize = true;
            lSenha.Location = new Point(445, 660);
            lSenha.Name = "lSenha";
            lSenha.Size = new Size(0, 20);
            lSenha.TabIndex = 13;
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Location = new Point(445, 589);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(0, 20);
            lUsuario.TabIndex = 12;
            // 
            // btesquecisenha
            // 
            btesquecisenha.AutoSize = true;
            btesquecisenha.Cursor = Cursors.Hand;
            btesquecisenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btesquecisenha.Location = new Point(73, 567);
            btesquecisenha.Name = "btesquecisenha";
            btesquecisenha.Size = new Size(0, 28);
            btesquecisenha.TabIndex = 8;
            // 
            // Mensagem
            // 
            Mensagem.AutoSize = true;
            Mensagem.BackColor = Color.Transparent;
            Mensagem.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mensagem.ForeColor = SystemColors.Window;
            Mensagem.Location = new Point(179, 216);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(515, 53);
            Mensagem.TabIndex = 1;
            Mensagem.Text = "Bem vindo de volta!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1628, 878);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRO DE COLABORADORES";
            groupBoxFuncao.ResumeLayout(false);
            groupBoxFuncao.PerformLayout();
            groupBoxDependente.ResumeLayout(false);
            groupBoxDependente.PerformLayout();
            groupBoxEndereco.ResumeLayout(false);
            groupBoxEndereco.PerformLayout();
            groupBoxDadoPessoal.ResumeLayout(false);
            groupBoxDadoPessoal.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Tela.ResumeLayout(false);
            Tela.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox Situacao;
        private Button button2;
        private Button button1;
        private GroupBox groupBoxFuncao;
        private MaskedTextBox MBSalario;
        private TextBox TXTCargo;
        private Label label24;
        private TextBox TXTDepartamento;
        private Label label22;
        private Label label18;
        private Label label23;
        private MaskedTextBox MBDataAdimissao;
        private GroupBox groupBoxDependente;
        private CheckBox checkBox1;
        private Label label15;
        private ComboBox CBParentesco;
        private Label label16;
        private Label label17;
        private TextBox txtNome2;
        private ComboBox CBGeneroDependente;
        private Label label19;
        private MaskedTextBox MBDataDependente;
        private Label label20;
        private MaskedTextBox MBRgDependente;
        private Label label21;
        private MaskedTextBox MBCPFDependente;
        private GroupBox groupBoxEndereco;
        private Label label10;
        private TextBox TXTComplemento;
        private Label label9;
        private TextBox TXTNumero;
        private Label label13;
        private ComboBox CBEstado;
        private Label label11;
        private TextBox TXTCidade;
        private Label label12;
        private TextBox TXTBairro;
        private Label label8;
        private MaskedTextBox MBCEP;
        private Label label7;
        private TextBox TXTLogradouro;
        private GroupBox groupBoxDadoPessoal;
        private Label label14;
        private ComboBox CBEstadoCivil;
        private Label label6;
        private Label label2;
        private TextBox textNome;
        private ComboBox CBGenero;
        private Label label1;
        private Label label5;
        private TextBox textBoxID;
        private MaskedTextBox MBDataNascimento;
        private Label label4;
        private MaskedTextBox MBRG;
        private Label label3;
        private MaskedTextBox MBCpf;
        private Panel Logo;
        private Panel panel1;
        private Panel Background;
        private Panel Tela;
        private Label lErro;
        private Label lSenha;
        private Label lUsuario;
        private Label btesquecisenha;
        private Label Mensagem;
        private PictureBox pictureBox1;
    }
}
