namespace CadastroCliente
{
    public partial class Form1 : Form
    {

        private readonly List<Cliente> clientes = [];
        public Form1()
        {
            InitializeComponent();
            //Cliente1



            EndereçoCliente endereçoFernando = new EndereçoCliente() { Logradouro = "Praça São josé", Numero = "91", Complemento = "Ap10", Bairro = "Moraes", Municipio = "EmbuGuaçu", Estado = "Maranhão", CEP = "12345-10"};
            Cliente Fernando = new Cliente() { ID = 1, Nome = "Fernando", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Fefe18++@gmail.com", genero =genero.Masculino, endereço  = endereçoFernando, NomeSocial = "Fernando", etinia = Etinia_2.Pardo, Estrangeiro = Estrangeiro_Cliente.não, tipocliente = Tipocliente.PF };
           //Cliente2


            EndereçoCliente endereçoValdeci = new EndereçoCliente() { Logradouro = "Avenida 2", Numero = "76", Complemento = "Ap20", Bairro = "Jardim Espirito Santo", Municipio = "Vargem Grande" , Estado = "Amazonas", CEP = "12345-20" };

            Cliente Valdeci = new Cliente() { ID =3, Nome = "Valdeci", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Valdeci14!@gmail.com", genero = genero.Masculino, endereço = endereçoFernando, NomeSocial = "Valdeci", etinia = Etinia_2.Pardo, Estrangeiro = Estrangeiro_Cliente.não, tipocliente = Tipocliente.PF };
            //Cliente3


            EndereçoCliente endereçoMaria = new EndereçoCliente() { Logradouro = "Camposociety", Numero = "10", Complemento = "Ap30", Bairro = "Jardim Santa cruz", Municipio = "Embu4", Estado = "Rio de Janeiro", CEP = "12345-30" };
            Cliente Maria = new Cliente() { ID = 2, Nome = "Maria", datanascimento = "01/01/1990", telefone = "11999999999", Email = "Maria10*@gmail.com", genero = genero.Feminino, endereço = endereçoFernando, NomeSocial = "Maria", etinia = Etinia_2.Branco, Estrangeiro = Estrangeiro_Cliente.não, tipocliente = Tipocliente.PJ };



        }


    }
}
