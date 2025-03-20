using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace CadastroCliente
{
    public partial class Principal : Form
    {





        private readonly List<Cliente> clientes = [];



        //Para fixar o ID de todos os clientes
        private const int ID_Fixo = 4;




        public Principal()
        {
            InitializeComponent();
            comboBox1.Items.Add("Masculino");
            comboBox1.Items.Add("Feminino");
            comboBox2.Items.Add("Branco");
            comboBox2.Items.Add("Negro");
            comboBox2.Items.Add("Pardo");
            
            
           

            

            

            EndereçoCliente endereçoFernando = new EndereçoCliente() { Logradouro = "Praça São josé", Numero = "91", Complemento = "Ap10", Bairro = "Moraes", Municipio = "EmbuGuaçu", Estado = "Maranhão", CEP = "12345-10" };
            Cliente Fernando = new Cliente() { ID = 1, Nome = "Fernando", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Fefe18++@gmail.com", genero = genero.Masculino, endereço = endereçoFernando, NomeSocial = "Fernando", etinia = Etinia_2.Pardo, Estrangeiro = Estrangeiro_Cliente.não, tipocliente = Tipocliente.PF };
            


            EndereçoCliente endereçoValdeci = new EndereçoCliente() { Logradouro = "Avenida 2", Numero = "76", Complemento = "Ap20", Bairro = "Jardim Espirito Santo", Municipio = "Vargem Grande", Estado = "Amazonas", CEP = "12345-20" };

            Cliente Valdeci = new Cliente() { ID = 2, Nome = "Valdeci", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Valdeci14!@gmail.com", genero = genero.Masculino, endereço = endereçoFernando, NomeSocial = "Valdeci", etinia = Etinia_2.Pardo, Estrangeiro = Estrangeiro_Cliente.não, tipocliente = Tipocliente.PF };
            


            EndereçoCliente endereçoMaria = new EndereçoCliente() { Logradouro = "Camposociety", Numero = "10", Complemento = "Ap30", Bairro = "Jardim Santa cruz", Municipio = "Embu4", Estado = "Rio de Janeiro", CEP = "12345-30" };
            Cliente Maria = new Cliente() { ID = 3, Nome = "Maria", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Maria10*@gmail.com", genero = genero.Feminino, endereço = endereçoFernando, NomeSocial = "Maria", etinia = Etinia_2.Branco, Estrangeiro = Estrangeiro_Cliente.não, tipocliente = Tipocliente.PJ };

        }

        

        private void button1_Click(object sender, EventArgs e)
        {



             ValidarEmail();     
            ValidarTelefone();
            ValidarGenero();
            EtniaCliente();

            
           
            






            string nome = textBox1.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome é obrigatório.");
                return;
            }


            if (nome.Any(c => Char.IsDigit(c) || Char.IsPunctuation(c)))
            {
                MessageBox.Show("O nome não pode conter números ou caracteres especiais.");
                return;
            }


            MessageBox.Show("Nome válido.");


            DateTime datadenascimento;
            if (!DateTime.TryParse(textBox1.Text, out datadenascimento) || datadenascimento > DateTime.Now)
            {
                MessageBox.Show("Data de nascimento inválida. A data não pode ser no futuro.");
                return;



                


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
                return;
            }


            MessageBox.Show("Data de nascimento Válida.");

            if (checkBox1.Checked)
            {
                MessageBox.Show("Pessoa Estrangeira! Validando dados específicos...");
            }
            else
            {
                MessageBox.Show("Pessoa não estrangeira! Validando dados nacionais...");
            }


            //O ID fixo será o mesmo para todos os clientes

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

            MessageBox.Show("O Email está válido");





        }
        private void ValidarTelefone()
        {



        }


        private void ValidarGenero()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor, Selecione um gênero (Masculino, Feminino).");
                return;
            }

            MessageBox.Show("Genêro Válido");
        }


        private void EtniaCliente()
        {
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor, Selecione uma Etnia (Branco,Negro ou Pardo.");
                return;

            }
            MessageBox.Show("Etnia Válida");





        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("A Pessoa é estrangeira");
            }
            else
            {
                MessageBox.Show("A Pessoa não é estrangeira");
            }












        }
    }
}




















           



            





        




    

 


      
