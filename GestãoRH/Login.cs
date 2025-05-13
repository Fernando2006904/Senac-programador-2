using GestãoRH;
using GestaoRH;
using MySql.Data.MySqlClient;

namespace visualPI
{
    public partial class Login : Form
    {
        private static readonly string ConnectionString = "server=localhost;user=root;password=;database=Gestaorh;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                lUsuario.Text = "Usuário obrigatório!";
                lUsuario.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                lSenha.Text = "Senha obrigatória!";
                lSenha.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;

            try
            {
                {
                    Connection.Open();

                    string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';";

                    MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    autenticado = reader.Read() && reader.GetString(0) == senha;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro de banco de dados: {ex.Message}");
            }
            finally
            {
                Connection.Close();
            }

            if (!autenticado)
            {
                lErro.Text = "Usuário ou senha incorretos...";
                lErro.ForeColor = Color.Red;
                return;
            }



            Interface_Inicial form1 = new Interface_Inicial();
            form1.Show();
            this.Hide();



            txtUsuario.Clear();
            txtSenha.Clear();

        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tela_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}