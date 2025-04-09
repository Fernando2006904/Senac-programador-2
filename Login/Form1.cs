using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form




    {
        
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";

       private readonly  MySqlConnection  Connection = new MySqlConnection(ConnectionString);



        public Form1()
        {
            InitializeComponent();
           
        }


        

       


        private void textBox2_TextChanged(object sender, EventArgs e)
        {









        }

        private void label3_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

            bool autenticado = false;
            string usuario = textboxusuario.Text;
            string senha = textboxsenha.Text;










            try
            {
                Connection.Open();

                string query = $"SELECT Senha    FROM   usuario WHERE    email = '{usuario}';";

                MySqlCommand MySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = MySqlCommand.ExecuteReader();


                autenticado = reader.Read() && reader.GetString(0) == senha;





            }
            catch 
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: ");
            }
            finally
            {
                Connection.Close();
            }

            




           






        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool autenticado = false;
            string usuario = textboxusuario.Text;
            string senha = textboxsenha.Text;










            try
            {
                Connection.Open();

                string query = $"SELECT Senha    FROM   usuario WHERE    email = '{usuario}';";

                MySqlCommand MySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = MySqlCommand.ExecuteReader();


                autenticado = reader.Read() && reader.GetString(0) == senha;





            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: ");
            }
            finally
            {
                Connection.Close();
            }
          

            if (usuario == null || usuario == "")
            {
                labelresultado.Text = "usuario eh obrigatorio!!!";
                labelresultado.ForeColor = Color.Red;
                

            }







           else if (usuario == "Fernando.Lima" && senha == "12345")
            {
                labelresultado.Text = "Autenticado com sucesso";
                labelresultado.ForeColor = Color.Green;
            }
            else
            {
                labelresultado.Text = "usuario ou senha incorretos...";
                labelresultado.ForeColor = Color.Red;
            }


            


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void labelsenha_Click(object sender, EventArgs e)
        {

        }
    }
}
