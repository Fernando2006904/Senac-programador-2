using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CadastroCliente.Dom�nio;

namespace CadastroCliente
{
    public partial class Principal : Form
    {





        private readonly Cliente Cliente = new();
        private readonly List<Cliente> clientes = [];
        private readonly BindingSource BindingSource = [];



        //Para fixar o ID de todos os clientes
        private const int ID_Fixo = 4;
       private const int  Email_Fixo = 5234;
       private const int Telefone_Fixo = 11959; 




        public Principal()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("Masculino");
            comboBox1.Items.Add("Feminino");
            comboBox2.Items.Add("Branco");
            comboBox2.Items.Add("Negro");
            comboBox2.Items.Add("Pardo");
            
                
            
                

            









            Endere�oCliente endere�oFernando = new Endere�oCliente() { Logradouro = "Pra�a S�o jos�", Numero = "91", Complemento = "Ap10", Bairro = "Moraes", Municipio = "EmbuGua�u", Estado = "Maranh�o", CEP = "12345-10" };
            Cliente Fernando = new Cliente() { ID = 1, Nome = "Fernando", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Fefe18++@gmail.com", genero = genero.Masculino, endere�o = endere�oFernando, NomeSocial = "Fernando", etinia = Etinia_2.Pardo, Estrangeiro = Estrangeiro_Cliente.n�o, tipocliente = Tipocliente.PF };
            clientes.Add(Fernando);
            


            Endere�oCliente endere�oValdeci = new Endere�oCliente() { Logradouro = "Avenida 2", Numero = "76", Complemento = "Ap20", Bairro = "Jardim Espirito Santo", Municipio = "Vargem Grande", Estado = "Amazonas", CEP = "12345-20" };

            Cliente Valdeci = new Cliente() { ID = 2, Nome = "Valdeci", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Valdeci14!@gmail.com", genero = genero.Masculino, endere�o = endere�oFernando, NomeSocial = "Valdeci", etinia = Etinia_2.Pardo, Estrangeiro = Estrangeiro_Cliente.n�o, tipocliente = Tipocliente.PF };
            clientes.Add(Valdeci);


            Endere�oCliente endere�oMaria = new Endere�oCliente() { Logradouro = "Camposociety", Numero = "10", Complemento = "Ap30", Bairro = "Jardim Santa cruz", Municipio = "Embu4", Estado = "Rio de Janeiro", CEP = "12345-30" };
            Cliente Maria = new Cliente() { ID = 3, Nome = "Maria", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Maria10*@gmail.com", genero = genero.Feminino, endere�o = endere�oFernando, NomeSocial = "Maria", etinia = Etinia_2.Branco, Estrangeiro = Estrangeiro_Cliente.n�o, tipocliente = Tipocliente.PJ };
            clientes.Add(Maria);

            BindingSource.DataSource = clientes;
            dataGridView1.DataSource = BindingSource;


           

        }



        private void button1_Click(object sender, EventArgs e)
        {


           

            Endere�oCliente endere�oMaria = new Endere�oCliente() { Logradouro = "Camposociety", Numero = "10", Complemento = "Ap30", Bairro = "Jardim Santa cruz", Municipio = "Embu4", Estado = "Rio de Janeiro", CEP = "12345-30" };
            Cliente Maria = new Cliente() { ID = 3, Nome = "Maria", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Maria10*@gmail.com", genero = genero.Masculino, NomeSocial = "Maria", etinia = Etinia_2.Branco, Estrangeiro = Estrangeiro_Cliente.n�o, tipocliente = Tipocliente.PJ };


            clientes.Add(new Cliente() { ID = clientes.Max(Cliente => Cliente.ID) + 1, Email = textBox8.Text, telefone = maskedTextBox4.Text, Nome = textBox1.Text, datanascimento = maskedTextBox1.Text, genero = genero.Feminino , etinia = Etinia_2.Branco, tipocliente = Tipocliente.PJ, });







            BindingSource.ResetBindings(false);


            ValidarEmail();
            ValidarTelefone();
            ValidarGenero();
            EtniaCliente();










            string nome = textBox1.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome � obrigat�rio.");
                return;
            }


            if (nome.Any(c => Char.IsDigit(c) || Char.IsPunctuation(c)))
            {
                MessageBox.Show("O nome n�o pode conter n�meros ou caracteres especiais.");
                
            }


            MessageBox.Show("Nome v�lido.");


            DateTime datadenascimento;
            if (!DateTime.TryParse(textBox1.Text, out datadenascimento) || datadenascimento > DateTime.Now)
            {
                MessageBox.Show("Data de nascimento inv�lida. A data n�o pode ser no futuro.");
                






            }

            int idadeMinima = 18;
            int idade = DateTime.Now.Year - datadenascimento.Year;
            if (datadenascimento > DateTime.Now.AddYears(-idade)) idade--;
            {
                if (idade < idadeMinima)
                {
                    MessageBox.Show($"O cliente deve ter pelo menos {idadeMinima} anos.");
                    return;
                }

            }

            if (idade < idadeMinima)
            {
                MessageBox.Show($"O cliente deve ter pelo menos {idadeMinima} anos.");
               
            }


            MessageBox.Show("Data de nascimento V�lida.");
            









            //O ID fixo ser� o mesmo para todos os clientes

            MessageBox.Show($"Cliente cadastrado com ID {ID_Fixo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
           


        }








        private void ValidarEmail()
        {
            string email = textBox8.Text;
            string emailParttern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //O Regex foi usado para validar formato de dados como o email

            if (!Regex.IsMatch(email, emailParttern))
            {
                MessageBox.Show("O email deve conter @ e .com");
                textBox8.Focus(); //Coloca o foco no campo email
                return;
            }

            MessageBox.Show("O Email est� v�lido");





        }
        private void ValidarTelefone()
        {



        }


        private void ValidarGenero()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor, Selecione um g�nero (Masculino, Feminino).");
                return;
            }

            MessageBox.Show("Gen�ro V�lido");
        }


        private void EtniaCliente()
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor, Selecione uma Etnia (Branco,Negro ou Pardo.");
                return;

            }
            MessageBox.Show("Etnia V�lida");





        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("A Pessoa � estrangeira");
            }
            else
            {
                MessageBox.Show("A Pessoa n�o � estrangeira");
            }












        }

        private void button2_Click(object sender, EventArgs e)
        {
            string logradouro = TextBoxLogradouro.Text;

            if (string.IsNullOrEmpty(logradouro))
            {
                MessageBox.Show("O Campo de logradouro n�o pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            bool IsValid = false;
            foreach (char c in logradouro)
            {


                if (!Char.IsLetterOrDigit(c) && c != ' ' && c != ',' && c != '_' && c != '-')
                {
                    IsValid = false;




                }
            }
            if (IsValid)
            {



                MessageBox.Show("O logradouro cont�m caracteres inv�lidos. Apenas letras, n�meros, espa�os, v�rgulas, pontos e h�fens s�o permitidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            MessageBox.Show("Logradouro V�lido! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            string numeroCasa = textBox5.Text.Trim();

            if (string.IsNullOrEmpty(numeroCasa))
            {
                MessageBox.Show("O n�mero da casa n�o pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


            if (!numeroCasa.All(Char.IsDigit))
            {
                MessageBox.Show("O n�mero da casa deve conter apenas n�meros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("N�mero da casa v�lido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            



            string Complemento = TextBoxComplemento.Text;


            if (string.IsNullOrEmpty(Complemento))
            {
                MessageBox.Show("O Campo de complemento n�o pode estar vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            MessageBox.Show("O Complemento est� V�lido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string Bairro = textBox2.Text;

            if (string.IsNullOrEmpty (Bairro))
            {
                MessageBox.Show("O Bairro n�o foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Bairro Encontrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);



            string Municipio = textBox2.Text;

            if (string.IsNullOrEmpty(Municipio))
            {
                MessageBox.Show("O Municipio n�o foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Municipio Encontrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string CEP =maskedTextBox2.Text;

            if (string.IsNullOrEmpty(CEP))
            {
                MessageBox.Show("O formato do c�digo est� incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show("CEP Encontrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListarClientes(object sender, EventArgs e)
        {
            BindingSource.DataSource = Cliente;
            BindingSource.DataSource = Cliente.ListarClientes();
            dataGridViewClientes.DataSource = BindingSource;

        }


        
    }
        }
    


       

        
        

        

        
        

        
    
























           



            





        




    

 


      
