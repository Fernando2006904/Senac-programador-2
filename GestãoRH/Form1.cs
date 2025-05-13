using GestaoRH;
using GestaoRH.BancoDados.Dominio;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace GestãoRH
{
    public partial class Form1 : Form
    {
        private int? funcionarioId;
        private int? enderecoId;
        private int? dependenteId;
        private int? funcaoId;

        public Form1()
        {
            InitializeComponent();

            textBoxID.Enabled = false;
            textBoxID.ReadOnly = true;

            button1.Text = "Criar";
        }

        public Form1(int funcionarioId)
        {
            InitializeComponent();
            this.funcionarioId = funcionarioId;

            textBoxID.Enabled = false;
            textBoxID.ReadOnly = true;
            textBoxID.Text = funcionarioId.ToString();

            button1.Text = "Alterar";

            CarregarFuncionarioPorId(funcionarioId);
        }

        private bool ValidarDadosPessoais()
        {
            // Painel 1

            var nome = textNome.Text;
            // Validação Nome
            if (string.IsNullOrEmpty(textNome.Text) || Regex.IsMatch(textNome.Text, @"[^a-zA-Z0-9\s]") || nome.Split(' ').Length < 2)
            {
                MessageBox.Show("Insira um Nome Valído");
                return true;
            }

            // validação Cpf
            string CPF = new string(MBCpf.Text.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(CPF) || CPF.Length != 11)
            {
                MessageBox.Show("Numero do CPF Invalido");
                return true;
            }
            // validar RG

            string RG = new string(MBRG.Text.Where(char.IsDigit).ToArray());


            if (string.IsNullOrWhiteSpace(RG) || RG.Length != 9)
            {
                MessageBox.Show("Numero do RG Invalido");
                return true;
            }
            // validar Data de Nascimento

            var DataNascimento = MBDataNascimento.Text;

            if (!DateTime.TryParse(MBDataNascimento.Text, out var dataNascimento))
            {
                MessageBox.Show("Insira uma data valida");
                return true;

            }

            // validar genero 

            if (CBGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Informe Seu Genêro");
                return true;
            }

            // validar Estado Civil

            if (CBEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Informe Seu Estado Civil");
                return true;
            }

            string status;
            if (Situacao.Checked)
            {
                status = "Ativo";
            }
            else
            {
                status = "Inativo";
            }

            return false;
        }
        private bool ValidarDependentes()
        {






            // Nome Dependente
            var nomeDependentes = txtNome2.Text;
            if (string.IsNullOrEmpty(txtNome2.Text) || Regex.IsMatch(textNome.Text, @"[^a-zA-Z0-9\s]") || nomeDependentes.Split(' ').Length < 2)
            {
                MessageBox.Show("Insira o Nome dO Dependente");
                return true;
            }

            // Cpf Dependente
            string CPFDependente = new string(MBCPFDependente.Text.Where(char.IsDigit).ToArray());

            string cpfDigitado = MBCpf.Text.Trim();



            if (string.IsNullOrWhiteSpace(CPFDependente) || CPFDependente.Length != 11)
            {
                MessageBox.Show(" Insira o Numero do CPF do Dependente");
                return true;
            }

            //  RG Dependente

            string RGDependente = new string(MBRgDependente.Text.Where(char.IsDigit).ToArray());


            if (string.IsNullOrWhiteSpace(RGDependente) || RGDependente.Length != 9)
            {
                MessageBox.Show(" Insira o Numero do Rg do Dependente");
                return true;
            }

            //Data Dependente
            if (!DateTime.TryParse(MBDataDependente.Text, out var dataNascimento))
            {
                MessageBox.Show("Insira uma data valida");
                return true;

            }


            // Genero Dependente

            if (CBGeneroDependente.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o Genêro do Dependente");
                return true;
            }

            // Parentesco Validação

            if (CBParentesco.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o Parentesco do Dependente");
                return true;
            }



            return false;
        }
        private bool ValidarEndereco()
        {
            if (string.IsNullOrEmpty(MBCEP.Text))
            {
                MessageBox.Show("Informe O Cep");
                return true;
            }
            if (string.IsNullOrEmpty(TXTLogradouro.Text))
            {
                MessageBox.Show("Informe O Logradoro");
                return true;
            }
            if (string.IsNullOrEmpty(TXTNumero.Text))
            {
                MessageBox.Show("Informe O Numero");
                return true;
            }

            if (string.IsNullOrEmpty(TXTBairro.Text))
            {
                MessageBox.Show("Informe O Bairro");
                return true;
            }
            if (string.IsNullOrEmpty(TXTCidade.Text))
            {
                MessageBox.Show("Informe O Cidade");
                return true;
            }

            if (CBEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Informe O Estado");
                return true;
            }



            return false;
        }
        private bool ValidarFuncao()
        {
            if (string.IsNullOrEmpty(TXTCargo.Text))
            {
                MessageBox.Show("Campo Cargo Obrigatorio");
                TXTCargo.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(TXTDepartamento.Text))
            {
                MessageBox.Show("Campo Departamento Obrigatorio");
                TXTCargo.Focus();
                return true;
            }

            var DataAdmissao = MBDataAdimissao.Text;

            if (!DateTime.TryParse(MBDataAdimissao.Text, out var DataAdimissao))
            {
                MessageBox.Show("Insira a Data de Admissão");
                return true;

            }

            if (string.IsNullOrEmpty(MBSalario.Text))
            {
                MessageBox.Show("Insira o Salario do Funcionario");
                MBSalario.Focus();
                return true;
            }


            return false;
        }
        private void InserirSql()
        {
            DateTime DataNascimento;
            DateTime.TryParse(MBDataNascimento.Text, out DataNascimento);

            var funcionario = new Funcionario
            {
                NomeCompleto = textNome.Text,
                CPF = MBCpf.Text,
                RG = MBRG.Text,
                DataNascimento = DataNascimento,
                Genero = CBGenero.Text,
                EstadoCivil = CBEstadoCivil.Text,
                Situacao = Situacao.Checked ? "Ativo" : "Inativo",
            };

            DateTime DataDependente;
            DateTime.TryParse(MBDataDependente.Text, out DataDependente);

            var dependente = new Dependente
            {
                NomeCompleto = txtNome2.Text,
                CPF = MBCPFDependente.Text,
                RG = MBRG.Text,
                DataNascimentoDependente = DataDependente,
                GeneroDependente = CBGeneroDependente.Text,
                Parentesco = CBParentesco.Text,
            };

            var endereco = new Endereco
            {
                CEP = MBCEP.Text,
                Logradouro = TXTLogradouro.Text,
                Numero = TXTNumero.Text,
                Complemento = TXTComplemento.Text,
                Bairro = TXTBairro.Text,
                Cidade = TXTCidade.Text,
                Estado = CBEstado.Text,

            };

            DateTime DataAdimissao;
            DateTime.TryParse(MBDataAdimissao.Text, out DataAdimissao);

            var funcao = new Funcao
            {
                Cargo = TXTCargo.Text,
                Departamento = TXTDepartamento.Text,
                DataAdmissao = DataAdimissao,
                Salario = decimal.Parse(MBSalario.Text.Replace("R$", ""))
            };

            try
            {
                var idFuncionario = Repositorio.InserirFuncionario(funcionario);
                Repositorio.InserirDependente(dependente, idFuncionario);
                Repositorio.InserirEndereco(endereco, idFuncionario);
                Repositorio.InserirFuncao(funcao, idFuncionario);
                MessageBox.Show("Usuário salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: ");
            }
        }

        private void AtualizarSql()
        {
            DateTime DataAdimissao;
            DateTime.TryParse(MBDataAdimissao.Text, out DataAdimissao);

            DateTime DataNascimento;
            DateTime.TryParse(MBDataNascimento.Text, out DataNascimento);

            if (funcionarioId == null || funcionarioId <= 0)
            {
                return;
            }

            if (enderecoId == null || enderecoId <= 0)
            {
                return;
            }

            if (funcaoId == null || funcaoId <= 0)
            {
                return;
            }


            Funcionario funcionario = new Funcionario()
            {
                Id = (int)funcionarioId,
                NomeCompleto = textNome.Text,
                CPF = MBCpf.Text,
                RG = MBRG.Text,
                DataNascimento = DataNascimento,
                Genero = CBGenero.Text,
                EstadoCivil = CBEstadoCivil.Text,
                Situacao = Situacao.Checked ? "Ativo" : "Inativo",
            };

            Endereco Endereco = new Endereco()
            {
                Id = (int)enderecoId,
                CEP = MBCEP.Text,
                Logradouro = TXTLogradouro.Text,
                Numero = TXTNumero.Text,
                Complemento = TXTComplemento.Text,
                Bairro = TXTBairro.Text,
                Cidade = TXTCidade.Text,
                Estado = CBEstado.Text,
            };

            Funcao Funcao = new Funcao()
            {
                Id = (int)funcaoId,
                Cargo = TXTCargo.Text,
                Departamento = TXTDepartamento.Text,
                DataAdmissao = DataAdimissao,
                Salario = decimal.Parse(MBSalario.Text.Replace("R$", ""))
            };

            try
            {
                Repositorio.AtualizarFuncionario(funcionario, Endereco, Funcao);
                MessageBox.Show("Funcionário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void CarregarFuncionarioPorId(int funcionarioId)
        {
            string connectionString = "server=localhost;user=root;password=;database=GestaoRH;";
            string query = @"
        SELECT 
            f.id, f.NomeCompleto AS NomeFuncionario, f.Cpf, f.Rg, f.DataNascimento, f.Genero, f.EstadoCivil,
            e.id AS EnderecoId, e.Cep, e.Logradouro, e.Numero, e.Complemento, e.Bairro, e.Cidade, e.Estado,
            fn.id AS FuncaoId, fn.Cargo, fn.Departamento, fn.DataAdmissao, fn.Salario,
            d.id AS DependenteId, d.NomeCompleto AS NomeDependente, d.Cpf AS CpfDependente, d.Rg AS RgDependente, 
            d.DataNascimento AS NascimentoDependente, d.Genero AS GeneroDependente, d.Parentesco
        FROM Funcionario f
        INNER JOIN Funcao fn ON f.id = fn.FuncionarioId
        INNER JOIN Endereco e ON f.id = e.FuncionarioId
        INNER JOIN Dependentes d ON f.id = d.FuncionarioId
        WHERE f.id = @id;";



            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", funcionarioId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Funcionario
                            textNome.Text = reader["NomeFuncionario"].ToString();
                            MBCpf.Text = reader["Cpf"].ToString();
                            MBRG.Text = reader["Rg"].ToString();
                            string dataNascimentoStr = Convert.ToDateTime(reader["DataNascimento"]).ToString("dd/MM/yyyy");
                            MBDataNascimento.Text = dataNascimentoStr;
                            CBGenero.Text = reader["Genero"] != DBNull.Value ? reader["Genero"].ToString() : "Não especificado";
                            CBEstado.Text = reader["Estado"] != DBNull.Value ? reader["Estado"].ToString() : "Não especificado";
                            CBEstadoCivil.Text = reader["EstadoCivil"] != DBNull.Value ? reader["EstadoCivil"].ToString() : "Não especificado";





                            // Endereço
                            enderecoId = (int)reader["EnderecoId"];
                            MBCEP.Text = reader["Cep"].ToString();
                            TXTLogradouro.Text = reader["Logradouro"].ToString();
                            TXTNumero.Text = reader["Numero"].ToString();
                            TXTComplemento.Text = reader["Complemento"] != DBNull.Value ? reader["Complemento"].ToString() : "Não especificado";

                            TXTBairro.Text = reader["Bairro"].ToString();
                            TXTCidade.Text = reader["Cidade"].ToString();
                            CBEstado.SelectedItem = reader["Estado"].ToString();

                            // Função
                            funcaoId = (int)reader["FuncaoId"];
                            TXTCargo.Text = reader["Cargo"].ToString();
                            TXTDepartamento.Text = reader["Departamento"].ToString();
                            string dataAdmissão = Convert.ToDateTime(reader["DataNascimento"]).ToString("dd/MM/yyyy");
                            MBDataAdimissao.Text = dataAdmissão;
                            MBSalario.Text = reader["Salario"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado.");
                        }
                    }
                }
            }
        }





        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool update = !string.IsNullOrEmpty(textBoxID.Text);

            if (update)
            {
                // UPDATE
                AtualizarSql();
                return;
            }

            // INSERT
            if (ValidarDadosPessoais() || ValidarEndereco() || ValidarFuncao() || (checkBox1.Checked && ValidarDependentes()))
            {
                return;
            }

            InserirSql();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Interface_Inicial fomr2 = new Interface_Inicial();
            fomr2.Show();
            this.Close();
        }

        private void checkBoxDependente_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDadoPessoal.Enabled = checkBox1.Checked;
        }

        private void Tela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Interface_Inicial fomr2 = new Interface_Inicial();
            fomr2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool update = !string.IsNullOrEmpty(textBoxID.Text);

            if (update)
            {
                // UPDATE
                AtualizarSql();
                return;
            }

            // INSERT
            if (ValidarDadosPessoais() || ValidarEndereco() || ValidarFuncao() || (checkBox1.Checked && ValidarDependentes()))
            {
                return;
            }

            InserirSql();
        }

        private void groupBoxDependente_Enter(object sender, EventArgs e)
        {
            groupBoxDependente.Enabled = checkBox1.Checked;
        }

        private void Situacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
